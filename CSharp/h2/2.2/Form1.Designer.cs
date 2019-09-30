namespace _2._2
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
            this.btnMAKE = new System.Windows.Forms.Button();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMAKE
            // 
            this.btnMAKE.Location = new System.Drawing.Point(304, 122);
            this.btnMAKE.Name = "btnMAKE";
            this.btnMAKE.Size = new System.Drawing.Size(90, 41);
            this.btnMAKE.TabIndex = 0;
            this.btnMAKE.Text = "Maak rij";
            this.btnMAKE.UseVisualStyleBackColor = true;
            this.btnMAKE.Click += new System.EventHandler(this.BtnMAKE_Click);
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 16;
            this.lstBox.Location = new System.Drawing.Point(430, 122);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(192, 244);
            this.lstBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hoeveel getallen wilt u?";
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(489, 65);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(100, 22);
            this.txtbox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.btnMAKE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMAKE;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox1;
    }
}

