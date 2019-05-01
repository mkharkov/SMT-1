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

namespace SMT_1
{
    public partial class MainForm : Form
    {
        private EngineController engine;
        private LoadController load;
        private FileController fileRW;
        private FanController leftFan;
        private FanController rightFan;

        private int executeTimeCounter=0;
        bool isPlanInExecution = false;

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

        private void MainForm_Load(object sender, EventArgs e)
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
            foreach(PlanRecord pl in fileRW.GetRecords())
            {
                //string timeHours = String.Format("{0}", pl.GetTime().Hours).PadLeft(2, '0');
                //string timeMinutes = String.Format("{0}", pl.GetTime().Minutes).PadLeft(2, '0');
                //dbg += String.Format("\ttime={0};speed={1};load={2};t1={3};t2={4};\n", String.Format("{0}:{1}", timeHours, timeMinutes), pl.GetSpeed(), pl.GetLoad(), pl.GetT1(), pl.GetT2());
                dbg += pl.ToString();
            }
            if (fileRW.GetRecords().Count != 0)
                dbg += "**************\n";
            richTextBoxDebug.Text = dbg;
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
                foreach(ListViewItem elem in listViewPlanRecords.Items)
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
                if (idxA == listViewPlanRecords.Items.Count-1)
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
                if(fileRW.LoadFromFile(openFileDialogPlan.FileName))
                {
                    listViewPlanRecords.Items.Clear();
                    int idx = 0;
                    foreach(PlanRecord pl in fileRW.GetRecords())
                    {
                        listViewPlanRecords.Items.Add(new ListViewItem( new string[] { idx.ToString(),
                                                                                        pl.GetTimeStr(),
                                                                                        pl.GetSpeed().ToString(),
                                                                                        pl.GetLoad().ToString(),
                                                                                        pl.GetT1().ToString(),
                                                                                        pl.GetT2().ToString() } ));
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
                foreach(ListViewItem item in listViewPlanRecords.Items)
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
                foreach(var toDelete in recordsToExecute.Where(kv => kv.Key < executeFromIdx).ToList())
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

            isPlanInExecution = true;
            Dispatcher uiDispatcher = Dispatcher.CurrentDispatcher;
            executeTimeCounter = 0;
            await Task.Run(() => //task is synchronous for itself
            {
                DateTime recordEndTime = DateTime.Now;
                DateTime recordStartTime;
                foreach(KeyValuePair<int, PlanRecord> recordKV in recordsToExecute)
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
                        // TODO: fill all fields
                        // Some timer should be triggered when 
                        /* Previous, current = Now
                         * previous = current
                         * current = Now+timeToExecute
                         * previous = startOfTask
                         * current = endOfTask
                         * remaining = end - now
                         * Timer should be started when task starts to execute
                         * so, start timer in dispatcher action
                         * end timer at the end of the loop iteration
                         * tick event should decrease counter
                         * initially counter should be set to amount of seconds needed to execute time
                         * when displaying counter seconds should be formated into hh:mm    
                         */
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

            SetAllControlToInitial();
            MessageBox.Show("Виконання плану завершено", "", MessageBoxButtons.OK, MessageBoxIcon.None);
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
