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
            this.txt_lengte = new System.Windows.Forms.TextBox();
            this.txt_breedte = new System.Windows.Forms.TextBox();
            this.btn_bereken = new System.Windows.Forms.Button();
            this.txt_Oppervlak = new System.Windows.Forms.TextBox();
            this.txt_Omtrek = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_lengte
            // 
            this.txt_lengte.Location = new System.Drawing.Point(396, 114);
            this.txt_lengte.Name = "txt_lengte";
            this.txt_lengte.Size = new System.Drawing.Size(100, 22);
            this.txt_lengte.TabIndex = 0;
            // 
            // txt_breedte
            // 
            this.txt_breedte.Location = new System.Drawing.Point(396, 159);
            this.txt_breedte.Name = "txt_breedte";
            this.txt_breedte.Size = new System.Drawing.Size(100, 22);
            this.txt_breedte.TabIndex = 1;
            // 
            // btn_bereken
            // 
            this.btn_bereken.Location = new System.Drawing.Point(396, 205);
            this.btn_bereken.Name = "btn_bereken";
            this.btn_bereken.Size = new System.Drawing.Size(75, 23);
            this.btn_bereken.TabIndex = 2;
            this.btn_bereken.Text = "Bereken";
            this.btn_bereken.UseVisualStyleBackColor = true;
            this.btn_bereken.Click += new System.EventHandler(this.btn_bereken_Click);
            // 
            // txt_Oppervlak
            // 
            this.txt_Oppervlak.Location = new System.Drawing.Point(396, 247);
            this.txt_Oppervlak.Name = "txt_Oppervlak";
            this.txt_Oppervlak.ReadOnly = true;
            this.txt_Oppervlak.Size = new System.Drawing.Size(100, 22);
            this.txt_Oppervlak.TabIndex = 3;
            // 
            // txt_Omtrek
            // 
            this.txt_Omtrek.Location = new System.Drawing.Point(396, 275);
            this.txt_Omtrek.Name = "txt_Omtrek";
            this.txt_Omtrek.ReadOnly = true;
            this.txt_Omtrek.Size = new System.Drawing.Size(100, 22);
            this.txt_Omtrek.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Omtrek);
            this.Controls.Add(this.txt_Oppervlak);
            this.Controls.Add(this.btn_bereken);
            this.Controls.Add(this.txt_breedte);
            this.Controls.Add(this.txt_lengte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_lengte;
        private System.Windows.Forms.TextBox txt_breedte;
        private System.Windows.Forms.Button btn_bereken;
        private System.Windows.Forms.TextBox txt_Oppervlak;
        private System.Windows.Forms.TextBox txt_Omtrek;
    }
}

