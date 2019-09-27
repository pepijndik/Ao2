namespace Opdracht5
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnsom = new System.Windows.Forms.Button();
            this.btnavg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(60, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(566, 292);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // btnsom
            // 
            this.btnsom.Location = new System.Drawing.Point(294, 42);
            this.btnsom.Name = "btnsom";
            this.btnsom.Size = new System.Drawing.Size(75, 23);
            this.btnsom.TabIndex = 1;
            this.btnsom.Text = "SOM";
            this.btnsom.UseVisualStyleBackColor = true;
            this.btnsom.Click += new System.EventHandler(this.Btnsom_Click);
            // 
            // btnavg
            // 
            this.btnavg.Location = new System.Drawing.Point(396, 42);
            this.btnavg.Name = "btnavg";
            this.btnavg.Size = new System.Drawing.Size(75, 23);
            this.btnavg.TabIndex = 2;
            this.btnavg.Text = "AVG";
            this.btnavg.UseVisualStyleBackColor = true;
            this.btnavg.Click += new System.EventHandler(this.Btnavg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnavg);
            this.Controls.Add(this.btnsom);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnsom;
        private System.Windows.Forms.Button btnavg;
    }
}

