namespace Lijstvannamen
{
    partial class Form1
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
            this.lstBox = new System.Windows.Forms.ListBox();
            this.btnOmkeren = new System.Windows.Forms.Button();
            this.lstBoxResultaat = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 16;
            this.lstBox.Location = new System.Drawing.Point(30, 34);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(296, 260);
            this.lstBox.TabIndex = 0;
            // 
            // btnOmkeren
            // 
            this.btnOmkeren.Location = new System.Drawing.Point(30, 300);
            this.btnOmkeren.Name = "btnOmkeren";
            this.btnOmkeren.Size = new System.Drawing.Size(218, 67);
            this.btnOmkeren.TabIndex = 1;
            this.btnOmkeren.Text = "Omkeren";
            this.btnOmkeren.UseVisualStyleBackColor = true;
            this.btnOmkeren.Click += new System.EventHandler(this.BtnOmkeren_Click);
            // 
            // lstBoxResultaat
            // 
            this.lstBoxResultaat.FormattingEnabled = true;
            this.lstBoxResultaat.ItemHeight = 16;
            this.lstBoxResultaat.Location = new System.Drawing.Point(351, 34);
            this.lstBoxResultaat.Name = "lstBoxResultaat";
            this.lstBoxResultaat.Size = new System.Drawing.Size(296, 260);
            this.lstBoxResultaat.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBoxResultaat);
            this.Controls.Add(this.btnOmkeren);
            this.Controls.Add(this.lstBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Button btnOmkeren;
        private System.Windows.Forms.ListBox lstBoxResultaat;
    }
}

