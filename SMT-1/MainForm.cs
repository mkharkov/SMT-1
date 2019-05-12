using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using System.IO;

using System.Timers;
using System.IO.Ports;

namespace SMT_1
{
    public partial class MainForm : Form
    {
        private EngineController engine;
        private LoadController load;
        private FileController fileRW;
        private FanController leftFan;
        private FanController rightFan;

        private int chartSecondsCounter = 0;
        private List<Point2D> chartDataTemp1 = new List<Point2D>();
        private List<Point2D> chartDataTemp2 = new List<Point2D>();
        private List<Point2D> chartDataLoad = new List<Point2D>();

        private int executeTimeCounter = 0;
        bool isPlanInExecution = false;
        bool isChartBeingRendered = false;

        bool isArduinoFound = false;

        Thread dataCollector;

        // Commands to arduino
        private readonly byte spResetConnection = 0x31;
        private readonly byte spStart = 0x32;
        private readonly byte spAllOk = 0x33;

        private readonly string initializedStr = "INITIALIZED";
        private readonly string notInitializedStr = "ARDUINO";

        //REMOVE
        string threadStrDbg = "";

        int Test1 = 0;
        int Test2 = 0;
        //REMOVE
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeControllers()
        {
            engine = new EngineController();
            load = new LoadController();
            fileRW = new FileController();
            leftFan = new FanController();
            rightFan = new FanController();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            InitializeControllers();

            openFileDialogPlan.FileName = "";
            openFileDialogPlan.Filter = "text files (*.txt)|*.txt";
            saveFileDialogPlan.DefaultExt = ".txt";
            saveFileDialogPlan.Filter = "text files (*.txt)|*.txt";

            textBoxT0.Text = "Degrees";

            SetAllControlToInitial();

            textBoxPlanEngineVoltage.Text = EngineController.RpmToVoltage((int)numericUpDownControlEngineRPM.Value).ToString();

            numericUpDownPlanLoadedWeight.Value = trackBarLoadedWeight.Value;
            numericUpDownPlanFirstTemp.Value = trackBarFirstTemp.Value;
            numericUpDownPlanSecondTemp.Value = trackBarSecondTemp.Value;

            EnableAllUI(false);
            await ScanForArduino();
            if(isArduinoFound)
                EnableAllUI(true);
        }

        private void EnableAllUI(bool enable)
        {

        }

        private void trackBarFirstTemp_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownPlanFirstTemp.Value = trackBarFirstTemp.Value;
        }

