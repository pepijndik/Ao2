namespace Rechthoek
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
            this.txtLengte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBreedte = new System.Windows.Forms.TextBox();
            this.btnCalcu = new System.Windows.Forms.Button();
            this.txtOppervlak = new System.Windows.Forms.TextBox();
            this.txtOmtrek = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLengte
            // 
            this.txtLengte.Location = new System.Drawing.Point(243, 115);
            this.txtLengte.Name = "txtLengte";
            this.txtLengte.Size = new System.Drawing.Size(100, 22);
            this.txtLengte.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Geef lengte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Geef breedte";
            // 
            // txtBreedte
            // 
            this.txtBreedte.Location = new System.Drawing.Point(243, 145);
            this.txtBreedte.Name = "txtBreedte";
            this.txtBreedte.Size = new System.Drawing.Size(100, 22);
            this.txtBreedte.TabIndex = 3;
            // 
            // btnCalcu
            // 
            this.btnCalcu.Location = new System.Drawing.Point(243, 174);
            this.btnCalcu.Name = "btnCalcu";
            this.btnCalcu.Size = new System.Drawing.Size(75, 23);
            this.btnCalcu.TabIndex = 4;
            this.btnCalcu.Text = "bereken";
            this.btnCalcu.UseVisualStyleBackColor = true;
            this.btnCalcu.Click += new System.EventHandler(this.btnCalcu_Click);
            // 
            // txtOppervlak
            // 
            this.txtOppervlak.Location = new System.Drawing.Point(243, 228);
            this.txtOppervlak.Name = "txtOppervlak";
            this.txtOppervlak.ReadOnly = true;
            this.txtOppervlak.Size = new System.Drawing.Size(100, 22);
            this.txtOppervlak.TabIndex = 5;
            // 
            // txtOmtrek
            // 
            this.txtOmtrek.Location = new System.Drawing.Point(243, 256);
            this.txtOmtrek.Name = "txtOmtrek";
            this.txtOmtrek.ReadOnly = true;
            this.txtOmtrek.Size = new System.Drawing.Size(100, 22);
            this.txtOmtrek.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Oppervlak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Omtrek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOmtrek);
            this.Controls.Add(this.txtOppervlak);
            this.Controls.Add(this.btnCalcu);
            this.Controls.Add(this.txtBreedte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLengte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLengte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBreedte;
        private System.Windows.Forms.Button btnCalcu;
        private System.Windows.Forms.TextBox txtOppervlak;
        private System.Windows.Forms.TextBox txtOmtrek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

