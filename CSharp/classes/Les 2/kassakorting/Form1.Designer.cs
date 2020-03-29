namespace kassakorting
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtPrijs = new System.Windows.Forms.TextBox();
            this.txtKorting = new System.Windows.Forms.TextBox();
            this.prijs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "bereken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrijs
            // 
            this.txtPrijs.Location = new System.Drawing.Point(319, 136);
            this.txtPrijs.Name = "txtPrijs";
            this.txtPrijs.Size = new System.Drawing.Size(100, 22);
            this.txtPrijs.TabIndex = 1;
            // 
            // txtKorting
            // 
            this.txtKorting.Location = new System.Drawing.Point(319, 176);
            this.txtKorting.Name = "txtKorting";
            this.txtKorting.Size = new System.Drawing.Size(100, 22);
            this.txtKorting.TabIndex = 2;
            // 
            // prijs
            // 
            this.prijs.AutoSize = true;
            this.prijs.Location = new System.Drawing.Point(238, 136);
            this.prijs.Name = "prijs";
            this.prijs.Size = new System.Drawing.Size(34, 17);
            this.prijs.TabIndex = 3;
            this.prijs.Text = "prijs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Korting";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prijs);
            this.Controls.Add(this.txtKorting);
            this.Controls.Add(this.txtPrijs);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPrijs;
        private System.Windows.Forms.TextBox txtKorting;
        private System.Windows.Forms.Label prijs;
        private System.Windows.Forms.Label label1;
    }
}

