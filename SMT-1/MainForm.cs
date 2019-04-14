using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMT_1
{
    public partial class MainForm : Form
    {
        private EngineController engine;
        private FileController fileRW;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeControllers()
        {
            engine = new EngineController();
            fileRW = new FileController();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeControllers();

            openFileDialogPlan.FileName = "";

            textBoxT0.Text = "Degrees";
            textBoxRecordInExecutuion.Text = "План не вибрано";
            textBoxEndTime.Text = textBoxRemainingTime.Text = textBoxStartTime.Text = "0";

            numericUpDownControlEngineRPM.Value = engine.RPM;
            textBoxPlanEngineVoltage.Text = EngineController.RpmToVoltage((int)numericUpDownControlEngineRPM.Value).ToString();

            textBoxLoadedWeight.Text = trackBarLoadedWeight.Value.ToString();
            textBoxFirstTemp.Text = trackBarFirstTemp.Value.ToString();
            textBoxSecondTemp.Text = trackBarSecondTemp.Value.ToString();

            // REMOVE THIS FOR. FOR TESTING PURPOSES ONLY
            for(int i=0;i<100;i++)
            {
                string[] arr = { i.ToString(), "00:01", (i*4 + 300).ToString(), ((i/3)/2).ToString(), (((i*2)-i/3+i)/3).ToString(), (i+(i/2)-i/3-i/4).ToString() };
                listViewPlanRecords.Items.Add(new ListViewItem(arr));
            }
            //REMOVE

            textBoxControlEngineVoltage.Text = EngineController.RpmToVoltage(trackBarControlEngineRPM.Value).ToString();
            numericUpDownControlEngineRPM.Value = trackBarControlEngineRPM.Value;

            textBoxControlEngineCurrentRPM.Text = engine.RPM.ToString();
            textBoxControlEngineCurrentVoltage.Text = ((int)engine.Voltage).ToString();
        }

        private void trackBarFirstTemp_ValueChanged(object sender, EventArgs e)
        {
            textBoxFirstTemp.Text = trackBarFirstTemp.Value.ToString();
        }

        private void trackBarLoadedWeight_ValueChanged(object sender, EventArgs e)
        {
            textBoxLoadedWeight.Text = trackBarLoadedWeight.Value.ToString();
        }

        private void trackBarSecondTemp_ValueChanged(object sender, EventArgs e)
        {
            textBoxSecondTemp.Text = trackBarSecondTemp.Value.ToString();
        }

        private void trackBarControlEngineRPM_Scroll(object sender, EventArgs e)
        {
            textBoxControlEngineVoltage.Text = EngineController.RpmToVoltage(trackBarControlEngineRPM.Value).ToString();
            numericUpDownControlEngineRPM.Value = trackBarControlEngineRPM.Value;
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
        }

        //SHOWING DEBUG INFO ABOUT STATE OF MAIN FORM
        private void buttonShowDebugInfo_Click(object sender, EventArgs e)
        {
            string dbg = string.Format("Engine Info:\n" +
                "\tON: {0}\n" +
                "\tRPM: {1}\n" +
                "\tVoltage: {2}\n" +
                "**************\n" +
                "File info:\n" +
                "\tFileName: {3}\n" +
                "**************\n" +
                "", engine.On, engine.RPM, engine.Voltage, openFileDialogPlan.FileName);
            if (fileRW.GetRecords().Count != 0)
                dbg += "Records:\n";
            foreach(PlanRecord pl in fileRW.GetRecords())
            {
                string timeHours = String.Format("{0}", pl.GetTime().Hours).PadLeft(2, '0');
                string timeMinutes = String.Format("{0}", pl.GetTime().Minutes).PadLeft(2, '0');
                dbg += String.Format("\ttime={0};speed={1};load={2};t1={3};t2={4};\n", String.Format("{0}:{1}", timeHours, timeMinutes), pl.GetSpeed(), pl.GetLoad(), pl.GetT1(), pl.GetT2());
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

            if (last != null)
            {
                string timeHours = String.Format("{0}", numericUpDownPlanHours.Value).PadLeft(2, '0');
                string timeMinutes = String.Format("{0}", numericUpDownPlanMinutes.Value).PadLeft(2, '0');

                string[] arr = { (int.Parse(last.SubItems[0].Text) + 1).ToString(), // index
                                  String.Format("{0}:{1}", timeHours, timeMinutes), // time
                                  numericUpDownPlanEngineRPM.Value.ToString(),      // rpm
                                  trackBarLoadedWeight.Value.ToString(),            // loadedWeight
                                  trackBarFirstTemp.Value.ToString(),               // temp1
                                  trackBarSecondTemp.Value.ToString()};             // temp2

                listViewPlanRecords.Items.Add(new ListViewItem(arr));
            }
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
                if (idxA == listViewPlanRecords.Items.Count)
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
                if(!fileRW.SetFile(openFileDialogPlan.FileName))
                {
                    MessageBox.Show("Вміст файлу не відповідає заданому формату\nФормат:\n" + FileController.FileFormatString, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonLoadPlan_Click(object sender, EventArgs e)
        {

        }
    }
}




/*   For plan info box


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
