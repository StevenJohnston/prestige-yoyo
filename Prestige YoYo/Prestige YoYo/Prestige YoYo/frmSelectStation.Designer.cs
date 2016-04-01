namespace Prestige_YoYo
{
    partial class frmSelectStation
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
            this.btnSelectStation = new System.Windows.Forms.Button();
            this.lstStations = new System.Windows.Forms.ListBox();
            this.lblFactory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectStation
            // 
            this.btnSelectStation.Location = new System.Drawing.Point(12, 435);
            this.btnSelectStation.Name = "btnSelectStation";
            this.btnSelectStation.Size = new System.Drawing.Size(236, 23);
            this.btnSelectStation.TabIndex = 3;
            this.btnSelectStation.Text = "Select Station";
            this.btnSelectStation.UseVisualStyleBackColor = true;
            this.btnSelectStation.Click += new System.EventHandler(this.btnSelectStation_Click);
            // 
            // lstStations
            // 
            this.lstStations.FormattingEnabled = true;
            this.lstStations.Location = new System.Drawing.Point(12, 29);
            this.lstStations.Name = "lstStations";
            this.lstStations.Size = new System.Drawing.Size(236, 394);
            this.lstStations.TabIndex = 2;
            // 
            // lblFactory
            // 
            this.lblFactory.AutoSize = true;
            this.lblFactory.Location = new System.Drawing.Point(13, 13);
            this.lblFactory.Name = "lblFactory";
            this.lblFactory.Size = new System.Drawing.Size(52, 13);
            this.lblFactory.TabIndex = 4;
            this.lblFactory.Text = "lblFactory";
            // 
            // frmSelectStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 473);
            this.Controls.Add(this.lblFactory);
            this.Controls.Add(this.btnSelectStation);
            this.Controls.Add(this.lstStations);
            this.Name = "frmSelectStation";
            this.Text = "Select Station";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectStation;
        private System.Windows.Forms.ListBox lstStations;
        private System.Windows.Forms.Label lblFactory;
    }
}