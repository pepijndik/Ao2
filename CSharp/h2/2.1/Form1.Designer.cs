namespace _2._1
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
            this.lstBox = new System.Windows.Forms.ListBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 16;
            this.lstBox.Location = new System.Drawing.Point(164, 86);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(454, 212);
            this.lstBox.TabIndex = 0;
            this.lstBox.SelectedIndexChanged += new System.EventHandler(this.LstBox_SelectedIndexChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(199, 52);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(123, 28);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "laag naar hoog";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(412, 52);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(140, 28);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "hoog naar laag";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lstBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
    }
}

