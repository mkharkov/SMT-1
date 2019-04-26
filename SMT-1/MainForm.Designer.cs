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
            this.tableLayoutPanelRecordActions = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRecordAdd = new System.Windows.Forms.Button();
            this.buttonRecordDelete = new System.Windows.Forms.Button();
            this.buttonRecordUp = new System.Windows.Forms.Button();
            this.buttonRecordDown = new System.Windows.Forms.Button();
            this.tableLayoutPanelPlanValues = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxSelected = new System.Windows.Forms.GroupBox();
            this.buttonRejectPlanRecordChanges = new System.Windows.Forms.Button();
            this.textBoxPlanSelectedRecordNumber = new System.Windows.Forms.TextBox();
            this.labelPlanSelectedRecordNumber = new System.Windows.Forms.Label();
            this.buttonApplyPlanRecordChanges = new System.Windows.Forms.Button();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.labelPlanMinutes = new System.Windows.Forms.Label();
            this.labelPlanHours = new System.Windows.Forms.Label();
            this.numericUpDownPlanMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPlanHours = new System.Windows.Forms.NumericUpDown();
            this.groupBoxEngineSpeed = new System.Windows.Forms.GroupBox();
            this.trackBarPlanEngineRPM = new System.Windows.Forms.TrackBar();
            this.numericUpDownPlanEngineRPM = new System.Windows.Forms.NumericUpDown();
            this.labelPlanEngineVoltage = new System.Windows.Forms.Label();
            this.labelPlanEngineRPM = new System.Windows.Forms.Label();
            this.textBoxPlanEngineVoltage = new System.Windows.Forms.TextBox();
            this.groupBoxLoad = new System.Windows.Forms.GroupBox();
            this.labelLoadedWeight = new System.Windows.Forms.Label();
            this.trackBarLoadedWeight = new System.Windows.Forms.TrackBar();
            this.groupBoxTempFirst = new System.Windows.Forms.GroupBox();
            this.labelFirstTemp = new System.Windows.Forms.Label();
            this.textBoxFirstTemp = new System.Windows.Forms.TextBox();
            this.trackBarFirstTemp = new System.Windows.Forms.TrackBar();
            this.groupBoxTempSecond = new System.Windows.Forms.GroupBox();
            this.labelSecondTemp = new System.Windows.Forms.Label();
            this.textBoxSecondTemp = new System.Windows.Forms.TextBox();
            this.trackBarSecondTemp = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanelPlanControl = new System.Windows.Forms.TableLayoutPanel();
            this.buttonStartSelected = new System.Windows.Forms.Button();
            this.buttonSavePlan = new System.Windows.Forms.Button();
            this.buttonStopPlan = new System.Windows.Forms.Button();
            this.buttonLoadFileFromPath = new System.Windows.Forms.Button();
            this.listViewPlanRecords = new System.Windows.Forms.ListView();
            this.columnHeaderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLoad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderT1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderT2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Control = new System.Windows.Forms.TabPage();
            this.groupBoxControlLoadedWeight = new System.Windows.Forms.GroupBox();
            this.buttonControlLoadSetValues = new System.Windows.Forms.Button();
            this.buttonControlLoadRestore = new System.Windows.Forms.Button();
            this.numericUpDownControlLoad = new System.Windows.Forms.NumericUpDown();
            this.labelControlLoad = new System.Windows.Forms.Label();
            this.trackBarControlLoad = new System.Windows.Forms.TrackBar();
            this.groupBoxControlVents = new System.Windows.Forms.GroupBox();
            this.groupBoxControlEngine = new System.Windows.Forms.GroupBox();
            this.groupBoxControlEngineCurrentParams = new System.Windows.Forms.GroupBox();
            this.textBoxControlEngineCurrentRPM = new System.Windows.Forms.TextBox();
            this.labelControlEngineCurrentVoltage = new System.Windows.Forms.Label();
            this.labelControlEngineCurrentRPM = new System.Windows.Forms.Label();
            this.textBoxControlEngineCurrentVoltage = new System.Windows.Forms.TextBox();
            this.buttonControlEngineRestore = new System.Windows.Forms.Button();
            this.buttonControlEngineStart = new System.Windows.Forms.Button();
            this.buttonControlEngineStop = new System.Windows.Forms.Button();
            this.buttonControlEngineSetValues = new System.Windows.Forms.Button();
            this.trackBarControlEngineRPM = new System.Windows.Forms.TrackBar();
            this.labelControlEngineRPM = new System.Windows.Forms.Label();
            this.numericUpDownControlEngineRPM = new System.Windows.Forms.NumericUpDown();
            this.labelControlEngineSpeed = new System.Windows.Forms.Label();
            this.textBoxControlEngineVoltage = new System.Windows.Forms.TextBox();
            this.labelControlEngineVoltage = new System.Windows.Forms.Label();
            this.Charts = new System.Windows.Forms.TabPage();
            this.tabControlControlPanel = new System.Windows.Forms.TabControl();
            this.DebugTab = new System.Windows.Forms.TabPage();
            this.buttonShowDebugInfo = new System.Windows.Forms.Button();
            this.richTextBoxDebug = new System.Windows.Forms.RichTextBox();
            this.groupBoxCurrentParameters = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelParameters = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxT0 = new System.Windows.Forms.TextBox();
            this.labelT0 = new System.Windows.Forms.Label();
            this.groupBoxPlan = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelPlan = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxRecordInExecutuion = new System.Windows.Forms.TextBox();
            this.textBoxEndTime = new System.Windows.Forms.TextBox();
            this.textBoxRemainingTime = new System.Windows.Forms.TextBox();
            this.labelRecordInExecution = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.labelRemainingTime = new System.Windows.Forms.Label();
            this.textBoxStartTime = new System.Windows.Forms.TextBox();
            this.openFileDialogPlan = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogPlan = new System.Windows.Forms.SaveFileDialog();
            this.numericUpDownPlanLoadedWeight = new System.Windows.Forms.NumericUpDown();
            this.Plan.SuspendLayout();
            this.tableLayoutPanelRecordActions.SuspendLayout();
            this.tableLayoutPanelPlanValues.SuspendLayout();
            this.groupBoxSelected.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlanMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlanHours)).BeginInit();
            this.groupBoxEngineSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlanEngineRPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlanEngineRPM)).BeginInit();
            this.groupBoxLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLoadedWeight)).BeginInit();
            this.groupBoxTempFirst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFirstTemp)).BeginInit();
            this.groupBoxTempSecond.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSecondTemp)).BeginInit();
            this.tableLayoutPanelPlanControl.SuspendLayout();
            this.Control.SuspendLayout();
            this.groupBoxControlLoadedWeight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownControlLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControlLoad)).BeginInit();
            this.groupBoxControlEngine.SuspendLayout();
            this.groupBoxControlEngineCurrentParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControlEngineRPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownControlEngineRPM)).BeginInit();
            this.tabControlControlPanel.SuspendLayout();
            this.DebugTab.SuspendLayout();
            this.groupBoxCurrentParameters.SuspendLayout();
            this.tableLayoutPanelParameters.SuspendLayout();
            this.groupBoxPlan.SuspendLayout();
            this.tableLayoutPanelPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlanLoadedWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // Plan
            // 
            this.Plan.Controls.Add(this.tableLayoutPanelRecordActions);
            this.Plan.Controls.Add(this.tableLayoutPanelPlanValues);
            this.Plan.Controls.Add(this.tableLayoutPanelPlanControl);
            this.Plan.Controls.Add(this.listViewPlanRecords);
            resources.ApplyResources(this.Plan, "Plan");
            this.Plan.Name = "Plan";
            this.Plan.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelRecordActions
            // 
            resources.ApplyResources(this.tableLayoutPanelRecordActions, "tableLayoutPanelRecordActions");
            this.tableLayoutPanelRecordActions.Controls.Add(this.buttonRecordAdd, 0, 0);
            this.tableLayoutPanelRecordActions.Controls.Add(this.buttonRecordDelete, 0, 1);
            this.tableLayoutPanelRecordActions.Controls.Add(this.buttonRecordUp, 0, 2);
            this.tableLayoutPanelRecordActions.Controls.Add(this.buttonRecordDown, 0, 3);
            this.tableLayoutPanelRecordActions.Name = "tableLayoutPanelRecordActions";
            // 
            // buttonRecordAdd
            // 
            resources.ApplyResources(this.buttonRecordAdd, "buttonRecordAdd");
            this.buttonRecordAdd.Name = "buttonRecordAdd";
            this.buttonRecordAdd.UseVisualStyleBackColor = true;
            this.buttonRecordAdd.Click += new System.EventHandler(this.buttonRecordAdd_Click);
            // 
            // buttonRecordDelete
            // 
            resources.ApplyResources(this.buttonRecordDelete, "buttonRecordDelete");
            this.buttonRecordDelete.Name = "buttonRecordDelete";
            this.buttonRecordDelete.UseVisualStyleBackColor = true;
            this.buttonRecordDelete.Click += new System.EventHandler(this.buttonRecordDelete_Click);
            // 
            // buttonRecordUp
            // 
            resources.ApplyResources(this.buttonRecordUp, "buttonRecordUp");
            this.buttonRecordUp.Name = "buttonRecordUp";
            this.buttonRecordUp.UseVisualStyleBackColor = true;
            this.buttonRecordUp.Click += new System.EventHandler(this.buttonRecordUp_Click);
            // 
            // buttonRecordDown
            // 
            resources.ApplyResources(this.buttonRecordDown, "buttonRecordDown");
            this.buttonRecordDown.Name = "buttonRecordDown";
            this.buttonRecordDown.UseVisualStyleBackColor = true;
            this.buttonRecordDown.Click += new System.EventHandler(this.buttonRecordDown_Click);
            // 
            // tableLayoutPanelPlanValues
            // 
            resources.ApplyResources(this.tableLayoutPanelPlanValues, "tableLayoutPanelPlanValues");
            this.tableLayoutPanelPlanValues.Controls.Add(this.groupBoxSelected, 0, 0);
            this.tableLayoutPanelPlanValues.Controls.Add(this.groupBoxTime, 1, 0);
            this.tableLayoutPanelPlanValues.Controls.Add(this.groupBoxEngineSpeed, 0, 1);
            this.tableLayoutPanelPlanValues.Controls.Add(this.groupBoxLoad, 1, 1);
            this.tableLayoutPanelPlanValues.Controls.Add(this.groupBoxTempFirst, 0, 2);
            this.tableLayoutPanelPlanValues.Controls.Add(this.groupBoxTempSecond, 1, 2);
            this.tableLayoutPanelPlanValues.Name = "tableLayoutPanelPlanValues";
            // 
            // groupBoxSelected
            // 
            this.groupBoxSelected.Controls.Add(this.buttonRejectPlanRecordChanges);
            this.groupBoxSelected.Controls.Add(this.textBoxPlanSelectedRecordNumber);
            this.groupBoxSelected.Controls.Add(this.labelPlanSelectedRecordNumber);
            this.groupBoxSelected.Controls.Add(this.buttonApplyPlanRecordChanges);
            resources.ApplyResources(this.groupBoxSelected, "groupBoxSelected");
            this.groupBoxSelected.Name = "groupBoxSelected";
            this.groupBoxSelected.TabStop = false;
            // 
            // buttonRejectPlanRecordChanges
            // 
            resources.ApplyResources(this.buttonRejectPlanRecordChanges, "buttonRejectPlanRecordChanges");
            this.buttonRejectPlanRecordChanges.Name = "buttonRejectPlanRecordChanges";
            this.buttonRejectPlanRecordChanges.UseVisualStyleBackColor = true;
            this.buttonRejectPlanRecordChanges.Click += new System.EventHandler(this.buttonRejectPlanRecordChanges_Click);
            // 
            // textBoxPlanSelectedRecordNumber
            // 
            resources.ApplyResources(this.textBoxPlanSelectedRecordNumber, "textBoxPlanSelectedRecordNumber");
            this.textBoxPlanSelectedRecordNumber.Name = "textBoxPlanSelectedRecordNumber";
            // 
            // labelPlanSelectedRecordNumber
            // 
            resources.ApplyResources(this.labelPlanSelectedRecordNumber, "labelPlanSelectedRecordNumber");
            this.labelPlanSelectedRecordNumber.Name = "labelPlanSelectedRecordNumber";
            // 
            // buttonApplyPlanRecordChanges
            // 
            resources.ApplyResources(this.buttonApplyPlanRecordChanges, "buttonApplyPlanRecordChanges");
            this.buttonApplyPlanRecordChanges.Name = "buttonApplyPlanRecordChanges";
            this.buttonApplyPlanRecordChanges.UseVisualStyleBackColor = true;
            this.buttonApplyPlanRecordChanges.Click += new System.EventHandler(this.buttonApplyPlanRecordChanges_Click);
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
            // labelPlanMinutes
            // 
            resources.ApplyResources(this.labelPlanMinutes, "labelPlanMinutes");
            this.labelPlanMinutes.Name = "labelPlanMinutes";
            // 
            // labelPlanHours
            // 
            resources.ApplyResources(this.labelPlanHours, "labelPlanHours");
            this.labelPlanHours.Name = "labelPlanHours";
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
            // groupBoxEngineSpeed
            // 
            this.groupBoxEngineSpeed.Controls.Add(this.trackBarPlanEngineRPM);
            this.groupBoxEngineSpeed.Controls.Add(this.numericUpDownPlanEngineRPM);
            this.groupBoxEngineSpeed.Controls.Add(this.labelPlanEngineVoltage);
            this.groupBoxEngineSpeed.Controls.Add(this.labelPlanEngineRPM);
            this.groupBoxEngineSpeed.Controls.Add(this.textBoxPlanEngineVoltage);
            resources.ApplyResources(this.groupBoxEngineSpeed, "groupBoxEngineSpeed");
            this.groupBoxEngineSpeed.Name = "groupBoxEngineSpeed";
            this.groupBoxEngineSpeed.TabStop = false;
            // 
            // trackBarPlanEngineRPM
            // 
            this.trackBarPlanEngineRPM.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.trackBarPlanEngineRPM, "trackBarPlanEngineRPM");
            this.trackBarPlanEngineRPM.Maximum = 1000;
            this.trackBarPlanEngineRPM.Minimum = 300;
            this.trackBarPlanEngineRPM.Name = "trackBarPlanEngineRPM";
            this.trackBarPlanEngineRPM.TickFrequency = 50;
            this.trackBarPlanEngineRPM.Value = 300;
            this.trackBarPlanEngineRPM.ValueChanged += new System.EventHandler(this.trackBarPlanEngineRPM_ValueChanged);
            // 
            // numericUpDownPlanEngineRPM
            // 
            resources.ApplyResources(this.numericUpDownPlanEngineRPM, "numericUpDownPlanEngineRPM");
            this.numericUpDownPlanEngineRPM.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPlanEngineRPM.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownPlanEngineRPM.Name = "numericUpDownPlanEngineRPM";
            this.numericUpDownPlanEngineRPM.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownPlanEngineRPM.ValueChanged += new System.EventHandler(this.numericUpDownPlanEngineRPM_ValueChanged);
            // 
            // labelPlanEngineVoltage
            // 
            resources.ApplyResources(this.labelPlanEngineVoltage, "labelPlanEngineVoltage");
            this.labelPlanEngineVoltage.Name = "labelPlanEngineVoltage";
            // 
            // labelPlanEngineRPM
            // 
            resources.ApplyResources(this.labelPlanEngineRPM, "labelPlanEngineRPM");
            this.labelPlanEngineRPM.Name = "labelPlanEngineRPM";
            // 
            // textBoxPlanEngineVoltage
            // 
            resources.ApplyResources(this.textBoxPlanEngineVoltage, "textBoxPlanEngineVoltage");
            this.textBoxPlanEngineVoltage.Name = "textBoxPlanEngineVoltage";
            // 
            // groupBoxLoad
            // 
            this.groupBoxLoad.Controls.Add(this.numericUpDownPlanLoadedWeight);
            this.groupBoxLoad.Controls.Add(this.labelLoadedWeight);
            this.groupBoxLoad.Controls.Add(this.trackBarLoadedWeight);
            resources.ApplyResources(this.groupBoxLoad, "groupBoxLoad");
            this.groupBoxLoad.Name = "groupBoxLoad";
            this.groupBoxLoad.TabStop = false;
            // 
            // labelLoadedWeight
            // 
            resources.ApplyResources(this.labelLoadedWeight, "labelLoadedWeight");
            this.labelLoadedWeight.Name = "labelLoadedWeight";
            // 
            // trackBarLoadedWeight
            // 
            this.trackBarLoadedWeight.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.trackBarLoadedWeight, "trackBarLoadedWeight");
            this.trackBarLoadedWeight.Maximum = 190;
            this.trackBarLoadedWeight.Name = "trackBarLoadedWeight";
            this.trackBarLoadedWeight.TickFrequency = 5;
            this.trackBarLoadedWeight.ValueChanged += new System.EventHandler(this.trackBarLoadedWeight_ValueChanged);
            // 
            // groupBoxTempFirst
            // 
            this.groupBoxTempFirst.Controls.Add(this.labelFirstTemp);
            this.groupBoxTempFirst.Controls.Add(this.textBoxFirstTemp);
            this.groupBoxTempFirst.Controls.Add(this.trackBarFirstTemp);
            resources.ApplyResources(this.groupBoxTempFirst, "groupBoxTempFirst");
            this.groupBoxTempFirst.Name = "groupBoxTempFirst";
            this.groupBoxTempFirst.TabStop = false;
            // 
            // labelFirstTemp
            // 
            resources.ApplyResources(this.labelFirstTemp, "labelFirstTemp");
            this.labelFirstTemp.Name = "labelFirstTemp";
            // 
            // textBoxFirstTemp
            // 
            resources.ApplyResources(this.textBoxFirstTemp, "textBoxFirstTemp");
            this.textBoxFirstTemp.Name = "textBoxFirstTemp";
            // 
            // trackBarFirstTemp
            // 
            this.trackBarFirstTemp.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.trackBarFirstTemp, "trackBarFirstTemp");
            this.trackBarFirstTemp.Maximum = 125;
            this.trackBarFirstTemp.Name = "trackBarFirstTemp";
            this.trackBarFirstTemp.TickFrequency = 5;
            this.trackBarFirstTemp.ValueChanged += new System.EventHandler(this.trackBarFirstTemp_ValueChanged);
            // 
            // groupBoxTempSecond
            // 
            this.groupBoxTempSecond.Controls.Add(this.labelSecondTemp);
            this.groupBoxTempSecond.Controls.Add(this.textBoxSecondTemp);
            this.groupBoxTempSecond.Controls.Add(this.trackBarSecondTemp);
            resources.ApplyResources(this.groupBoxTempSecond, "groupBoxTempSecond");
            this.groupBoxTempSecond.Name = "groupBoxTempSecond";
            this.groupBoxTempSecond.TabStop = false;
            // 
            // labelSecondTemp
            // 
            resources.ApplyResources(this.labelSecondTemp, "labelSecondTemp");
            this.labelSecondTemp.Name = "labelSecondTemp";
            // 
            // textBoxSecondTemp
            // 
            resources.ApplyResources(this.textBoxSecondTemp, "textBoxSecondTemp");
            this.textBoxSecondTemp.Name = "textBoxSecondTemp";
            // 
            // trackBarSecondTemp
            // 
            this.trackBarSecondTemp.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.trackBarSecondTemp, "trackBarSecondTemp");
            this.trackBarSecondTemp.Maximum = 125;
            this.trackBarSecondTemp.Name = "trackBarSecondTemp";
            this.trackBarSecondTemp.TickFrequency = 5;
            this.trackBarSecondTemp.ValueChanged += new System.EventHandler(this.trackBarSecondTemp_ValueChanged);
            // 
            // tableLayoutPanelPlanControl
            // 
            resources.ApplyResources(this.tableLayoutPanelPlanControl, "tableLayoutPanelPlanControl");
            this.tableLayoutPanelPlanControl.Controls.Add(this.buttonStartSelected, 0, 0);
            this.tableLayoutPanelPlanControl.Controls.Add(this.buttonSavePlan, 0, 1);
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
            // buttonSavePlan
            // 
            resources.ApplyResources(this.buttonSavePlan, "buttonSavePlan");
            this.buttonSavePlan.Name = "buttonSavePlan";
            this.buttonSavePlan.UseVisualStyleBackColor = true;
            this.buttonSavePlan.Click += new System.EventHandler(this.buttonSavePlan_Click);
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
            this.buttonLoadFileFromPath.Click += new System.EventHandler(this.buttonLoadFileFromPath_Click);
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
            this.listViewPlanRecords.FullRowSelect = true;
            this.listViewPlanRecords.GridLines = true;
            resources.ApplyResources(this.listViewPlanRecords, "listViewPlanRecords");
            this.listViewPlanRecords.MultiSelect = false;
            this.listViewPlanRecords.Name = "listViewPlanRecords";
            this.listViewPlanRecords.UseCompatibleStateImageBehavior = false;
            this.listViewPlanRecords.View = System.Windows.Forms.View.Details;
            this.listViewPlanRecords.SelectedIndexChanged += new System.EventHandler(this.listViewPlanRecords_SelectedIndexChanged);
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
            // columnHeaderT1
            // 
            resources.ApplyResources(this.columnHeaderT1, "columnHeaderT1");
            // 
            // columnHeaderT2
            // 
            resources.ApplyResources(this.columnHeaderT2, "columnHeaderT2");
            // 
            // Control
            // 
            this.Control.Controls.Add(this.groupBoxControlLoadedWeight);
            this.Control.Controls.Add(this.groupBoxControlVents);
            this.Control.Controls.Add(this.groupBoxControlEngine);
            resources.ApplyResources(this.Control, "Control");
            this.Control.Name = "Control";
            this.Control.UseVisualStyleBackColor = true;
            // 
            // groupBoxControlLoadedWeight
            // 
            this.groupBoxControlLoadedWeight.Controls.Add(this.buttonControlLoadSetValues);
            this.groupBoxControlLoadedWeight.Controls.Add(this.buttonControlLoadRestore);
            this.groupBoxControlLoadedWeight.Controls.Add(this.numericUpDownControlLoad);
            this.groupBoxControlLoadedWeight.Controls.Add(this.labelControlLoad);
            this.groupBoxControlLoadedWeight.Controls.Add(this.trackBarControlLoad);
            resources.ApplyResources(this.groupBoxControlLoadedWeight, "groupBoxControlLoadedWeight");
            this.groupBoxControlLoadedWeight.Name = "groupBoxControlLoadedWeight";
            this.groupBoxControlLoadedWeight.TabStop = false;
            // 
            // buttonControlLoadSetValues
            // 
            resources.ApplyResources(this.buttonControlLoadSetValues, "buttonControlLoadSetValues");
            this.buttonControlLoadSetValues.Name = "buttonControlLoadSetValues";
            this.buttonControlLoadSetValues.UseVisualStyleBackColor = true;
            this.buttonControlLoadSetValues.Click += new System.EventHandler(this.buttonControlLoadSetValues_Click);
            // 
            // buttonControlLoadRestore
            // 
            resources.ApplyResources(this.buttonControlLoadRestore, "buttonControlLoadRestore");
            this.buttonControlLoadRestore.Name = "buttonControlLoadRestore";
            this.buttonControlLoadRestore.UseVisualStyleBackColor = true;
            this.buttonControlLoadRestore.Click += new System.EventHandler(this.buttonControlLoadRestore_Click);
            // 
            // numericUpDownControlLoad
            // 
            resources.ApplyResources(this.numericUpDownControlLoad, "numericUpDownControlLoad");
            this.numericUpDownControlLoad.Maximum = new decimal(new int[] {
            190,
            0,
            0,
            0});
            this.numericUpDownControlLoad.Name = "numericUpDownControlLoad";
            this.numericUpDownControlLoad.ValueChanged += new System.EventHandler(this.numericUpDownControlLoad_ValueChanged);
            // 
            // labelControlLoad
            // 
            resources.ApplyResources(this.labelControlLoad, "labelControlLoad");
            this.labelControlLoad.Name = "labelControlLoad";
            // 
            // trackBarControlLoad
            // 
            this.trackBarControlLoad.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.trackBarControlLoad, "trackBarControlLoad");
            this.trackBarControlLoad.Maximum = 190;
            this.trackBarControlLoad.Name = "trackBarControlLoad";
            this.trackBarControlLoad.TickFrequency = 5;
            this.trackBarControlLoad.ValueChanged += new System.EventHandler(this.trackBarControlLoad_ValueChanged);
            // 
            // groupBoxControlVents
            // 
            resources.ApplyResources(this.groupBoxControlVents, "groupBoxControlVents");
            this.groupBoxControlVents.Name = "groupBoxControlVents";
            this.groupBoxControlVents.TabStop = false;
            // 
            // groupBoxControlEngine
            // 
            this.groupBoxControlEngine.Controls.Add(this.groupBoxControlEngineCurrentParams);
            this.groupBoxControlEngine.Controls.Add(this.buttonControlEngineRestore);
            this.groupBoxControlEngine.Controls.Add(this.buttonControlEngineStart);
            this.groupBoxControlEngine.Controls.Add(this.buttonControlEngineStop);
            this.groupBoxControlEngine.Controls.Add(this.buttonControlEngineSetValues);
            this.groupBoxControlEngine.Controls.Add(this.trackBarControlEngineRPM);
            this.groupBoxControlEngine.Controls.Add(this.labelControlEngineRPM);
            this.groupBoxControlEngine.Controls.Add(this.numericUpDownControlEngineRPM);
            this.groupBoxControlEngine.Controls.Add(this.labelControlEngineSpeed);
            this.groupBoxControlEngine.Controls.Add(this.textBoxControlEngineVoltage);
            this.groupBoxControlEngine.Controls.Add(this.labelControlEngineVoltage);
            resources.ApplyResources(this.groupBoxControlEngine, "groupBoxControlEngine");
            this.groupBoxControlEngine.Name = "groupBoxControlEngine";
            this.groupBoxControlEngine.TabStop = false;
            // 
            // groupBoxControlEngineCurrentParams
            // 
            this.groupBoxControlEngineCurrentParams.Controls.Add(this.textBoxControlEngineCurrentRPM);
            this.groupBoxControlEngineCurrentParams.Controls.Add(this.labelControlEngineCurrentVoltage);
            this.groupBoxControlEngineCurrentParams.Controls.Add(this.labelControlEngineCurrentRPM);
            this.groupBoxControlEngineCurrentParams.Controls.Add(this.textBoxControlEngineCurrentVoltage);
            resources.ApplyResources(this.groupBoxControlEngineCurrentParams, "groupBoxControlEngineCurrentParams");
            this.groupBoxControlEngineCurrentParams.Name = "groupBoxControlEngineCurrentParams";
            this.groupBoxControlEngineCurrentParams.TabStop = false;
            // 
            // textBoxControlEngineCurrentRPM
            // 
            resources.ApplyResources(this.textBoxControlEngineCurrentRPM, "textBoxControlEngineCurrentRPM");
            this.textBoxControlEngineCurrentRPM.Name = "textBoxControlEngineCurrentRPM";
            // 
            // labelControlEngineCurrentVoltage
            // 
            resources.ApplyResources(this.labelControlEngineCurrentVoltage, "labelControlEngineCurrentVoltage");
            this.labelControlEngineCurrentVoltage.Name = "labelControlEngineCurrentVoltage";
            // 
            // labelControlEngineCurrentRPM
            // 
            resources.ApplyResources(this.labelControlEngineCurrentRPM, "labelControlEngineCurrentRPM");
            this.labelControlEngineCurrentRPM.Name = "labelControlEngineCurrentRPM";
            // 
            // textBoxControlEngineCurrentVoltage
            // 
            resources.ApplyResources(this.textBoxControlEngineCurrentVoltage, "textBoxControlEngineCurrentVoltage");
            this.textBoxControlEngineCurrentVoltage.Name = "textBoxControlEngineCurrentVoltage";
            // 
            // buttonControlEngineRestore
            // 
            resources.ApplyResources(this.buttonControlEngineRestore, "buttonControlEngineRestore");
            this.buttonControlEngineRestore.Name = "buttonControlEngineRestore";
            this.buttonControlEngineRestore.UseVisualStyleBackColor = true;
            this.buttonControlEngineRestore.Click += new System.EventHandler(this.buttonControlEngineRestore_Click);
            // 
            // buttonControlEngineStart
            // 
            resources.ApplyResources(this.buttonControlEngineStart, "buttonControlEngineStart");
            this.buttonControlEngineStart.Name = "buttonControlEngineStart";
            this.buttonControlEngineStart.UseVisualStyleBackColor = true;
            this.buttonControlEngineStart.Click += new System.EventHandler(this.buttonControlEngineStart_Click);
            // 
            // buttonControlEngineStop
            // 
            resources.ApplyResources(this.buttonControlEngineStop, "buttonControlEngineStop");
            this.buttonControlEngineStop.Name = "buttonControlEngineStop";
            this.buttonControlEngineStop.UseVisualStyleBackColor = true;
            this.buttonControlEngineStop.Click += new System.EventHandler(this.buttonControlEngineStop_Click);
            // 
            // buttonControlEngineSetValues
            // 
            resources.ApplyResources(this.buttonControlEngineSetValues, "buttonControlEngineSetValues");
            this.buttonControlEngineSetValues.Name = "buttonControlEngineSetValues";
            this.buttonControlEngineSetValues.UseVisualStyleBackColor = true;
            this.buttonControlEngineSetValues.Click += new System.EventHandler(this.buttonControlEngineSetValues_Click);
            // 
            // trackBarControlEngineRPM
            // 
            this.trackBarControlEngineRPM.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.trackBarControlEngineRPM, "trackBarControlEngineRPM");
            this.trackBarControlEngineRPM.Maximum = 1000;
            this.trackBarControlEngineRPM.Minimum = 300;
            this.trackBarControlEngineRPM.Name = "trackBarControlEngineRPM";
            this.trackBarControlEngineRPM.TickFrequency = 50;
            this.trackBarControlEngineRPM.Value = 300;
            this.trackBarControlEngineRPM.ValueChanged += new System.EventHandler(this.trackBarControlEngineRPM_ValueChanged);
            // 
            // labelControlEngineRPM
            // 
            resources.ApplyResources(this.labelControlEngineRPM, "labelControlEngineRPM");
            this.labelControlEngineRPM.Name = "labelControlEngineRPM";
            // 
            // numericUpDownControlEngineRPM
            // 
            resources.ApplyResources(this.numericUpDownControlEngineRPM, "numericUpDownControlEngineRPM");
            this.numericUpDownControlEngineRPM.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownControlEngineRPM.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownControlEngineRPM.Name = "numericUpDownControlEngineRPM";
            this.numericUpDownControlEngineRPM.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownControlEngineRPM.ValueChanged += new System.EventHandler(this.numericUpDownControlEngineRPM_ValueChanged);
            // 
            // labelControlEngineSpeed
            // 
            resources.ApplyResources(this.labelControlEngineSpeed, "labelControlEngineSpeed");
            this.labelControlEngineSpeed.Name = "labelControlEngineSpeed";
            // 
            // textBoxControlEngineVoltage
            // 
            resources.ApplyResources(this.textBoxControlEngineVoltage, "textBoxControlEngineVoltage");
            this.textBoxControlEngineVoltage.Name = "textBoxControlEngineVoltage";
            // 
            // labelControlEngineVoltage
            // 
            resources.ApplyResources(this.labelControlEngineVoltage, "labelControlEngineVoltage");
            this.labelControlEngineVoltage.Name = "labelControlEngineVoltage";
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
            this.tabControlControlPanel.Controls.Add(this.DebugTab);
            resources.ApplyResources(this.tabControlControlPanel, "tabControlControlPanel");
            this.tabControlControlPanel.Name = "tabControlControlPanel";
            this.tabControlControlPanel.SelectedIndex = 0;
            // 
            // DebugTab
            // 
            this.DebugTab.Controls.Add(this.buttonShowDebugInfo);
            this.DebugTab.Controls.Add(this.richTextBoxDebug);
            resources.ApplyResources(this.DebugTab, "DebugTab");
            this.DebugTab.Name = "DebugTab";
            this.DebugTab.UseVisualStyleBackColor = true;
            // 
            // buttonShowDebugInfo
            // 
            resources.ApplyResources(this.buttonShowDebugInfo, "buttonShowDebugInfo");
            this.buttonShowDebugInfo.Name = "buttonShowDebugInfo";
            this.buttonShowDebugInfo.UseVisualStyleBackColor = true;
            this.buttonShowDebugInfo.Click += new System.EventHandler(this.buttonShowDebugInfo_Click);
            // 
            // richTextBoxDebug
            // 
            resources.ApplyResources(this.richTextBoxDebug, "richTextBoxDebug");
            this.richTextBoxDebug.Name = "richTextBoxDebug";
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
            this.tableLayoutPanelPlan.Controls.Add(this.textBoxEndTime, 1, 2);
            this.tableLayoutPanelPlan.Controls.Add(this.textBoxRemainingTime, 1, 3);
            this.tableLayoutPanelPlan.Controls.Add(this.labelRecordInExecution, 0, 0);
            this.tableLayoutPanelPlan.Controls.Add(this.labelStartTime, 0, 1);
            this.tableLayoutPanelPlan.Controls.Add(this.labelEndTime, 0, 2);
            this.tableLayoutPanelPlan.Controls.Add(this.labelRemainingTime, 0, 3);
            this.tableLayoutPanelPlan.Controls.Add(this.textBoxStartTime, 1, 1);
            this.tableLayoutPanelPlan.Name = "tableLayoutPanelPlan";
            // 
            // textBoxRecordInExecutuion
            // 
            resources.ApplyResources(this.textBoxRecordInExecutuion, "textBoxRecordInExecutuion");
            this.textBoxRecordInExecutuion.Name = "textBoxRecordInExecutuion";
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
            // textBoxStartTime
            // 
            resources.ApplyResources(this.textBoxStartTime, "textBoxStartTime");
            this.textBoxStartTime.Name = "textBoxStartTime";
            // 
            // openFileDialogPlan
            // 
            this.openFileDialogPlan.FileName = "openFileDialogPlan";
            // 
            // numericUpDownPlanLoadedWeight
            // 
            resources.ApplyResources(this.numericUpDownPlanLoadedWeight, "numericUpDownPlanLoadedWeight");
            this.numericUpDownPlanLoadedWeight.Maximum = new decimal(new int[] {
            190,
            0,
            0,
            0});
            this.numericUpDownPlanLoadedWeight.Name = "numericUpDownPlanLoadedWeight";
            this.numericUpDownPlanLoadedWeight.ValueChanged += new System.EventHandler(this.numericUpDownPlanLoadedWeight_ValueChanged);
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
            this.tableLayoutPanelRecordActions.ResumeLayout(false);
            this.tableLayoutPanelPlanValues.ResumeLayout(false);
            this.groupBoxSelected.ResumeLayout(false);
            this.groupBoxSelected.PerformLayout();
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlanMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlanHours)).EndInit();
            this.groupBoxEngineSpeed.ResumeLayout(false);
            this.groupBoxEngineSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlanEngineRPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlanEngineRPM)).EndInit();
            this.groupBoxLoad.ResumeLayout(false);
            this.groupBoxLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLoadedWeight)).EndInit();
            this.groupBoxTempFirst.ResumeLayout(false);
            this.groupBoxTempFirst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFirstTemp)).EndInit();
            this.groupBoxTempSecond.ResumeLayout(false);
            this.groupBoxTempSecond.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSecondTemp)).EndInit();
            this.tableLayoutPanelPlanControl.ResumeLayout(false);
            this.Control.ResumeLayout(false);
            this.groupBoxControlLoadedWeight.ResumeLayout(false);
            this.groupBoxControlLoadedWeight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownControlLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControlLoad)).EndInit();
            this.groupBoxControlEngine.ResumeLayout(false);
            this.groupBoxControlEngine.PerformLayout();
            this.groupBoxControlEngineCurrentParams.ResumeLayout(false);
            this.groupBoxControlEngineCurrentParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControlEngineRPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownControlEngineRPM)).EndInit();
            this.tabControlControlPanel.ResumeLayout(false);
            this.DebugTab.ResumeLayout(false);
            this.groupBoxCurrentParameters.ResumeLayout(false);
            this.tableLayoutPanelParameters.ResumeLayout(false);
            this.tableLayoutPanelParameters.PerformLayout();
            this.groupBoxPlan.ResumeLayout(false);
            this.tableLayoutPanelPlan.ResumeLayout(false);
            this.tableLayoutPanelPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlanLoadedWeight)).EndInit();
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
        private System.Windows.Forms.Button buttonSavePlan;
        private System.Windows.Forms.Button buttonStopPlan;
        private System.Windows.Forms.Button buttonLoadFileFromPath;
        private System.Windows.Forms.GroupBox groupBoxSelected;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.GroupBox groupBoxEngineSpeed;
        private System.Windows.Forms.GroupBox groupBoxLoad;
        private System.Windows.Forms.GroupBox groupBoxTempFirst;
        private System.Windows.Forms.GroupBox groupBoxTempSecond;
        private System.Windows.Forms.NumericUpDown numericUpDownPlanHours;
        private System.Windows.Forms.Label labelPlanMinutes;
        private System.Windows.Forms.Label labelPlanHours;
        private System.Windows.Forms.NumericUpDown numericUpDownPlanMinutes;
        private System.Windows.Forms.TextBox textBoxPlanEngineVoltage;
        private System.Windows.Forms.Label labelPlanEngineVoltage;
        private System.Windows.Forms.Label labelPlanEngineRPM;
        private System.Windows.Forms.ColumnHeader columnHeaderT1;
        private System.Windows.Forms.ColumnHeader columnHeaderT2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRecordActions;
        private System.Windows.Forms.Button buttonRecordAdd;
        private System.Windows.Forms.Button buttonRecordDelete;
        private System.Windows.Forms.Button buttonRecordUp;
        private System.Windows.Forms.Button buttonRecordDown;
        private System.Windows.Forms.Label labelLoadedWeight;
        private System.Windows.Forms.TrackBar trackBarLoadedWeight;
        private System.Windows.Forms.Label labelFirstTemp;
        private System.Windows.Forms.TextBox textBoxFirstTemp;
        private System.Windows.Forms.TrackBar trackBarFirstTemp;
        private System.Windows.Forms.Label labelSecondTemp;
        private System.Windows.Forms.TextBox textBoxSecondTemp;
        private System.Windows.Forms.TrackBar trackBarSecondTemp;
        private System.Windows.Forms.GroupBox groupBoxControlLoadedWeight;
        private System.Windows.Forms.GroupBox groupBoxControlVents;
        private System.Windows.Forms.GroupBox groupBoxControlEngine;
        private System.Windows.Forms.TextBox textBoxControlEngineVoltage;
        private System.Windows.Forms.Label labelControlEngineVoltage;
        private System.Windows.Forms.Label labelControlEngineSpeed;
        private System.Windows.Forms.TrackBar trackBarControlEngineRPM;
        private System.Windows.Forms.Label labelControlEngineRPM;
        private System.Windows.Forms.NumericUpDown numericUpDownControlEngineRPM;
        private System.Windows.Forms.Button buttonControlEngineStop;
        private System.Windows.Forms.Button buttonControlEngineSetValues;
        private System.Windows.Forms.Button buttonControlEngineStart;
        private System.Windows.Forms.TabPage DebugTab;
        private System.Windows.Forms.RichTextBox richTextBoxDebug;
        private System.Windows.Forms.Button buttonShowDebugInfo;
        private System.Windows.Forms.Button buttonControlEngineRestore;
        private System.Windows.Forms.GroupBox groupBoxControlEngineCurrentParams;
        private System.Windows.Forms.TextBox textBoxControlEngineCurrentVoltage;
        private System.Windows.Forms.Label labelControlEngineCurrentVoltage;
        private System.Windows.Forms.Label labelControlEngineCurrentRPM;
        private System.Windows.Forms.TextBox textBoxControlEngineCurrentRPM;
        private System.Windows.Forms.NumericUpDown numericUpDownPlanEngineRPM;
        private System.Windows.Forms.Button buttonApplyPlanRecordChanges;
        private System.Windows.Forms.TrackBar trackBarPlanEngineRPM;
        private System.Windows.Forms.TextBox textBoxPlanSelectedRecordNumber;
        private System.Windows.Forms.Label labelPlanSelectedRecordNumber;
        private System.Windows.Forms.Button buttonRejectPlanRecordChanges;
        private System.Windows.Forms.SaveFileDialog saveFileDialogPlan;
        private System.Windows.Forms.TrackBar trackBarControlLoad;
        private System.Windows.Forms.Label labelControlLoad;
        private System.Windows.Forms.NumericUpDown numericUpDownControlLoad;
        private System.Windows.Forms.Button buttonControlLoadSetValues;
        private System.Windows.Forms.Button buttonControlLoadRestore;
        private System.Windows.Forms.NumericUpDown numericUpDownPlanLoadedWeight;
    }
}

