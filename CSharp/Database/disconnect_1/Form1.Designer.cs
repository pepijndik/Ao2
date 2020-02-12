namespace disconnect_1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vlindersDataSet = new disconnect_1.VlindersDataSet();
            this.vlindersDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familienamenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.familienamenTableAdapter = new disconnect_1.VlindersDataSetTableAdapters.FamilienamenTableAdapter();
            this.tableAdapterManager = new disconnect_1.VlindersDataSetTableAdapters.TableAdapterManager();
            this.vlindersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vlindersTableAdapter = new disconnect_1.VlindersDataSetTableAdapters.VlindersTableAdapter();
            this.vlinderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latijnseNaamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familienaamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vliegtijdStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vliegtijdEindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zeldzaamDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.afbeeldingDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.minimaleVoorvleugelGrootteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximaleVoorvleugelGrootteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opmerkingenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlindersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlindersDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familienamenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlindersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vlinderIdDataGridViewTextBoxColumn,
            this.naamDataGridViewTextBoxColumn,
            this.latijnseNaamDataGridViewTextBoxColumn,
            this.familienaamDataGridViewTextBoxColumn,
            this.vliegtijdStartDataGridViewTextBoxColumn,
            this.vliegtijdEindDataGridViewTextBoxColumn,
            this.waarDataGridViewTextBoxColumn,
            this.zeldzaamDataGridViewCheckBoxColumn,
            this.afbeeldingDataGridViewImageColumn,
            this.minimaleVoorvleugelGrootteDataGridViewTextBoxColumn,
            this.maximaleVoorvleugelGrootteDataGridViewTextBoxColumn,
            this.opmerkingenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vlindersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(735, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // vlindersDataSet
            // 
            this.vlindersDataSet.DataSetName = "VlindersDataSet";
            this.vlindersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vlindersDataSetBindingSource
            // 
            this.vlindersDataSetBindingSource.DataSource = this.vlindersDataSet;
            this.vlindersDataSetBindingSource.Position = 0;
            // 
            // familienamenBindingSource
            // 
            this.familienamenBindingSource.DataMember = "Familienamen";
            this.familienamenBindingSource.DataSource = this.vlindersDataSet;
            // 
            // familienamenTableAdapter
            // 
            this.familienamenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FamilienamenTableAdapter = this.familienamenTableAdapter;
            this.tableAdapterManager.UpdateOrder = disconnect_1.VlindersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VlindersTableAdapter = this.vlindersTableAdapter;
            // 
            // vlindersBindingSource
            // 
            this.vlindersBindingSource.DataMember = "Vlinders";
            this.vlindersBindingSource.DataSource = this.vlindersDataSet;
            // 
            // vlindersTableAdapter
            // 
            this.vlindersTableAdapter.ClearBeforeFill = true;
            // 
            // vlinderIdDataGridViewTextBoxColumn
            // 
            this.vlinderIdDataGridViewTextBoxColumn.DataPropertyName = "Vlinder-Id";
            this.vlinderIdDataGridViewTextBoxColumn.HeaderText = "Vlinder-Id";
            this.vlinderIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vlinderIdDataGridViewTextBoxColumn.Name = "vlinderIdDataGridViewTextBoxColumn";
            this.vlinderIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.vlinderIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // naamDataGridViewTextBoxColumn
            // 
            this.naamDataGridViewTextBoxColumn.DataPropertyName = "Naam";
            this.naamDataGridViewTextBoxColumn.HeaderText = "Naam";
            this.naamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.naamDataGridViewTextBoxColumn.Name = "naamDataGridViewTextBoxColumn";
            this.naamDataGridViewTextBoxColumn.ReadOnly = true;
            this.naamDataGridViewTextBoxColumn.Width = 125;
            // 
            // latijnseNaamDataGridViewTextBoxColumn
            // 
            this.latijnseNaamDataGridViewTextBoxColumn.DataPropertyName = "Latijnse naam";
            this.latijnseNaamDataGridViewTextBoxColumn.HeaderText = "Latijnse naam";
            this.latijnseNaamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.latijnseNaamDataGridViewTextBoxColumn.Name = "latijnseNaamDataGridViewTextBoxColumn";
            this.latijnseNaamDataGridViewTextBoxColumn.ReadOnly = true;
            this.latijnseNaamDataGridViewTextBoxColumn.Width = 125;
            // 
            // familienaamDataGridViewTextBoxColumn
            // 
            this.familienaamDataGridViewTextBoxColumn.DataPropertyName = "Familienaam";
            this.familienaamDataGridViewTextBoxColumn.HeaderText = "Familienaam";
            this.familienaamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.familienaamDataGridViewTextBoxColumn.Name = "familienaamDataGridViewTextBoxColumn";
            this.familienaamDataGridViewTextBoxColumn.ReadOnly = true;
            this.familienaamDataGridViewTextBoxColumn.Width = 125;
            // 
            // vliegtijdStartDataGridViewTextBoxColumn
            // 
            this.vliegtijdStartDataGridViewTextBoxColumn.DataPropertyName = "Vliegtijd start";
            this.vliegtijdStartDataGridViewTextBoxColumn.HeaderText = "Vliegtijd start";
            this.vliegtijdStartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vliegtijdStartDataGridViewTextBoxColumn.Name = "vliegtijdStartDataGridViewTextBoxColumn";
            this.vliegtijdStartDataGridViewTextBoxColumn.ReadOnly = true;
            this.vliegtijdStartDataGridViewTextBoxColumn.Width = 125;
            // 
            // vliegtijdEindDataGridViewTextBoxColumn
            // 
            this.vliegtijdEindDataGridViewTextBoxColumn.DataPropertyName = "Vliegtijd eind";
            this.vliegtijdEindDataGridViewTextBoxColumn.HeaderText = "Vliegtijd eind";
            this.vliegtijdEindDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vliegtijdEindDataGridViewTextBoxColumn.Name = "vliegtijdEindDataGridViewTextBoxColumn";
            this.vliegtijdEindDataGridViewTextBoxColumn.ReadOnly = true;
            this.vliegtijdEindDataGridViewTextBoxColumn.Width = 125;
            // 
            // waarDataGridViewTextBoxColumn
            // 
            this.waarDataGridViewTextBoxColumn.DataPropertyName = "Waar";
            this.waarDataGridViewTextBoxColumn.HeaderText = "Waar";
            this.waarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.waarDataGridViewTextBoxColumn.Name = "waarDataGridViewTextBoxColumn";
            this.waarDataGridViewTextBoxColumn.ReadOnly = true;
            this.waarDataGridViewTextBoxColumn.Width = 125;
            // 
            // zeldzaamDataGridViewCheckBoxColumn
            // 
            this.zeldzaamDataGridViewCheckBoxColumn.DataPropertyName = "Zeldzaam";
            this.zeldzaamDataGridViewCheckBoxColumn.HeaderText = "Zeldzaam";
            this.zeldzaamDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.zeldzaamDataGridViewCheckBoxColumn.Name = "zeldzaamDataGridViewCheckBoxColumn";
            this.zeldzaamDataGridViewCheckBoxColumn.ReadOnly = true;
            this.zeldzaamDataGridViewCheckBoxColumn.Width = 125;
            // 
            // afbeeldingDataGridViewImageColumn
            // 
            this.afbeeldingDataGridViewImageColumn.DataPropertyName = "Afbeelding";
            this.afbeeldingDataGridViewImageColumn.HeaderText = "Afbeelding";
            this.afbeeldingDataGridViewImageColumn.MinimumWidth = 6;
            this.afbeeldingDataGridViewImageColumn.Name = "afbeeldingDataGridViewImageColumn";
            this.afbeeldingDataGridViewImageColumn.ReadOnly = true;
            this.afbeeldingDataGridViewImageColumn.Width = 125;
            // 
            // minimaleVoorvleugelGrootteDataGridViewTextBoxColumn
            // 
            this.minimaleVoorvleugelGrootteDataGridViewTextBoxColumn.DataPropertyName = "Minimale voorvleugel grootte";
            this.minimaleVoorvleugelGrootteDataGridViewTextBoxColumn.HeaderText = "Minimale voorvleugel grootte";
            this.minimaleVoorvleugelGrootteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.minimaleVoorvleugelGrootteDataGridViewTextBoxColumn.Name = "minimaleVoorvleugelGrootteDataGridViewTextBoxColumn";
            this.minimaleVoorvleugelGrootteDataGridViewTextBoxColumn.ReadOnly = true;
            this.minimaleVoorvleugelGrootteDataGridViewTextBoxColumn.Width = 125;
            // 
            // maximaleVoorvleugelGrootteDataGridViewTextBoxColumn
            // 
            this.maximaleVoorvleugelGrootteDataGridViewTextBoxColumn.DataPropertyName = "Maximale voorvleugel grootte";
            this.maximaleVoorvleugelGrootteDataGridViewTextBoxColumn.HeaderText = "Maximale voorvleugel grootte";
            this.maximaleVoorvleugelGrootteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maximaleVoorvleugelGrootteDataGridViewTextBoxColumn.Name = "maximaleVoorvleugelGrootteDataGridViewTextBoxColumn";
            this.maximaleVoorvleugelGrootteDataGridViewTextBoxColumn.ReadOnly = true;
            this.maximaleVoorvleugelGrootteDataGridViewTextBoxColumn.Width = 125;
            // 
            // opmerkingenDataGridViewTextBoxColumn
            // 
            this.opmerkingenDataGridViewTextBoxColumn.DataPropertyName = "Opmerkingen";
            this.opmerkingenDataGridViewTextBoxColumn.HeaderText = "Opmerkingen";
            this.opmerkingenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opmerkingenDataGridViewTextBoxColumn.Name = "opmerkingenDataGridViewTextBoxColumn";
            this.opmerkingenDataGridViewTextBoxColumn.ReadOnly = true;
            this.opmerkingenDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlindersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlindersDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familienamenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlindersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vlindersDataSetBindingSource;
        private VlindersDataSet vlindersDataSet;
        private System.Windows.Forms.BindingSource familienamenBindingSource;
        private VlindersDataSetTableAdapters.FamilienamenTableAdapter familienamenTableAdapter;
        private VlindersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private VlindersDataSetTableAdapters.VlindersTableAdapter vlindersTableAdapter;
        private System.Windows.Forms.BindingSource vlindersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlinderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latijnseNaamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familienaamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vliegtijdStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vliegtijdEindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn zeldzaamDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn afbeeldingDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimaleVoorvleugelGrootteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximaleVoorvleugelGrootteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opmerkingenDataGridViewTextBoxColumn;
    }
}

