namespace Uitleensysteem
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
            this.dgrid = new System.Windows.Forms.DataGridView();
            this.dgrid2 = new System.Windows.Forms.DataGridView();
            this.txt_dvds = new System.Windows.Forms.TextBox();
            this.txt_arsort = new System.Windows.Forms.TextBox();
            this.txt_klant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid
            // 
            this.dgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid.Location = new System.Drawing.Point(12, 12);
            this.dgrid.Name = "dgrid";
            this.dgrid.RowHeadersWidth = 51;
            this.dgrid.RowTemplate.Height = 24;
            this.dgrid.Size = new System.Drawing.Size(653, 206);
            this.dgrid.TabIndex = 0;
            // 
            // dgrid2
            // 
            this.dgrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid2.Location = new System.Drawing.Point(12, 254);
            this.dgrid2.Name = "dgrid2";
            this.dgrid2.RowHeadersWidth = 51;
            this.dgrid2.RowTemplate.Height = 24;
            this.dgrid2.Size = new System.Drawing.Size(653, 174);
            this.dgrid2.TabIndex = 1;
            this.dgrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid2_CellContentClick);
            // 
            // txt_dvds
            // 
            this.txt_dvds.Location = new System.Drawing.Point(848, 38);
            this.txt_dvds.Name = "txt_dvds";
            this.txt_dvds.ReadOnly = true;
            this.txt_dvds.Size = new System.Drawing.Size(100, 22);
            this.txt_dvds.TabIndex = 2;
            // 
            // txt_arsort
            // 
            this.txt_arsort.Location = new System.Drawing.Point(848, 86);
            this.txt_arsort.Name = "txt_arsort";
            this.txt_arsort.ReadOnly = true;
            this.txt_arsort.Size = new System.Drawing.Size(100, 22);
            this.txt_arsort.TabIndex = 3;
            // 
            // txt_klant
            // 
            this.txt_klant.Location = new System.Drawing.Point(848, 129);
            this.txt_klant.Name = "txt_klant";
            this.txt_klant.ReadOnly = true;
            this.txt_klant.Size = new System.Drawing.Size(100, 22);
            this.txt_klant.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(671, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "aantal uitgeleende dvds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "aantal dvs in arsortiment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(671, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aantal klanten";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 543);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_klant);
            this.Controls.Add(this.txt_arsort);
            this.Controls.Add(this.txt_dvds);
            this.Controls.Add(this.dgrid2);
            this.Controls.Add(this.dgrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid;
        private System.Windows.Forms.DataGridView dgrid2;
        private System.Windows.Forms.TextBox txt_dvds;
        private System.Windows.Forms.TextBox txt_arsort;
        private System.Windows.Forms.TextBox txt_klant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

