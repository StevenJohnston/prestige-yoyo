namespace Prestige_YoYo
{
    partial class General_User
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btnProductionYied = new System.Windows.Forms.Button();
            this.btnfinalYield = new System.Windows.Forms.Button();
            this.btnDefect = new System.Windows.Forms.Button();
            this.btnSelectFactory = new System.Windows.Forms.Button();
            this.btnSelectStation = new System.Windows.Forms.Button();
            this.lblFactorySelected = new System.Windows.Forms.Label();
            this.lblStationSelected = new System.Windows.Forms.Label();
            this.tabChart = new System.Windows.Forms.TabControl();
            this.tabProductionYield = new System.Windows.Forms.TabPage();
            this.tabFinalYield = new System.Windows.Forms.TabPage();
            this.tabDefects = new System.Windows.Forms.TabPage();
            this.pieProductionYield = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieFinalYield = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.paretoDefects = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabChart.SuspendLayout();
            this.tabProductionYield.SuspendLayout();
            this.tabFinalYield.SuspendLayout();
            this.tabDefects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieProductionYield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieFinalYield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paretoDefects)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProductionYied
            // 
            this.btnProductionYied.Location = new System.Drawing.Point(12, 127);
            this.btnProductionYied.Name = "btnProductionYied";
            this.btnProductionYied.Size = new System.Drawing.Size(146, 60);
            this.btnProductionYied.TabIndex = 0;
            this.btnProductionYied.Text = "Production Yield";
            this.btnProductionYied.UseVisualStyleBackColor = true;
            this.btnProductionYied.Click += new System.EventHandler(this.btnProductionYield_Click);
            // 
            // btnfinalYield
            // 
            this.btnfinalYield.Location = new System.Drawing.Point(12, 193);
            this.btnfinalYield.Name = "btnfinalYield";
            this.btnfinalYield.Size = new System.Drawing.Size(146, 60);
            this.btnfinalYield.TabIndex = 1;
            this.btnfinalYield.Text = "Final Yield";
            this.btnfinalYield.UseVisualStyleBackColor = true;
            // 
            // btnDefect
            // 
            this.btnDefect.Location = new System.Drawing.Point(12, 259);
            this.btnDefect.Name = "btnDefect";
            this.btnDefect.Size = new System.Drawing.Size(146, 60);
            this.btnDefect.TabIndex = 2;
            this.btnDefect.Text = "Defects";
            this.btnDefect.UseVisualStyleBackColor = true;
            // 
            // btnSelectFactory
            // 
            this.btnSelectFactory.Location = new System.Drawing.Point(12, 12);
            this.btnSelectFactory.Name = "btnSelectFactory";
            this.btnSelectFactory.Size = new System.Drawing.Size(146, 23);
            this.btnSelectFactory.TabIndex = 3;
            this.btnSelectFactory.Text = "Select Factory";
            this.btnSelectFactory.UseVisualStyleBackColor = true;
            this.btnSelectFactory.Click += new System.EventHandler(this.btnSelectFactory_Click);
            // 
            // btnSelectStation
            // 
            this.btnSelectStation.Location = new System.Drawing.Point(12, 64);
            this.btnSelectStation.Name = "btnSelectStation";
            this.btnSelectStation.Size = new System.Drawing.Size(146, 23);
            this.btnSelectStation.TabIndex = 4;
            this.btnSelectStation.Text = "Select Station";
            this.btnSelectStation.UseVisualStyleBackColor = true;
            this.btnSelectStation.Click += new System.EventHandler(this.btnSelectStation_Click);
            // 
            // lblFactorySelected
            // 
            this.lblFactorySelected.AutoSize = true;
            this.lblFactorySelected.Location = new System.Drawing.Point(13, 42);
            this.lblFactorySelected.Name = "lblFactorySelected";
            this.lblFactorySelected.Size = new System.Drawing.Size(104, 13);
            this.lblFactorySelected.TabIndex = 5;
            this.lblFactorySelected.Text = "No Factory Selected";
            // 
            // lblStationSelected
            // 
            this.lblStationSelected.AutoSize = true;
            this.lblStationSelected.Location = new System.Drawing.Point(13, 94);
            this.lblStationSelected.Name = "lblStationSelected";
            this.lblStationSelected.Size = new System.Drawing.Size(102, 13);
            this.lblStationSelected.TabIndex = 6;
            this.lblStationSelected.Text = "No Station Selected";
            // 
            // tabChart
            // 
            this.tabChart.Controls.Add(this.tabProductionYield);
            this.tabChart.Controls.Add(this.tabFinalYield);
            this.tabChart.Controls.Add(this.tabDefects);
            this.tabChart.Location = new System.Drawing.Point(164, 12);
            this.tabChart.Name = "tabChart";
            this.tabChart.SelectedIndex = 0;
            this.tabChart.Size = new System.Drawing.Size(641, 456);
            this.tabChart.TabIndex = 7;
            // 
            // tabProductionYield
            // 
            this.tabProductionYield.Controls.Add(this.pieProductionYield);
            this.tabProductionYield.Location = new System.Drawing.Point(4, 22);
            this.tabProductionYield.Name = "tabProductionYield";
            this.tabProductionYield.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductionYield.Size = new System.Drawing.Size(633, 430);
            this.tabProductionYield.TabIndex = 0;
            this.tabProductionYield.Text = "Production Yield";
            this.tabProductionYield.UseVisualStyleBackColor = true;
            this.tabProductionYield.Enter += new System.EventHandler(this.tabProductionYield_Enter);
            // 
            // tabFinalYield
            // 
            this.tabFinalYield.Controls.Add(this.pieFinalYield);
            this.tabFinalYield.Location = new System.Drawing.Point(4, 22);
            this.tabFinalYield.Name = "tabFinalYield";
            this.tabFinalYield.Padding = new System.Windows.Forms.Padding(3);
            this.tabFinalYield.Size = new System.Drawing.Size(633, 430);
            this.tabFinalYield.TabIndex = 1;
            this.tabFinalYield.Text = "Final Yield";
            this.tabFinalYield.UseVisualStyleBackColor = true;
            this.tabFinalYield.Enter += new System.EventHandler(this.tabFinalYield_Enter);
            // 
            // tabDefects
            // 
            this.tabDefects.Controls.Add(this.paretoDefects);
            this.tabDefects.Location = new System.Drawing.Point(4, 22);
            this.tabDefects.Name = "tabDefects";
            this.tabDefects.Padding = new System.Windows.Forms.Padding(3);
            this.tabDefects.Size = new System.Drawing.Size(633, 430);
            this.tabDefects.TabIndex = 2;
            this.tabDefects.Text = "Defects";
            this.tabDefects.UseVisualStyleBackColor = true;
            this.tabDefects.Enter += new System.EventHandler(this.tabDefects_Enter);
            // 
            // pieProductionYield
            // 
            chartArea1.Name = "ChartArea1";
            this.pieProductionYield.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pieProductionYield.Legends.Add(legend1);
            this.pieProductionYield.Location = new System.Drawing.Point(6, 6);
            this.pieProductionYield.Name = "pieProductionYield";
            this.pieProductionYield.Size = new System.Drawing.Size(621, 421);
            this.pieProductionYield.TabIndex = 0;
            this.pieProductionYield.Text = "Production Yield";
            // 
            // pieFinalYield
            // 
            chartArea2.Name = "ChartArea1";
            this.pieFinalYield.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pieFinalYield.Legends.Add(legend2);
            this.pieFinalYield.Location = new System.Drawing.Point(6, 5);
            this.pieFinalYield.Name = "pieFinalYield";
            this.pieFinalYield.Size = new System.Drawing.Size(621, 421);
            this.pieFinalYield.TabIndex = 1;
            this.pieFinalYield.Text = "Final Yield";
            // 
            // paretoDefects
            // 
            chartArea3.Name = "ChartArea1";
            this.paretoDefects.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.paretoDefects.Legends.Add(legend3);
            this.paretoDefects.Location = new System.Drawing.Point(6, 5);
            this.paretoDefects.Name = "paretoDefects";
            this.paretoDefects.Size = new System.Drawing.Size(621, 421);
            this.paretoDefects.TabIndex = 2;
            this.paretoDefects.Text = "Final Yield";
            // 
            // General_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 570);
            this.Controls.Add(this.tabChart);
            this.Controls.Add(this.lblStationSelected);
            this.Controls.Add(this.lblFactorySelected);
            this.Controls.Add(this.btnSelectStation);
            this.Controls.Add(this.btnSelectFactory);
            this.Controls.Add(this.btnDefect);
            this.Controls.Add(this.btnfinalYield);
            this.Controls.Add(this.btnProductionYied);
            this.Name = "General_User";
            this.Text = "General User";
            this.tabChart.ResumeLayout(false);
            this.tabProductionYield.ResumeLayout(false);
            this.tabFinalYield.ResumeLayout(false);
            this.tabDefects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pieProductionYield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieFinalYield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paretoDefects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProductionYied;
        private System.Windows.Forms.Button btnfinalYield;
        private System.Windows.Forms.Button btnDefect;
        private System.Windows.Forms.Button btnSelectFactory;
        private System.Windows.Forms.Button btnSelectStation;
        private System.Windows.Forms.Label lblFactorySelected;
        private System.Windows.Forms.Label lblStationSelected;
        private System.Windows.Forms.TabControl tabChart;
        private System.Windows.Forms.TabPage tabProductionYield;
        private System.Windows.Forms.TabPage tabFinalYield;
        private System.Windows.Forms.TabPage tabDefects;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieProductionYield;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieFinalYield;
        private System.Windows.Forms.DataVisualization.Charting.Chart paretoDefects;
    }
}