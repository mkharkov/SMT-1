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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textBoxT0.Text = "Degrees";
            textBoxRecordInExecutuion.Text = "План не вибрано";
            textBoxEndTime.Text = textBoxRemainingTime.Text = textBoxStartTime.Text = "0";

            textBoxPlanEngineRPM.Text = trackBarPlanEngineSpeed.Value.ToString();
            textBoxPlanEngineVoltage.Text = (trackBarPlanEngineSpeed.Value * 2).ToString(); //CHANGE WHEN VOLTAGE FORMULE KNOWN

            textBoxLoadedWeight.Text = trackBarLoadedWeight.Value.ToString();
            textBoxFirstTemp.Text = trackBarFirstTemp.Value.ToString();
            textBoxSecondTemp.Text = trackBarSecondTemp.Value.ToString();

            // REMOVE THIS FOR. FOR TESTING PURPOSES ONLY
            for(int i=0;i<100;i++)
            {
                string[] arr = { i.ToString(), "00:01:00" };
                listViewPlanRecords.Items.Add(new ListViewItem(arr));
            }
            //REMOVE

            textBoxControlEngineVoltage.Text = (trackBarControlEngineRPM.Value * 2).ToString();
            numericUpDownControlEngineRPM.Value = trackBarControlEngineRPM.Value;

        }

        private void buttonLoadPlan_Click(object sender, EventArgs e)
        {
            if (openFileDialogPlan.ShowDialog() == DialogResult.OK)
            {
                //textBoxPlanFilePath.Text = openFileDialogPlan.FileName;
            }
        }

        private void trackBarPlanEngineSpeed_Scroll(object sender, EventArgs e)
        {
            textBoxPlanEngineRPM.Text = trackBarPlanEngineSpeed.Value.ToString();
            textBoxPlanEngineVoltage.Text = (trackBarPlanEngineSpeed.Value * 2).ToString(); //CHANGE WHEN VOLTAGE FORMULE KNOWN
        }

        private void trackBarFirstTemp_Scroll(object sender, EventArgs e)
        {
            textBoxFirstTemp.Text = trackBarFirstTemp.Value.ToString();
        }

        private void trackBarLoadedWeight_Scroll(object sender, EventArgs e)
        {
            textBoxLoadedWeight.Text = trackBarLoadedWeight.Value.ToString();
        }

        private void trackBarSecondTemp_Scroll(object sender, EventArgs e)
        {
            textBoxSecondTemp.Text = trackBarSecondTemp.Value.ToString();
        }

        private void listViewPlanRecords_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
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
        }

        private void trackBarControlEngineRPM_Scroll(object sender, EventArgs e)
        {
            textBoxControlEngineVoltage.Text = (trackBarControlEngineRPM.Value*2).ToString();
            numericUpDownControlEngineRPM.Value = trackBarControlEngineRPM.Value;
        }

        private void numericUpDownControlEngineRPM_ValueChanged(object sender, EventArgs e)
        {
            trackBarControlEngineRPM.Value = (int)numericUpDownControlEngineRPM.Value;
            textBoxControlEngineVoltage.Text = ((int)numericUpDownControlEngineRPM.Value*2).ToString();
        }
    }
}
