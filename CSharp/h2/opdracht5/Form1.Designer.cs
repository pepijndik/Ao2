namespace opdracht5
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
            this.txtBegin = new System.Windows.Forms.TextBox();
            this.txtOmgedraaid = new System.Windows.Forms.TextBox();
            this.btnOmdraaien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBegin
            // 
            this.txtBegin.Location = new System.Drawing.Point(231, 80);
            this.txtBegin.Name = "txtBegin";
            this.txtBegin.Size = new System.Drawing.Size(171, 22);
            this.txtBegin.TabIndex = 0;
            // 
            // txtOmgedraaid
            // 
            this.txtOmgedraaid.Location = new System.Drawing.Point(231, 143);
            this.txtOmgedraaid.Name = "txtOmgedraaid";
            this.txtOmgedraaid.ReadOnly = true;
            this.txtOmgedraaid.Size = new System.Drawing.Size(171, 22);
            this.txtOmgedraaid.TabIndex = 1;
            // 
            // btnOmdraaien
            // 
            this.btnOmdraaien.Location = new System.Drawing.Point(231, 108);
            this.btnOmdraaien.Name = "btnOmdraaien";
            this.btnOmdraaien.Size = new System.Drawing.Size(171, 29);
            this.btnOmdraaien.TabIndex = 2;
            this.btnOmdraaien.Text = "Omdraaien";
            this.btnOmdraaien.UseVisualStyleBackColor = true;
            this.btnOmdraaien.Click += new System.EventHandler(this.BtnOmdraaien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOmdraaien);
            this.Controls.Add(this.txtOmgedraaid);
            this.Controls.Add(this.txtBegin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBegin;
        private System.Windows.Forms.TextBox txtOmgedraaid;
        private System.Windows.Forms.Button btnOmdraaien;
    }
}

