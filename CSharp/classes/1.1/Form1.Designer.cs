namespace _1._1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_bereken = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lstbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(345, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "geef Prijs";
            // 
            // btn_bereken
            // 
            this.btn_bereken.Location = new System.Drawing.Point(265, 123);
            this.btn_bereken.Name = "btn_bereken";
            this.btn_bereken.Size = new System.Drawing.Size(180, 23);
            this.btn_bereken.TabIndex = 2;
            this.btn_bereken.Text = "bereken Auto class";
            this.btn_bereken.UseVisualStyleBackColor = true;
            this.btn_bereken.Click += new System.EventHandler(this.btn_bereken_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "bereken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstbox
            // 
            this.lstbox.FormattingEnabled = true;
            this.lstbox.ItemHeight = 16;
            this.lstbox.Location = new System.Drawing.Point(268, 179);
            this.lstbox.Name = "lstbox";
            this.lstbox.Size = new System.Drawing.Size(271, 148);
            this.lstbox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_bereken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_bereken;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstbox;
    }
}

