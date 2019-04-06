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
            this.tabControlControlPanel.SuspendLayout();
            this.groupBoxCurrentParameters.SuspendLayout();
            this.tableLayoutPanelParameters.SuspendLayout();
            this.groupBoxPlan.SuspendLayout();
            this.tableLayoutPanelPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // Plan
            // 
            resources.ApplyResources(this.Plan, "Plan");
            this.Plan.Name = "Plan";
            this.Plan.UseVisualStyleBackColor = true;
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
            this.tabControlControlPanel.ResumeLayout(false);
            this.groupBoxCurrentParameters.ResumeLayout(false);
            this.tableLayoutPanelParameters.ResumeLayout(false);
            this.tableLayoutPanelParameters.PerformLayout();
            this.groupBoxPlan.ResumeLayout(false);
            this.tableLayoutPanelPlan.ResumeLayout(false);
            this.tableLayoutPanelPlan.PerformLayout();
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
    }
}

