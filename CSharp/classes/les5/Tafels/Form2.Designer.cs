namespace Tafels
{
    partial class Form2
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
            this.txt_tafelNrm = new System.Windows.Forms.TextBox();
            this.txt_Stoelen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_excute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_tafelNrm
            // 
            this.txt_tafelNrm.Location = new System.Drawing.Point(389, 96);
            this.txt_tafelNrm.Name = "txt_tafelNrm";
            this.txt_tafelNrm.Size = new System.Drawing.Size(100, 22);
            this.txt_tafelNrm.TabIndex = 0;
            // 
            // txt_Stoelen
            // 
            this.txt_Stoelen.Location = new System.Drawing.Point(389, 135);
            this.txt_Stoelen.Name = "txt_Stoelen";
            this.txt_Stoelen.Size = new System.Drawing.Size(100, 22);
            this.txt_Stoelen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "TafelNmr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aantal Stoelen";
            // 
            // btn_excute
            // 
            this.btn_excute.Location = new System.Drawing.Point(500, 178);
            this.btn_excute.Name = "btn_excute";
            this.btn_excute.Size = new System.Drawing.Size(104, 23);
            this.btn_excute.TabIndex = 4;
            this.btn_excute.Text = "Toepassen";
            this.btn_excute.UseVisualStyleBackColor = true;
            this.btn_excute.Click += new System.EventHandler(this.btn_excute_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_excute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Stoelen);
            this.Controls.Add(this.txt_tafelNrm);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tafelNrm;
        private System.Windows.Forms.TextBox txt_Stoelen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_excute;
    }
}