        private void trackBarLoadedWeight_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownPlanLoadedWeight.Value = trackBarLoadedWeight.Value;
        }

        private void trackBarSecondTemp_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownPlanSecondTemp.Value = trackBarSecondTemp.Value;
        }

        private void trackBarControlEngineRPM_ValueChanged(object sender, EventArgs e)
        {
            textBoxControlEngineVoltage.Text = EngineController.RpmToVoltage(trackBarControlEngineRPM.Value).ToString();
            numericUpDownControlEngineRPM.Value = trackBarControlEngineRPM.Value;
        }

        private void numericUpDownControlEngineRPM_ValueChanged(object sender, EventArgs e)
        {
            trackBarControlEngineRPM.Value = (int)numericUpDownControlEngineRPM.Value;
            textBoxControlEngineVoltage.Text = EngineController.RpmToVoltage((int)numericUpDownControlEngineRPM.Value).ToString();
        }

        private void buttonControlEngineStop_Click(object sender, EventArgs e)
        {
            engine.On = false;
            textBoxCurrentEngineOn.Text = "Ні";
        }

        private void buttonControlEngineSetValues_Click(object sender, EventArgs e)
        {
            engine.RPM = (int)numericUpDownControlEngineRPM.Value; //Voltage will be set automatically
            textBoxControlEngineCurrentRPM.Text = engine.RPM.ToString();
            textBoxControlEngineCurrentVoltage.Text = ((int)engine.Voltage).ToString();
        }

        private void buttonControlEngineStart_Click(object sender, EventArgs e)
        {
            engine.On = true;
            textBoxCurrentEngineOn.Text = "Так";
        }

        //SHOWING DEBUG INFO ABOUT STATE OF MAIN FORM
        private void buttonShowDebugInfo_Click(object sender, EventArgs e)
        {
            string dbg = string.Format("Engine Info:\n" +
                "\tON: {0}\n" +
                "\tRPM: {1}\n" +
                "\tVoltage: {2}\n" +
                "**************\n" +
                "Load info:\n" +
                "\tload: {4}\n" +
                "**************\n" +
                "File info:\n" +
                "\tFileName: {3}\n" +
                "**************\n" +
                "isPlanInExecution: {5}\n" +
                "**************\n" +
                "LeftFan: ON({6}), Vent({7})\n" +
                "**************\n" +
                "RightFan: ON({8}), Vent({9})\n" +
                "**************\n" +
                "", engine.On, engine.RPM, engine.Voltage, openFileDialogPlan.FileName, load.Load, isPlanInExecution, leftFan.On, leftFan.VentOpen, rightFan.On, rightFan.VentOpen);
            if (fileRW.GetRecords().Count != 0)
                dbg += "Records:\n";
            foreach (PlanRecord pl in fileRW.GetRecords())
            {
                //string timeHours = String.Format("{0}", pl.GetTime().Hours).PadLeft(2, '0');
                //string timeMinutes = String.Format("{0}", pl.GetTime().Minutes).PadLeft(2, '0');
                //dbg += String.Format("\ttime={0};speed={1};load={2};t1={3};t2={4};\n", String.Format("{0}:{1}", timeHours, timeMinutes), pl.GetSpeed(), pl.GetLoad(), pl.GetT1(), pl.GetT2());
                dbg += pl.ToString();
            }
            if (fileRW.GetRecords().Count != 0)
                dbg += "**************\n";
            dbg += "temp1Data:\n";
            foreach (Point2D point in chartDataTemp1)
                dbg += point.ToString() + "\n";
            dbg += "**************\n";
            dbg += "temp2Data:\n";
            foreach (Point2D point in chartDataTemp2)
                dbg += point.ToString() + "\n";
            dbg += "**************\n";
            dbg += "loadData:\n";
            foreach (Point2D point in chartDataLoad)
                dbg += point.ToString() + "\n";
            dbg += "**************\n";
            //richTextBoxDebug.Text = dbg; //UNCOMMENT
            richTextBoxDebug.Text = threadStrDbg; //REMOVE
        }

        private void listViewPlanRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            //trackBarPlanEngineSpeed.Value = int.Parse(listViewPlanRecords.SelectedItems[0].SubItems[2].Text);
            //textBoxPlanEngineRPM;
            //textBoxPlanEngineVoltage;
            if (listViewPlanRecords.SelectedItems.Count > 0)
            {
                numericUpDownPlanEngineRPM.Value = int.Parse(listViewPlanRecords.SelectedItems[0].SubItems[2].Text);
                trackBarFirstTemp.Value = int.Parse(listViewPlanRecords.SelectedItems[0].SubItems[4].Text);
                trackBarSecondTemp.Value = int.Parse(listViewPlanRecords.SelectedItems[0].SubItems[5].Text);
                trackBarLoadedWeight.Value = int.Parse(listViewPlanRecords.SelectedItems[0].SubItems[3].Text);

                var time = TimeSpan.Parse(listViewPlanRecords.SelectedItems[0].SubItems[1].Text);
                numericUpDownPlanHours.Value = time.Hours;
                numericUpDownPlanMinutes.Value = time.Minutes;

                textBoxPlanSelectedRecordNumber.Text = listViewPlanRecords.SelectedItems[0].SubItems[0].Text;
            }
            else
            {
                numericUpDownPlanEngineRPM.Value = numericUpDownPlanEngineRPM.Minimum;
                trackBarFirstTemp.Value = trackBarFirstTemp.Minimum;
                trackBarSecondTemp.Value = trackBarSecondTemp.Minimum;
                trackBarLoadedWeight.Value = trackBarLoadedWeight.Minimum;

                textBoxPlanSelectedRecordNumber.Text = "";
            }
        }

        private void buttonControlEngineRestore_Click(object sender, EventArgs e)
        {
            trackBarControlEngineRPM.Value = engine.RPM;
        }

        private void numericUpDownPlanEngineRPM_ValueChanged(object sender, EventArgs e)
        {
            textBoxPlanEngineVoltage.Text = EngineController.RpmToVoltage((int)numericUpDownPlanEngineRPM.Value).ToString();
            trackBarPlanEngineRPM.Value = (int)numericUpDownPlanEngineRPM.Value;
        }

        private void buttonApplyPlanRecordChanges_Click(object sender, EventArgs e)
        {
            if (listViewPlanRecords.SelectedItems.Count > 0)
            {
                string timeHours = String.Format("{0}", numericUpDownPlanHours.Value).PadLeft(2, '0');
                string timeMinutes = String.Format("{0}", numericUpDownPlanMinutes.Value).PadLeft(2, '0');

                listViewPlanRecords.SelectedItems[0].SubItems[1].Text = String.Format("{0}:{1}", timeHours, timeMinutes);
                listViewPlanRecords.SelectedItems[0].SubItems[2].Text = numericUpDownPlanEngineRPM.Value.ToString();
                listViewPlanRecords.SelectedItems[0].SubItems[3].Text = trackBarLoadedWeight.Value.ToString();
                listViewPlanRecords.SelectedItems[0].SubItems[4].Text = trackBarFirstTemp.Value.ToString();
                listViewPlanRecords.SelectedItems[0].SubItems[5].Text = trackBarSecondTemp.Value.ToString();
            }
            else
            {
                MessageBox.Show("Запис не обрано", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void trackBarPlanEngineRPM_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownPlanEngineRPM.Text = trackBarPlanEngineRPM.Value.ToString();
        }

        private void buttonRejectPlanRecordChanges_Click(object sender, EventArgs e)
        {
            if (listViewPlanRecords.SelectedItems.Count > 0)
            {
                numericUpDownPlanEngineRPM.Value = int.Parse(listViewPlanRecords.SelectedItems[0].SubItems[2].Text);
                trackBarFirstTemp.Value = int.Parse(listViewPlanRecords.SelectedItems[0].SubItems[4].Text);
                trackBarSecondTemp.Value = int.Parse(listViewPlanRecords.SelectedItems[0].SubItems[5].Text);
                trackBarLoadedWeight.Value = int.Parse(listViewPlanRecords.SelectedItems[0].SubItems[3].Text);

                var time = TimeSpan.Parse(listViewPlanRecords.SelectedItems[0].SubItems[1].Text);
                numericUpDownPlanHours.Value = time.Hours;
                numericUpDownPlanMinutes.Value = time.Minutes;

                textBoxPlanSelectedRecordNumber.Text = listViewPlanRecords.SelectedItems[0].SubItems[0].Text;
            }
            else
            {
                numericUpDownPlanEngineRPM.Value = numericUpDownPlanEngineRPM.Minimum;
                trackBarFirstTemp.Value = trackBarFirstTemp.Minimum;
                trackBarSecondTemp.Value = trackBarSecondTemp.Minimum;
                trackBarLoadedWeight.Value = trackBarLoadedWeight.Minimum;

                textBoxPlanSelectedRecordNumber.Text = "";
            }
        }

        private void buttonRecordAdd_Click(object sender, EventArgs e)
        {
            //if(isPlanInExecution)
            //{
            //    MessageBox.Show("Виконується план\n" + "Запис не буде додано", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    return;
            //}

            // Getting last element of list
            var r = Enumerable.Empty<ListViewItem>();

            if (listViewPlanRecords.Items.Count > 0)
                r = this.listViewPlanRecords.Items.OfType<ListViewItem>();

            var last = r.LastOrDefault();

            int newIdx = 0;
            if (last != null)
            {
                newIdx = int.Parse(last.SubItems[0].Text) + 1;
            }

            string timeHours = String.Format("{0}", numericUpDownPlanHours.Value).PadLeft(2, '0');
            string timeMinutes = String.Format("{0}", numericUpDownPlanMinutes.Value).PadLeft(2, '0');

            string[] arr = { newIdx.ToString(), // index
                                 String.Format("{0}:{1}", timeHours, timeMinutes), // time
                                 numericUpDownPlanEngineRPM.Value.ToString(),      // rpm
                                 trackBarLoadedWeight.Value.ToString(),            // loadedWeight
                                 trackBarFirstTemp.Value.ToString(),               // temp1
                                 trackBarSecondTemp.Value.ToString()};             // temp2

            listViewPlanRecords.Items.Add(new ListViewItem(arr));
        }

        private void buttonRecordDelete_Click(object sender, EventArgs e)
        {
            if (listViewPlanRecords.SelectedItems.Count > 0)
            {
                int idx = int.Parse(listViewPlanRecords.SelectedItems[0].SubItems[0].Text);
                listViewPlanRecords.Items.RemoveAt(idx);
                MessageBox.Show(String.Format("Запис №{0} видалено\nСписок реорганізовано", idx), "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Change all indexes
                int i = 0;
                foreach (ListViewItem elem in listViewPlanRecords.Items)
                {
                    elem.Text = i.ToString();
                    i++;
                }

                numericUpDownPlanEngineRPM.Value = numericUpDownPlanEngineRPM.Minimum;
                trackBarFirstTemp.Value = trackBarFirstTemp.Minimum;
                trackBarSecondTemp.Value = trackBarSecondTemp.Minimum;
                trackBarLoadedWeight.Value = trackBarLoadedWeight.Minimum;
                textBoxPlanSelectedRecordNumber.Text = "";
            }
            else
            {
                MessageBox.Show("Запис не вибрано", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonRecordUp_Click(object sender, EventArgs e)
        {
            if (listViewPlanRecords.SelectedItems.Count > 0)
            {
                int idxA = listViewPlanRecords.SelectedItems[0].Index;
                if (idxA == 0)
                {
                    MessageBox.Show("Запис на горі списку", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int idxB = idxA - 1;

                ListViewItem itemA = listViewPlanRecords.Items[idxA];
                ListViewItem itemB = listViewPlanRecords.Items[idxB];

                listViewPlanRecords.Items.RemoveAt(idxA);
                listViewPlanRecords.Items.RemoveAt(idxB);

                string tempIdx = itemA.SubItems[0].Text;
                itemA.SubItems[0].Text = itemB.SubItems[0].Text;
                itemB.SubItems[0].Text = tempIdx;

                listViewPlanRecords.Items.Insert(idxB, itemA);
                listViewPlanRecords.Items.Insert(idxA, itemB);
            }
            else
            {
                MessageBox.Show("Запис не обрано", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonRecordDown_Click(object sender, EventArgs e)
        {
            if (listViewPlanRecords.SelectedItems.Count > 0)
            {
                int idxA = listViewPlanRecords.SelectedItems[0].Index;
                if (idxA == listViewPlanRecords.Items.Count - 1)
                {
                    MessageBox.Show("Запис внизу списку", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int idxB = idxA + 1;

                ListViewItem itemA = listViewPlanRecords.Items[idxA];
                ListViewItem itemB = listViewPlanRecords.Items[idxB];

                listViewPlanRecords.Items.RemoveAt(idxB);
                listViewPlanRecords.Items.RemoveAt(idxA);

                string tempIdx = itemA.SubItems[0].Text;
                itemA.SubItems[0].Text = itemB.SubItems[0].Text;
                itemB.SubItems[0].Text = tempIdx;

                listViewPlanRecords.Items.Insert(idxA, itemB);
                listViewPlanRecords.Items.Insert(idxB, itemA);
            }
            else
            {
                MessageBox.Show("Запис не обрано", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonLoadFileFromPath_Click(object sender, EventArgs e)
        {
            if (openFileDialogPlan.ShowDialog() == DialogResult.OK)
            {
                if (fileRW.LoadFromFile(openFileDialogPlan.FileName))
                {
                    listViewPlanRecords.Items.Clear();
                    int idx = 0;
                    foreach (PlanRecord pl in fileRW.GetRecords())
                    {
                        listViewPlanRecords.Items.Add(new ListViewItem(new string[] { idx.ToString(),
                                                                                        pl.GetTimeStr(),
                                                                                        pl.GetSpeed().ToString(),
                                                                                        pl.GetLoad().ToString(),
                                                                                        pl.GetT1().ToString(),
                                                                                        pl.GetT2().ToString() }));
                        idx++;
                    }
                } else {
                    MessageBox.Show("Вміст файлу не відповідає заданому формату\nФормат:\n" + FileController.FileFormatString, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonSavePlan_Click(object sender, EventArgs e)
        {
            if (saveFileDialogPlan.ShowDialog() == DialogResult.OK)
            {
                List<string> list = new List<string>(listViewPlanRecords.Items.Count);
                foreach (ListViewItem item in listViewPlanRecords.Items)
                {
                    list.Add(FileController.ApplyTemplate(item.SubItems[1].Text,
                                                          item.SubItems[2].Text,
                                                          item.SubItems[3].Text,
                                                          item.SubItems[4].Text,
                                                          item.SubItems[5].Text));
                }

                if (!fileRW.SaveToFile(saveFileDialogPlan.FileName, list))
                {
                    MessageBox.Show("Помилка при збереженні", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void trackBarControlLoad_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownControlLoad.Value = trackBarControlLoad.Value;
        }

        private void numericUpDownControlLoad_ValueChanged(object sender, EventArgs e)
        {
            trackBarControlLoad.Value = (int)numericUpDownControlLoad.Value;
        }

        private void buttonControlLoadSetValues_Click(object sender, EventArgs e)
        {
            load.Load = trackBarControlLoad.Value;
            textBoxControlCurrentLoad.Text = load.Load.ToString();
        }

        private void buttonControlLoadRestore_Click(object sender, EventArgs e)
        {
            trackBarControlLoad.Value = load.Load;
        }

        private Dictionary<int, PlanRecord> Convert_ListViewItems_ToList()
        {
            Dictionary<int, PlanRecord> records = new Dictionary<int, PlanRecord>(listViewPlanRecords.Items.Count);

            foreach (ListViewItem item in listViewPlanRecords.Items)
            {
                PlanRecord record = new PlanRecord();

                record.TrustedSetData(TimeSpan.Parse(item.SubItems[1].Text),
                                      int.Parse(item.SubItems[2].Text),
                                      int.Parse(item.SubItems[3].Text),
                                      int.Parse(item.SubItems[4].Text),
                                      int.Parse(item.SubItems[5].Text));

                records.Add(int.Parse(item.SubItems[0].Text), record);
            }

            return records;
        }

        private void numericUpDownPlanLoadedWeight_ValueChanged(object sender, EventArgs e)
        {
            trackBarLoadedWeight.Value = (int)numericUpDownPlanLoadedWeight.Value;
        }

        private async void buttonStartSelected_Click(object sender, EventArgs e)
        {
            if (listViewPlanRecords.SelectedItems.Count > 0)
            {
                Dictionary<int, PlanRecord> recordsToExecute = Convert_ListViewItems_ToList();
                //Видалення записів, які не будуть виконуватись
                int executeFromIdx = int.Parse(listViewPlanRecords.SelectedItems[0].SubItems[0].Text);
                foreach (var toDelete in recordsToExecute.Where(kv => kv.Key < executeFromIdx).ToList())
                {
                    recordsToExecute.Remove(toDelete.Key);
                }

                await ExecutePlanAsync(recordsToExecute);

            } else {
                MessageBox.Show("Запис не обрано", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async Task ExecutePlanAsync(Dictionary<int, PlanRecord> recordsToExecute)
        {
            SetAllControlToInitial();
            PlanInExecutionControlDisabler(true);

            isPlanInExecution = true;
            Dispatcher uiDispatcher = Dispatcher.CurrentDispatcher;
            executeTimeCounter = 0;
            await Task.Run(() => //task is synchronous for itself
            {
                DateTime recordEndTime = DateTime.Now;
                DateTime recordStartTime;
                foreach (KeyValuePair<int, PlanRecord> recordKV in recordsToExecute)
                {
                    recordStartTime = recordEndTime;
                    recordEndTime = recordEndTime.Add(recordKV.Value.GetTime());
                    executeTimeCounter = (int)recordEndTime.Subtract(recordStartTime).TotalSeconds;

                    var uiDispatcherTask = uiDispatcher.BeginInvoke(new Action(() =>
                    {
                        textBoxRecordInExecution.Text = recordKV.Key.ToString();
                        textBoxStartTime.Text = recordStartTime.ToString("hh:mm:ss tt");
                        textBoxEndTime.Text = recordEndTime.ToString("hh:mm:ss tt");
                        textBoxRemainingTime.Text = executeTimeCounter.ToString();
                        timerCurrentRecord.Start();
                    }), null);
                    uiDispatcherTask.Wait();

                    while (DateTime.Now < recordEndTime)
                    {
                        if (!isPlanInExecution)
                            return;
                        Thread.Sleep(1000);
                    }
                }
            });

            PlanInExecutionControlDisabler(false);
            SetAllControlToInitial();
            MessageBox.Show("Виконання плану завершено", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonStopPlan_Click(object sender, EventArgs e)
        {
            isPlanInExecution = false;
        }

        private void SetAllControlToInitial()
        {
            textBoxRecordInExecution.Text = "План не вибрано";
            textBoxEndTime.Text = textBoxRemainingTime.Text = textBoxStartTime.Text = "";

            // Engine to default
            engine.On = false;
            numericUpDownControlEngineRPM.Value = trackBarControlEngineRPM.Value = engine.RPM = EngineController.minRPM;

            textBoxControlEngineVoltage.Text = EngineController.RpmToVoltage(trackBarControlEngineRPM.Value).ToString();
            textBoxControlEngineCurrentRPM.Text = engine.RPM.ToString();
            textBoxControlEngineCurrentVoltage.Text = ((int)engine.Voltage).ToString();

            // Load to default
            numericUpDownControlLoad.Value = trackBarControlLoad.Value = load.Load = LoadController.minLoad;
            textBoxControlCurrentLoad.Text = load.Load.ToString();

            // Vents to default
            checkBoxControlCurrentLeftFanOn.Checked = false;
            checkBoxControlCurrentRightFanOn.Checked = false;
            checkBoxControlCurrentLeftVentOn.Checked = false;
            checkBoxControlCurrentRightVentOn.Checked = false;

            isPlanInExecution = false;
        }

        private void PlanInExecutionControlDisabler(bool needToDisable)
        {
            // Plan tab
            buttonRecordAdd.Enabled = 
            buttonRecordDelete.Enabled =
            buttonRecordUp.Enabled = 
            buttonRecordDown.Enabled =

            buttonApplyPlanRecordChanges.Enabled =
            buttonStartSelected.Enabled =
            buttonLoadFileFromPath.Enabled =

            //Control tab
            //TODO: чи надавати можливість керування вентиляторами під час виконання плану?
            buttonControlEngineStart.Enabled =
            buttonControlEngineStop.Enabled =
            buttonControlEngineSetValues.Enabled =
            buttonControlLoadSetValues.Enabled =

            !needToDisable;
        }

        private void numericUpDownPlanSecondTemp_ValueChanged(object sender, EventArgs e)
        {
            trackBarSecondTemp.Value = (int)numericUpDownPlanSecondTemp.Value;
        }

        private void numericUpDownPlanFirstTemp_ValueChanged(object sender, EventArgs e)
        {
            trackBarFirstTemp.Value = (int)numericUpDownPlanFirstTemp.Value;
        }

        private void buttonControlOnOffLeftFan_Click(object sender, EventArgs e)
        {
            leftFan.On = !leftFan.On;
            checkBoxControlCurrentLeftFanOn.Checked = leftFan.On;
        }

        private void buttonControlOnOffRightFan_Click(object sender, EventArgs e)
        {
            rightFan.On = !rightFan.On;
            checkBoxControlCurrentRightFanOn.Checked = rightFan.On;
        }

        private void buttonControlOnOffLeftVent_Click(object sender, EventArgs e)
        {
            leftFan.VentOpen = !leftFan.VentOpen;
            checkBoxControlCurrentLeftVentOn.Checked = leftFan.VentOpen;
        }

        private void buttonControlOnOffRightVent_Click(object sender, EventArgs e)
        {
            rightFan.VentOpen = !rightFan.VentOpen;
            checkBoxControlCurrentRightVentOn.Checked = rightFan.VentOpen;
        }

        private void timerCurrentRecord_Tick(object sender, EventArgs e)
        {
            if (executeTimeCounter > 0 && isPlanInExecution)
            {
                executeTimeCounter--;
                textBoxRemainingTime.Text = executeTimeCounter.ToString();
            } else {
                timerCurrentRecord.Stop();
            }
            
        }

        private void numericUpDownTest1_ValueChanged(object sender, EventArgs e)
        {
            Test1 = (int)numericUpDownTest1.Value;
        }

        private void numericUpDownTest2_ValueChanged(object sender, EventArgs e)
        {
            Test2 = (int)numericUpDownTest2.Value;
        }
        
        private void timerChartInfo_Tick(object sender, EventArgs e)
        {
            chartSecondsCounter++;
            //Collect info
            chartTemperature.Series["T1"].Points.AddXY(chartSecondsCounter, Test1);
            chartTemperature.Series["T2"].Points.AddXY(chartSecondsCounter, Test2);
            //Write to tempdata
            chartDataTemp1.Add(new Point2D((int)chartTemperature.Series["T1"].Points.Last().XValue, (int)chartTemperature.Series["T1"].Points.Last().YValues[0]));
            chartDataTemp2.Add(new Point2D((int)chartTemperature.Series["T2"].Points.Last().XValue, (int)chartTemperature.Series["T2"].Points.Last().YValues[0]));

            int newLoadValue = -100;
            if (isPlanInExecution)
            {
                int recordIdx = int.Parse(textBoxRecordInExecution.Text);
                newLoadValue = int.Parse(listViewPlanRecords.Items[recordIdx].SubItems[3].Text);
            } else {
                newLoadValue = load.Load;
            }
            chartLoad.Series["Load"].Points.AddXY(chartSecondsCounter, newLoadValue);
            chartDataLoad.Add(new Point2D((int)chartLoad.Series["Load"].Points.Last().XValue, (int)chartLoad.Series["Load"].Points.Last().YValues[0]));
        }

        private void buttonStopChartsRead_Click(object sender, EventArgs e)
        {
            timerChartInfo.Stop();
            isChartBeingRendered = false;
        }

        private void buttonStartChartsRead_Click(object sender, EventArgs e)
        {
            timerChartInfo.Start();
            isChartBeingRendered = true;
        }

        private async void buttonSaveCharts_Click(object sender, EventArgs e)
        {
            if (isChartBeingRendered)
            {
                MessageBox.Show("Для запису даних графіків у файл потрібно зупинити їх відображення", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string dirName = DateTime.Now.ToString("dd.MM.yy hh-mm tt"); // dd/mm/yy hh:mm:ss tt

            if (Directory.Exists(dirName))
            {
                DialogResult dRes = MessageBox.Show($"Каталог {dirName} вже існує\nПерезаписати?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dRes == DialogResult.No) {
                    return;
                }

                Directory.Delete(dirName, true); //delete folder and its contents
            }

            await Task.Run(() =>
            {
                DirectoryInfo dirInfo = Directory.CreateDirectory(dirName);
                FileStream temp1FileStream = File.Create(dirInfo.FullName + @"\Температура1.txt");
                FileStream temp2FileStream = File.Create(dirInfo.FullName + @"\Температура2.txt");
                FileStream loadFileStream = File.Create(dirInfo.FullName + @"\Навантаження.txt");

                // writing temp1
                for (int i = 0; i < chartSecondsCounter; i++)
                {
                    WriteTextToFile(temp1FileStream, chartDataTemp1[i].ToString() + "\r\n");
                    WriteTextToFile(temp2FileStream, chartDataTemp2[i].ToString() + "\r\n");
                    WriteTextToFile(loadFileStream, chartDataLoad[i].ToString() + "\r\n");
                }

                // Release files
                temp1FileStream.Close();
                temp2FileStream.Close();
                loadFileStream.Close();
            });

            MessageBox.Show($"Дані записано в каталог {dirName}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void WriteTextToFile(FileStream fs, string text)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            fs.Write(info, 0, info.Length);
        }

        private void buttonClearCharts_Click(object sender, EventArgs e)
        {
            chartSecondsCounter = 0;
            chartDataTemp1.Clear();
            chartDataTemp2.Clear();
            chartDataLoad.Clear();
        }

        private async Task ScanForArduino()
        {
            await Task.Run(async () => 
            {
                string[] ports = SerialPort.GetPortNames();
                foreach (string p in ports)
                {
                    MessageBox.Show($"Сканується порт {p}"); // DEBUG REMOVE THIS
                    serialPortArduino = new SerialPort(p, 9600);
                    if (ArduinoDetected())
                    {
                        MessageBox.Show($"Arduino знайдено на порті {p}");
                        isArduinoFound = true;
                        break;
                    }
                    System.Threading.Thread.Sleep(1000); // wait a lot after closing serial
                }

                if (!isArduinoFound)
                {
                    MessageBox.Show($"Arduino не знайдено\nДля нормального функціонування програми підключіть Arduino і натисніть кнопку 'Сканувати порти'", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                serialPortArduino.BaudRate = 9600;
                serialPortArduino.DtrEnable = true;
                serialPortArduino.ReadTimeout = 1000;
                try
                {
                    serialPortArduino.Open();
                    System.Threading.Thread.Sleep(1000); // Need to wait before port is open....
                    serialPortArduino.DiscardInBuffer();
                    //await serialPortArduino.BaseStream.WriteAsync(buffer, 0, buffer.Length); // Using writeAsync of baseStream, as SerialPort lib is broken...
                    serialPortArduino.BaseStream.WriteByte(spStart);
                    System.Threading.Thread.Sleep(500);

                    int retryInitializeCounter = 0; // Max is 10
                    int bigRetryCounter = 0; // Max is 3
                    while (true)
                    {
                        //threadStrDbg += returnMessage; //REMOVE
                        //threadStrDbg += DateTime.Now.ToString("mm:ss:ff") + '\n';  //REMOVE

                        if (retryInitializeCounter >= 10)
                        {
                            bigRetryCounter++;
                            if(bigRetryCounter >= 3)
                            {
                                MessageBox.Show("Неможливо ініціалізувати отримання даних з датчиків\nЯкщо перезапуск програми не допоможе, - варто перевірити скетч Arduino", "Критична помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                isArduinoFound = false; // UI should be turned off

                            }
                            retryInitializeCounter = 0;

                            serialPortArduino.BaseStream.WriteByte(spResetConnection);
                            System.Threading.Thread.Sleep(1000);
                            serialPortArduino.DiscardInBuffer();
                            serialPortArduino.BaseStream.WriteByte(spStart);
                            System.Threading.Thread.Sleep(500);
                        }

                        string returnMessage = serialPortArduino.ReadLine();
                        if (returnMessage.Contains(initializedStr)) break;
                        else retryInitializeCounter++;
                    }

                    // Successful handshake, collecting data
                    dataCollector = new Thread(new ThreadStart(CollectSensorsData));
                }
                catch (Exception ex) {
                    MessageBox.Show($"Відбулась помилка. Впевніться, що arduino підключено та натисніть 'Під'єднатись до arduino', якщо все впорядку\nІнформація про помилку:\n{ex.Message}",
                        "Помилка зчитування даних датчиків",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isArduinoFound = false;
                    if(serialPortArduino.IsOpen) { 
                        serialPortArduino.DiscardInBuffer();
                        serialPortArduino.Close();
                    }
                }
            });
        }

        private bool ArduinoDetected()
        {
            try
            {
                serialPortArduino.Open();
                System.Threading.Thread.Sleep(1000); // just wait a lot

                string returnMessage = serialPortArduino.ReadExisting();

                // in arduino sketch should be Serial.println("ARDUINO") inside  void loop()
                if (returnMessage.Contains(notInitializedStr))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception {ex}");
                return false;
            }
            finally
            {
                serialPortArduino.Close();
            }
        }

        private async void buttonScanPorts_Click(object sender, EventArgs e)
        {
            EnableAllUI(false);
            await ScanForArduino();
            if(isArduinoFound) EnableAllUI(true);
        }

        private void CollectSensorsData()
        {
            //while(serialPortArduino.IsOpen && )
            //Interlocked.Exchange(ref location, float value);
        }
    }
}




/*   For plan info box

                // REMOVE THIS FOR. FOR TESTING PURPOSES ONLY
            //for(int i=0;i<10;i++)
            //{
            //    string[] arr = { i.ToString(), "00:01", (i*4 + 300).ToString(), ((i/3)/2).ToString(), (((i*2)-i/3+i)/3).ToString(), (i+(i/2)-i/3-i/4).ToString() };
            //    listViewPlanRecords.Items.Add(new ListViewItem(arr));
            //}

if (listViewPlanRecords.SelectedItems.Count > 0)
{
    textBoxRecordInExecutuion.Text = listViewPlanRecords.SelectedItems[0].SubItems[0].Text;
    String timeNow = DateTime.Now.ToString("h:mm:ss tt");
    textBoxStartTime.Text = timeNow;
    TimeSpan timeDelta = new TimeSpan();
    bool isParsed = TimeSpan.TryParse(listViewPlanRecords.SelectedItems[0].SubItems[1].Text, out timeDelta);

    if (isParsed)
    {
        textBoxEndTime.Text = Convert.ToDateTime(timeNow).Add(timeDelta).ToString("h:mm:ss tt");


        var delta = (Convert.ToDateTime(textBoxEndTime.Text) - DateTime.Now);
        textBoxRemainingTime.Text = String.Format("{0} годин, {1} хвилин, {2} секунд", delta.Hours, delta.Minutes, delta.Seconds);
    }
    else
    {
        textBoxEndTime.Text = "Неправильно заданий час";
        textBoxRemainingTime.Text = "Неможливо визначити";
    }
}
else
    textBoxRecordInExecutuion.Text = "План не вибрано";
*/
