namespace tekenen3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btndraw = new System.Windows.Forms.Button();
            this.txtStaal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(89, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 383);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(644, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vul de Straal in";
            // 
            // btndraw
            // 
            this.btndraw.Location = new System.Drawing.Point(647, 241);
            this.btndraw.Name = "btndraw";
            this.btndraw.Size = new System.Drawing.Size(133, 24);
            this.btndraw.TabIndex = 2;
            this.btndraw.Text = "Teken De circel";
            this.btndraw.UseVisualStyleBackColor = true;
            this.btndraw.Click += new System.EventHandler(this.Btndraw_Click);
            // 
            // txtStaal
            // 
            this.txtStaal.Location = new System.Drawing.Point(647, 213);
            this.txtStaal.Name = "txtStaal";
            this.txtStaal.Size = new System.Drawing.Size(100, 22);
            this.txtStaal.TabIndex = 3;
            this.txtStaal.TextChanged += new System.EventHandler(this.TxtStaal_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtStaal);
            this.Controls.Add(this.btndraw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndraw;
        private System.Windows.Forms.TextBox txtStaal;
    }
}

