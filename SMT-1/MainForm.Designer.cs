namespace SMT_1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Plan = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelPlanValues = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.groupBoxEngineSpeed = new System.Windows.Forms.GroupBox();
            this.groupBoxLoad = new System.Windows.Forms.GroupBox();
            this.groupBoxTempFirst = new System.Windows.Forms.GroupBox();
            this.groupBoxTempSecond = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelPlanControl = new System.Windows.Forms.TableLayoutPanel();
            this.buttonStartSelected = new System.Windows.Forms.Button();
            this.buttonLoadPlan = new System.Windows.Forms.Button();
            this.buttonStopPlan = new System.Windows.Forms.Button();
            this.buttonLoadFileFromPath = new System.Windows.Forms.Button();
            this.listViewPlanRecords = new System.Windows.Forms.ListView();
            this.columnHeaderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLoad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Control = new System.Windows.Forms.TabPage();
            this.Charts = new System.Windows.Forms.TabPage();
            this.tabControlControlPanel = new System.Windows.Forms.TabControl();
            this.groupBoxCurrentParameters = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelParameters = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxT0 = new System.Windows.Forms.TextBox();
            this.labelT0 = new System.Windows.Forms.Label();
            this.groupBoxPlan = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelPlan = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxRecordInExecutuion = new System.Windows.Forms.TextBox();
            this.textBoxStartTime = new System.Windows.Forms.TextBox();
            this.textBoxEndTime = new System.Windows.Forms.TextBox();
            this.textBoxRemainingTime = new System.Windows.Forms.TextBox();
            this.labelRecordInExecution = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.labelRemainingTime = new System.Windows.Forms.Label();
            this.openFileDialogPlan = new System.Windows.Forms.OpenFileDialog();
            this.numericUpDownPlanHours = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPlanMinutes = new System.Windows.Forms.NumericUpDown();
            this.labelPlanHours = new System.Windows.Forms.Label();
            this.labelPlanMinutes = new System.Windows.Forms.Label();
            this.trackBarPlanEngineSpeed = new System.Windows.Forms.TrackBar();
            this.textBoxPlanEngineRPM = new System.Windows.Forms.TextBox();
            this.labelEngineSpeedText = new System.Windows.Forms.Label();
            this.textBoxPlanEngineVoltage = new System.Windows.Forms.TextBox();
            this.labelPlanEngineRPM = new System.Windows.Forms.Label();
            this.labelPlanEngineVoltage = new System.Windows.Forms.Label();
            this.columnHeaderT1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderT2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Plan.SuspendLayout();
            this.tableLayoutPanelPlanValues.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            this.groupBoxEngineSpeed.SuspendLayout();
            this.tableLayoutPanelPlanControl.SuspendLayout();
            this.tabControlControlPanel.SuspendLayout();
            this.groupBoxCurrentParameters.SuspendLayout();
            this.tableLayoutPanelParameters.SuspendLayout();
            this.groupBoxPlan.SuspendLayout();
            this.tableLayoutPanelPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlanHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlanMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlanEngineSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // Plan
            // 
            this.Plan.Controls.Add(this.tableLayoutPanelPlanValues);
            this.Plan.Controls.Add(this.tableLayoutPanelPlanControl);
            this.Plan.Controls.Add(this.listViewPlanRecords);
            resources.ApplyResources(this.Plan, "Plan");
            this.Plan.Name = "Plan";
            this.Plan.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelPlanValues
            // 
            resources.ApplyResources(this.tableLayoutPanelPlanValues, "tableLayoutPanelPlanValues");
            this.tableLayoutPanelPlanValues.Controls.Add(this.groupBoxGeneral, 0, 0);
            this.tableLayoutPanelPlanValues.Controls.Add(this.groupBoxTime, 1, 0);
            this.tableLayoutPanelPlanValues.Controls.Add(this.groupBoxEngineSpeed, 0, 1);
            this.tableLayoutPanelPlanValues.Controls.Add(this.groupBoxLoad, 1, 1);
            this.tableLayoutPanelPlanValues.Controls.Add(this.groupBoxTempFirst, 0, 2);
            this.tableLayoutPanelPlanValues.Controls.Add(this.groupBoxTempSecond, 1, 2);
            this.tableLayoutPanelPlanValues.Name = "tableLayoutPanelPlanValues";
            // 
            // groupBoxGeneral
            // 
            resources.ApplyResources(this.groupBoxGeneral, "groupBoxGeneral");
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.TabStop = false;
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Controls.Add(this.labelPlanMinutes);
            this.groupBoxTime.Controls.Add(this.labelPlanHours);
            this.groupBoxTime.Controls.Add(this.numericUpDownPlanMinutes);
            this.groupBoxTime.Controls.Add(this.numericUpDownPlanHours);
            resources.ApplyResources(this.groupBoxTime, "groupBoxTime");
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.TabStop = false;
            // 
            // groupBoxEngineSpeed
            // 
            this.groupBoxEngineSpeed.Controls.Add(this.labelPlanEngineVoltage);
            this.groupBoxEngineSpeed.Controls.Add(this.labelPlanEngineRPM);
            this.groupBoxEngineSpeed.Controls.Add(this.textBoxPlanEngineVoltage);
            this.groupBoxEngineSpeed.Controls.Add(this.labelEngineSpeedText);
            this.groupBoxEngineSpeed.Controls.Add(this.textBoxPlanEngineRPM);
            this.groupBoxEngineSpeed.Controls.Add(this.trackBarPlanEngineSpeed);
            resources.ApplyResources(this.groupBoxEngineSpeed, "groupBoxEngineSpeed");
            this.groupBoxEngineSpeed.Name = "groupBoxEngineSpeed";
            this.groupBoxEngineSpeed.TabStop = false;
            // 
            // groupBoxLoad
            // 
            resources.ApplyResources(this.groupBoxLoad, "groupBoxLoad");
            this.groupBoxLoad.Name = "groupBoxLoad";
            this.groupBoxLoad.TabStop = false;
            // 
            // groupBoxTempFirst
            // 
            resources.ApplyResources(this.groupBoxTempFirst, "groupBoxTempFirst");
            this.groupBoxTempFirst.Name = "groupBoxTempFirst";
            this.groupBoxTempFirst.TabStop = false;
            // 
            // groupBoxTempSecond
            // 
            resources.ApplyResources(this.groupBoxTempSecond, "groupBoxTempSecond");
            this.groupBoxTempSecond.Name = "groupBoxTempSecond";
            this.groupBoxTempSecond.TabStop = false;
            // 
            // tableLayoutPanelPlanControl
            // 
            resources.ApplyResources(this.tableLayoutPanelPlanControl, "tableLayoutPanelPlanControl");
            this.tableLayoutPanelPlanControl.Controls.Add(this.buttonStartSelected, 0, 0);
            this.tableLayoutPanelPlanControl.Controls.Add(this.buttonLoadPlan, 0, 1);
            this.tableLayoutPanelPlanControl.Controls.Add(this.buttonStopPlan, 1, 0);
            this.tableLayoutPanelPlanControl.Controls.Add(this.buttonLoadFileFromPath, 1, 1);
            this.tableLayoutPanelPlanControl.Name = "tableLayoutPanelPlanControl";
            // 
            // buttonStartSelected
            // 
            resources.ApplyResources(this.buttonStartSelected, "buttonStartSelected");
            this.buttonStartSelected.Name = "buttonStartSelected";
            this.buttonStartSelected.UseVisualStyleBackColor = true;
            // 
            // buttonLoadPlan
            // 
            resources.ApplyResources(this.buttonLoadPlan, "buttonLoadPlan");
            this.buttonLoadPlan.Name = "buttonLoadPlan";
            this.buttonLoadPlan.UseVisualStyleBackColor = true;
            // 
            // buttonStopPlan
            // 
            resources.ApplyResources(this.buttonStopPlan, "buttonStopPlan");
            this.buttonStopPlan.Name = "buttonStopPlan";
            this.buttonStopPlan.UseVisualStyleBackColor = true;
            // 
            // buttonLoadFileFromPath
            // 
            resources.ApplyResources(this.buttonLoadFileFromPath, "buttonLoadFileFromPath");
            this.buttonLoadFileFromPath.Name = "buttonLoadFileFromPath";
            this.buttonLoadFileFromPath.UseVisualStyleBackColor = true;
            // 
            // listViewPlanRecords
            // 
            this.listViewPlanRecords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNumber,
            this.columnHeaderTime,
            this.columnHeaderSpeed,
            this.columnHeaderLoad,
            this.columnHeaderT1,
            this.columnHeaderT2});
            resources.ApplyResources(this.listViewPlanRecords, "listViewPlanRecords");
            this.listViewPlanRecords.FullRowSelect = true;
            this.listViewPlanRecords.GridLines = true;
            this.listViewPlanRecords.Name = "listViewPlanRecords";
            this.listViewPlanRecords.UseCompatibleStateImageBehavior = false;
            this.listViewPlanRecords.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNumber
            // 
            resources.ApplyResources(this.columnHeaderNumber, "columnHeaderNumber");
            // 
            // columnHeaderTime
            // 
            resources.ApplyResources(this.columnHeaderTime, "columnHeaderTime");
            // 
            // columnHeaderSpeed
            // 
            resources.ApplyResources(this.columnHeaderSpeed, "columnHeaderSpeed");
            // 
            // columnHeaderLoad
            // 
            resources.ApplyResources(this.columnHeaderLoad, "columnHeaderLoad");
            // 
            // Control
            // 
            resources.ApplyResources(this.Control, "Control");
            this.Control.Name = "Control";
            this.Control.UseVisualStyleBackColor = true;
            // 
            // Charts
            // 
            resources.ApplyResources(this.Charts, "Charts");
            this.Charts.Name = "Charts";
            this.Charts.UseVisualStyleBackColor = true;
            // 
            // tabControlControlPanel
            // 
            this.tabControlControlPanel.Controls.Add(this.Charts);
            this.tabControlControlPanel.Controls.Add(this.Control);
            this.tabControlControlPanel.Controls.Add(this.Plan);
            resources.ApplyResources(this.tabControlControlPanel, "tabControlControlPanel");
            this.tabControlControlPanel.Name = "tabControlControlPanel";
            this.tabControlControlPanel.SelectedIndex = 0;
            // 
            // groupBoxCurrentParameters
            // 
            this.groupBoxCurrentParameters.Controls.Add(this.tableLayoutPanelParameters);
            resources.ApplyResources(this.groupBoxCurrentParameters, "groupBoxCurrentParameters");
            this.groupBoxCurrentParameters.Name = "groupBoxCurrentParameters";
            this.groupBoxCurrentParameters.TabStop = false;
            // 
            // tableLayoutPanelParameters
            // 
            resources.ApplyResources(this.tableLayoutPanelParameters, "tableLayoutPanelParameters");
            this.tableLayoutPanelParameters.Controls.Add(this.textBoxT0, 1, 0);
            this.tableLayoutPanelParameters.Controls.Add(this.labelT0, 0, 0);
            this.tableLayoutPanelParameters.Name = "tableLayoutPanelParameters";
            // 
            // textBoxT0
            // 
            resources.ApplyResources(this.textBoxT0, "textBoxT0");
            this.textBoxT0.Name = "textBoxT0";
            // 
            // labelT0
            // 
            resources.ApplyResources(this.labelT0, "labelT0");
            this.labelT0.Name = "labelT0";
            // 
            // groupBoxPlan
            // 
            this.groupBoxPlan.Controls.Add(this.tableLayoutPanelPlan);
            resources.ApplyResources(this.groupBoxPlan, "groupBoxPlan");
            this.groupBoxPlan.Name = "groupBoxPlan";
            this.groupBoxPlan.TabStop = false;
            // 
            // tableLayoutPanelPlan
            // 
            resources.ApplyResources(this.tableLayoutPanelPlan, "tableLayoutPanelPlan");
            this.tableLayoutPanelPlan.Controls.Add(this.textBoxRecordInExecutuion, 1, 0);
            this.tableLayoutPanelPlan.Controls.Add(this.textBoxStartTime, 1, 1);
            this.tableLayoutPanelPlan.Controls.Add(this.textBoxEndTime, 1, 2);
            this.tableLayoutPanelPlan.Controls.Add(this.textBoxRemainingTime, 1, 3);
            this.tableLayoutPanelPlan.Controls.Add(this.labelRecordInExecution, 0, 0);
            this.tableLayoutPanelPlan.Controls.Add(this.labelStartTime, 0, 1);
            this.tableLayoutPanelPlan.Controls.Add(this.labelEndTime, 0, 2);
            this.tableLayoutPanelPlan.Controls.Add(this.labelRemainingTime, 0, 3);
            this.tableLayoutPanelPlan.Name = "tableLayoutPanelPlan";
            // 
            // textBoxRecordInExecutuion
            // 
            resources.ApplyResources(this.textBoxRecordInExecutuion, "textBoxRecordInExecutuion");
            this.textBoxRecordInExecutuion.Name = "textBoxRecordInExecutuion";
            // 
            // textBoxStartTime
            // 
            resources.ApplyResources(this.textBoxStartTime, "textBoxStartTime");
            this.textBoxStartTime.Name = "textBoxStartTime";
            // 
            // textBoxEndTime
            // 
            resources.ApplyResources(this.textBoxEndTime, "textBoxEndTime");
            this.textBoxEndTime.Name = "textBoxEndTime";
            // 
            // textBoxRemainingTime
            // 
            resources.ApplyResources(this.textBoxRemainingTime, "textBoxRemainingTime");
            this.textBoxRemainingTime.Name = "textBoxRemainingTime";
            // 
            // labelRecordInExecution
            // 
            resources.ApplyResources(this.labelRecordInExecution, "labelRecordInExecution");
            this.labelRecordInExecution.Name = "labelRecordInExecution";
            // 
            // labelStartTime
            // 
            resources.ApplyResources(this.labelStartTime, "labelStartTime");
            this.labelStartTime.Name = "labelStartTime";
            // 
            // labelEndTime
            // 
            resources.ApplyResources(this.labelEndTime, "labelEndTime");
            this.labelEndTime.Name = "labelEndTime";
            // 
            // labelRemainingTime
            // 
            resources.ApplyResources(this.labelRemainingTime, "labelRemainingTime");
            this.labelRemainingTime.Name = "labelRemainingTime";
            // 
            // openFileDialogPlan
            // 
            this.openFileDialogPlan.FileName = "openFileDialogPlan";
            // 
            // numericUpDownPlanHours
            // 
            resources.ApplyResources(this.numericUpDownPlanHours, "numericUpDownPlanHours");
            this.numericUpDownPlanHours.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownPlanHours.Name = "numericUpDownPlanHours";
            // 
            // numericUpDownPlanMinutes
            // 
            resources.ApplyResources(this.numericUpDownPlanMinutes, "numericUpDownPlanMinutes");
            this.numericUpDownPlanMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownPlanMinutes.Name = "numericUpDownPlanMinutes";
            // 
            // labelPlanHours
            // 
            resources.ApplyResources(this.labelPlanHours, "labelPlanHours");
            this.labelPlanHours.Name = "labelPlanHours";
            // 
            // labelPlanMinutes
            // 
            resources.ApplyResources(this.labelPlanMinutes, "labelPlanMinutes");
            this.labelPlanMinutes.Name = "labelPlanMinutes";
            // 
            // trackBarPlanEngineSpeed
            // 
            this.trackBarPlanEngineSpeed.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.trackBarPlanEngineSpeed, "trackBarPlanEngineSpeed");
            this.trackBarPlanEngineSpeed.Maximum = 1000;
            this.trackBarPlanEngineSpeed.Minimum = 300;
            this.trackBarPlanEngineSpeed.Name = "trackBarPlanEngineSpeed";
            this.trackBarPlanEngineSpeed.TickFrequency = 50;
            this.trackBarPlanEngineSpeed.Value = 300;
            this.trackBarPlanEngineSpeed.Scroll += new System.EventHandler(this.trackBarPlanEngineSpeed_Scroll);
            // 
            // textBoxPlanEngineRPM
            // 
            resources.ApplyResources(this.textBoxPlanEngineRPM, "textBoxPlanEngineRPM");
            this.textBoxPlanEngineRPM.Name = "textBoxPlanEngineRPM";
            // 
            // labelEngineSpeedText
            // 
            resources.ApplyResources(this.labelEngineSpeedText, "labelEngineSpeedText");
            this.labelEngineSpeedText.Name = "labelEngineSpeedText";
            // 
            // textBoxPlanEngineVoltage
            // 
            resources.ApplyResources(this.textBoxPlanEngineVoltage, "textBoxPlanEngineVoltage");
            this.textBoxPlanEngineVoltage.Name = "textBoxPlanEngineVoltage";
            // 
            // labelPlanEngineRPM
            // 
            resources.ApplyResources(this.labelPlanEngineRPM, "labelPlanEngineRPM");
            this.labelPlanEngineRPM.Name = "labelPlanEngineRPM";
            // 
            // labelPlanEngineVoltage
            // 
            resources.ApplyResources(this.labelPlanEngineVoltage, "labelPlanEngineVoltage");
            this.labelPlanEngineVoltage.Name = "labelPlanEngineVoltage";
            // 
            // columnHeaderT1
            // 
            resources.ApplyResources(this.columnHeaderT1, "columnHeaderT1");
            // 
            // columnHeaderT2
            // 
            resources.ApplyResources(this.columnHeaderT2, "columnHeaderT2");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.groupBoxPlan);
            this.Controls.Add(this.groupBoxCurrentParameters);
            this.Controls.Add(this.tabControlControlPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Plan.ResumeLayout(false);
            this.tableLayoutPanelPlanValues.ResumeLayout(false);
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            this.groupBoxEngineSpeed.ResumeLayout(false);
            this.groupBoxEngineSpeed.PerformLayout();
            this.tableLayoutPanelPlanControl.ResumeLayout(false);
            this.tabControlControlPanel.ResumeLayout(false);
            this.groupBoxCurrentParameters.ResumeLayout(false);
            this.tableLayoutPanelParameters.ResumeLayout(false);
            this.tableLayoutPanelParameters.PerformLayout();
            this.groupBoxPlan.ResumeLayout(false);
            this.tableLayoutPanelPlan.ResumeLayout(false);
            this.tableLayoutPanelPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlanHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlanMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlanEngineSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Plan;
        private System.Windows.Forms.TabPage Control;
        private System.Windows.Forms.TabPage Charts;
        private System.Windows.Forms.TabControl tabControlControlPanel;
        private System.Windows.Forms.GroupBox groupBoxCurrentParameters;
        private System.Windows.Forms.TextBox textBoxT0;
        private System.Windows.Forms.Label labelT0;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelParameters;
        private System.Windows.Forms.GroupBox groupBoxPlan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPlan;
        private System.Windows.Forms.TextBox textBoxRecordInExecutuion;
        private System.Windows.Forms.TextBox textBoxStartTime;
        private System.Windows.Forms.TextBox textBoxEndTime;
        private System.Windows.Forms.TextBox textBoxRemainingTime;
        private System.Windows.Forms.Label labelRecordInExecution;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.Label labelRemainingTime;
        private System.Windows.Forms.ListView listViewPlanRecords;
        private System.Windows.Forms.ColumnHeader columnHeaderNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
        private System.Windows.Forms.ColumnHeader columnHeaderSpeed;
        private System.Windows.Forms.ColumnHeader columnHeaderLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialogPlan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPlanControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPlanValues;
        private System.Windows.Forms.Button buttonStartSelected;
        private System.Windows.Forms.Button buttonLoadPlan;
        private System.Windows.Forms.Button buttonStopPlan;
        private System.Windows.Forms.Button buttonLoadFileFromPath;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.GroupBox groupBoxEngineSpeed;
        private System.Windows.Forms.GroupBox groupBoxLoad;
        private System.Windows.Forms.GroupBox groupBoxTempFirst;
        private System.Windows.Forms.GroupBox groupBoxTempSecond;
        private System.Windows.Forms.NumericUpDown numericUpDownPlanHours;
        private System.Windows.Forms.Label labelPlanMinutes;
        private System.Windows.Forms.Label labelPlanHours;
        private System.Windows.Forms.NumericUpDown numericUpDownPlanMinutes;
        private System.Windows.Forms.Label labelEngineSpeedText;
        private System.Windows.Forms.TextBox textBoxPlanEngineRPM;
        private System.Windows.Forms.TrackBar trackBarPlanEngineSpeed;
        private System.Windows.Forms.TextBox textBoxPlanEngineVoltage;
        private System.Windows.Forms.Label labelPlanEngineVoltage;
        private System.Windows.Forms.Label labelPlanEngineRPM;
        private System.Windows.Forms.ColumnHeader columnHeaderT1;
        private System.Windows.Forms.ColumnHeader columnHeaderT2;
    }
}

