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
    }
}
