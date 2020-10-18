namespace ToetsCBS
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
            this.lbxVoertuigenoverzicht = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxVoertuigenoverzicht
            // 
            this.lbxVoertuigenoverzicht.FormattingEnabled = true;
            this.lbxVoertuigenoverzicht.Location = new System.Drawing.Point(6, 47);
            this.lbxVoertuigenoverzicht.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxVoertuigenoverzicht.Name = "lbxVoertuigenoverzicht";
            this.lbxVoertuigenoverzicht.Size = new System.Drawing.Size(736, 329);
            this.lbxVoertuigenoverzicht.TabIndex = 0;
            this.lbxVoertuigenoverzicht.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 404);
            this.Controls.Add(this.lbxVoertuigenoverzicht);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxVoertuigenoverzicht;
    }
}

