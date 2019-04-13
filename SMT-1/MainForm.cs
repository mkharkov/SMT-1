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
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeControllers()
        {
            engine = new EngineController();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeControllers();

            textBoxT0.Text = "Degrees";
            textBoxRecordInExecutuion.Text = "План не вибрано";
            textBoxEndTime.Text = textBoxRemainingTime.Text = textBoxStartTime.Text = "0";

            textBoxPlanEngineRPM.Text = trackBarPlanEngineSpeed.Value.ToString();
            textBoxPlanEngineVoltage.Text = EngineController.RpmToVoltage(trackBarPlanEngineSpeed.Value).ToString();

            textBoxLoadedWeight.Text = trackBarLoadedWeight.Value.ToString();
            textBoxFirstTemp.Text = trackBarFirstTemp.Value.ToString();
            textBoxSecondTemp.Text = trackBarSecondTemp.Value.ToString();

            // REMOVE THIS FOR. FOR TESTING PURPOSES ONLY
            for(int i=0;i<100;i++)
            {
                string[] arr = { i.ToString(), "00:01:00", (i*4 + 300).ToString(), ((i/3 + i*2)/2).ToString(), (((i*2)-i/3+i)/3).ToString(), (i+(i/2)-i/3-i/4).ToString() };
                listViewPlanRecords.Items.Add(new ListViewItem(arr));
            }
            //REMOVE

            textBoxControlEngineVoltage.Text = EngineController.RpmToVoltage(trackBarControlEngineRPM.Value).ToString();
            numericUpDownControlEngineRPM.Value = trackBarControlEngineRPM.Value;

            textBoxControlEngineCurrentRPM.Text = engine.RPM.ToString();
            textBoxControlEngineCurrentVoltage.Text = ((int)engine.Voltage).ToString();
        }

        private void buttonLoadPlan_Click(object sender, EventArgs e)
        {

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
            textBoxControlEngineVoltage.Text = (trackBarControlEngineRPM.Value * 2).ToString();
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
            richTextBoxDebug.Text = string.Format("Engine Info:\n" +
                "\tON: {0}\n" +
                "\tRPM: {1}\n" +
                "\tVoltage: {2}\n" +
                "**************\n" +
                "" +
                "" +
                "", engine.On, engine.RPM, engine.Voltage);
        }

        private void listViewPlanRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            //trackBarPlanEngineSpeed.Value = int.Parse(listViewPlanRecords.SelectedItems[0].SubItems[2].Text);
            //textBoxPlanEngineRPM;
            //textBoxPlanEngineVoltage;
            if (listViewPlanRecords.SelectedItems.Count > 0)
            {
                trackBarPlanEngineSpeed.Value = int.Parse(listViewPlanRecords.SelectedItems[0].SubItems[2].Text);

            }
            else
            {
                trackBarPlanEngineSpeed.Value = trackBarPlanEngineSpeed.Minimum;
                textBoxPlanEngineRPM.Text = trackBarPlanEngineSpeed.Value.ToString();
                textBoxPlanEngineVoltage.Text = EngineController.RpmToVoltage(trackBarPlanEngineSpeed.Value).ToString();
            }
        }

        private void listViewPlanRecords_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Clicked");
        }

        private void trackBarPlanEngineSpeed_ValueChanged(object sender, EventArgs e)
        {
            textBoxPlanEngineRPM.Text = trackBarPlanEngineSpeed.Value.ToString();
            textBoxPlanEngineVoltage.Text = EngineController.RpmToVoltage(trackBarPlanEngineSpeed.Value).ToString();
        }

        private void buttonControlEngineRestore_Click(object sender, EventArgs e)
        {
            trackBarControlEngineRPM.Value = engine.RPM;
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
