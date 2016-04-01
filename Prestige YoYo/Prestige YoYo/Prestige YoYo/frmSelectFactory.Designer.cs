namespace Prestige_YoYo
{
    partial class frmSelectFactory
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
            this.lstFactories = new System.Windows.Forms.ListBox();
            this.btnSelectFactory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFactories
            // 
            this.lstFactories.FormattingEnabled = true;
            this.lstFactories.Location = new System.Drawing.Point(13, 13);
            this.lstFactories.Name = "lstFactories";
            this.lstFactories.Size = new System.Drawing.Size(236, 394);
            this.lstFactories.TabIndex = 0;
            // 
            // btnSelectFactory
            // 
            this.btnSelectFactory.Location = new System.Drawing.Point(13, 419);
            this.btnSelectFactory.Name = "btnSelectFactory";
            this.btnSelectFactory.Size = new System.Drawing.Size(236, 23);
            this.btnSelectFactory.TabIndex = 1;
            this.btnSelectFactory.Text = "Select Factory";
            this.btnSelectFactory.UseVisualStyleBackColor = true;
            this.btnSelectFactory.Click += new System.EventHandler(this.btnSelectFactory_Click);
            // 
            // Select_Factory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 454);
            this.Controls.Add(this.btnSelectFactory);
            this.Controls.Add(this.lstFactories);
            this.Name = "Select_Factory";
            this.Text = "Select_Factory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFactories;
        private System.Windows.Forms.Button btnSelectFactory;
    }
}