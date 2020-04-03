namespace BMI
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
            this.txt_gewicht = new System.Windows.Forms.TextBox();
            this.txt_lengte = new System.Windows.Forms.TextBox();
            this.txt_cat = new System.Windows.Forms.TextBox();
            this.txt_bmi = new System.Windows.Forms.TextBox();
            this.btn_excute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_gewicht
            // 
            this.txt_gewicht.Location = new System.Drawing.Point(399, 93);
            this.txt_gewicht.Name = "txt_gewicht";
            this.txt_gewicht.Size = new System.Drawing.Size(100, 22);
            this.txt_gewicht.TabIndex = 0;
            // 
            // txt_lengte
            // 
            this.txt_lengte.Location = new System.Drawing.Point(399, 121);
            this.txt_lengte.Name = "txt_lengte";
            this.txt_lengte.Size = new System.Drawing.Size(100, 22);
            this.txt_lengte.TabIndex = 1;
            // 
            // txt_cat
            // 
            this.txt_cat.Location = new System.Drawing.Point(399, 227);
            this.txt_cat.Name = "txt_cat";
            this.txt_cat.ReadOnly = true;
            this.txt_cat.Size = new System.Drawing.Size(100, 22);
            this.txt_cat.TabIndex = 3;
            // 
            // txt_bmi
            // 
            this.txt_bmi.Location = new System.Drawing.Point(399, 199);
            this.txt_bmi.Name = "txt_bmi";
            this.txt_bmi.ReadOnly = true;
            this.txt_bmi.Size = new System.Drawing.Size(100, 22);
            this.txt_bmi.TabIndex = 2;
            // 
            // btn_excute
            // 
            this.btn_excute.Location = new System.Drawing.Point(399, 162);
            this.btn_excute.Name = "btn_excute";
            this.btn_excute.Size = new System.Drawing.Size(100, 23);
            this.btn_excute.TabIndex = 4;
            this.btn_excute.Text = "bereken";
            this.btn_excute.UseVisualStyleBackColor = true;
            this.btn_excute.Click += new System.EventHandler(this.btn_excute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_excute);
            this.Controls.Add(this.txt_cat);
            this.Controls.Add(this.txt_bmi);
            this.Controls.Add(this.txt_lengte);
            this.Controls.Add(this.txt_gewicht);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_gewicht;
        private System.Windows.Forms.TextBox txt_lengte;
        private System.Windows.Forms.TextBox txt_cat;
        private System.Windows.Forms.TextBox txt_bmi;
        private System.Windows.Forms.Button btn_excute;
    }
}

