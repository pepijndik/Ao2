namespace dierentuin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstbox = new System.Windows.Forms.ListBox();
            this.excute = new System.Windows.Forms.Button();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtGeluid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Geluid";
            // 
            // lstbox
            // 
            this.lstbox.FormattingEnabled = true;
            this.lstbox.ItemHeight = 16;
            this.lstbox.Location = new System.Drawing.Point(259, 193);
            this.lstbox.Name = "lstbox";
            this.lstbox.Size = new System.Drawing.Size(279, 260);
            this.lstbox.TabIndex = 2;
            // 
            // excute
            // 
            this.excute.Location = new System.Drawing.Point(377, 164);
            this.excute.Name = "excute";
            this.excute.Size = new System.Drawing.Size(75, 23);
            this.excute.TabIndex = 3;
            this.excute.Text = "voer uit";
            this.excute.UseVisualStyleBackColor = true;
            this.excute.Click += new System.EventHandler(this.excute_Click);
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(259, 119);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(100, 22);
            this.txtNaam.TabIndex = 4;
            // 
            // txtGeluid
            // 
            this.txtGeluid.Location = new System.Drawing.Point(259, 165);
            this.txtGeluid.Name = "txtGeluid";
            this.txtGeluid.Size = new System.Drawing.Size(100, 22);
            this.txtGeluid.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGeluid);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.excute);
            this.Controls.Add(this.lstbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstbox;
        private System.Windows.Forms.Button excute;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtGeluid;
    }
}

