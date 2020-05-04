namespace Klassni_rukovodilel_
{
    partial class FormVneurochnaya
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
            this.klassRukDataSet = new Klassni_rukovodilel_.KlassRukDataSet();
            this.vneurochnaya_deyatelnost_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vneurochnaya_deyatelnost_TableAdapter = new Klassni_rukovodilel_.KlassRukDataSetTableAdapters.vneurochnaya_deyatelnost_TableAdapter();
            this.tableAdapterManager = new Klassni_rukovodilel_.KlassRukDataSetTableAdapters.TableAdapterManager();
            this.vneurochnaya_deyatelnost_DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDellete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.klassRukDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vneurochnaya_deyatelnost_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vneurochnaya_deyatelnost_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // klassRukDataSet
            // 
            this.klassRukDataSet.DataSetName = "KlassRukDataSet";
            this.klassRukDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vneurochnaya_deyatelnost_BindingSource
            // 
            this.vneurochnaya_deyatelnost_BindingSource.DataMember = "vneurochnaya_deyatelnost\'";
            this.vneurochnaya_deyatelnost_BindingSource.DataSource = this.klassRukDataSet;
            // 
            // vneurochnaya_deyatelnost_TableAdapter
            // 
            this.vneurochnaya_deyatelnost_TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InstruktionTableAdapter = null;
            this.tableAdapterManager.karta_health5TableAdapter = null;
            this.tableAdapterManager.karta_health6TableAdapter = null;
            this.tableAdapterManager.karta_health7TableAdapter = null;
            this.tableAdapterManager.karta_health8TableAdapter = null;
            this.tableAdapterManager.karta_health9TableAdapter = null;
            this.tableAdapterManager.karta_healthTableAdapter = null;
            this.tableAdapterManager.klass_chasiTableAdapter = null;
            this.tableAdapterManager.Klass_rukTableAdapter = null;
            this.tableAdapterManager.posechaemost_TableAdapter = null;
            this.tableAdapterManager.posechaemost5TableAdapter = null;
            this.tableAdapterManager.posechaemost6TableAdapter = null;
            this.tableAdapterManager.posechaemost7TableAdapter = null;
            this.tableAdapterManager.posechaemost8TableAdapter = null;
            this.tableAdapterManager.posechaemost9TableAdapter = null;
            this.tableAdapterManager.predmetTableAdapter = null;
            this.tableAdapterManager.roditeli5TableAdapter = null;
            this.tableAdapterManager.roditeli6TableAdapter = null;
            this.tableAdapterManager.roditeli7TableAdapter = null;
            this.tableAdapterManager.roditeli8TableAdapter = null;
            this.tableAdapterManager.roditeli9TableAdapter = null;
            this.tableAdapterManager.roditeliTableAdapter = null;
            this.tableAdapterManager.schoolTableAdapter = null;
            this.tableAdapterManager.students5TableAdapter = null;
            this.tableAdapterManager.students6TableAdapter = null;
            this.tableAdapterManager.students7TableAdapter = null;
            this.tableAdapterManager.students8TableAdapter = null;
            this.tableAdapterManager.students9TableAdapter = null;
            this.tableAdapterManager.studentsTableAdapter = null;
            this.tableAdapterManager.svodnaya_vedomost5kTableAdapter = null;
            this.tableAdapterManager.svodnaya_vedomost6kTableAdapter = null;
            this.tableAdapterManager.svodnaya_vedomost7kTableAdapter = null;
            this.tableAdapterManager.svodnaya_vedomost8kTableAdapter = null;
            this.tableAdapterManager.svodnaya_vedomost9kTableAdapter = null;
            this.tableAdapterManager.svodnaya_vedomostTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Klassni_rukovodilel_.KlassRukDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.vneurochnaya_deyatelnost_TableAdapter = this.vneurochnaya_deyatelnost_TableAdapter;
            this.tableAdapterManager.zhurnal_TBTableAdapter = null;
            // 
            // vneurochnaya_deyatelnost_DataGridView
            // 
            this.vneurochnaya_deyatelnost_DataGridView.AutoGenerateColumns = false;
            this.vneurochnaya_deyatelnost_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vneurochnaya_deyatelnost_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.vneurochnaya_deyatelnost_DataGridView.DataSource = this.vneurochnaya_deyatelnost_BindingSource;
            this.vneurochnaya_deyatelnost_DataGridView.Location = new System.Drawing.Point(283, 52);
            this.vneurochnaya_deyatelnost_DataGridView.Name = "vneurochnaya_deyatelnost_DataGridView";
            this.vneurochnaya_deyatelnost_DataGridView.RowHeadersWidth = 51;
            this.vneurochnaya_deyatelnost_DataGridView.RowTemplate.Height = 24;
            this.vneurochnaya_deyatelnost_DataGridView.Size = new System.Drawing.Size(405, 321);
            this.vneurochnaya_deyatelnost_DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_student";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_student";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name_kruzhka";
            this.dataGridViewTextBoxColumn2.HeaderText = "name_kruzhka";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // buttonDellete
            // 
            this.buttonDellete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDellete.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDellete.Location = new System.Drawing.Point(372, 451);
            this.buttonDellete.Name = "buttonDellete";
            this.buttonDellete.Size = new System.Drawing.Size(216, 67);
            this.buttonDellete.TabIndex = 60;
            this.buttonDellete.Text = "Удалить";
            this.buttonDellete.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(41, 451);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(216, 67);
            this.buttonSave.TabIndex = 59;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(709, 451);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(187, 67);
            this.buttonBack.TabIndex = 58;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // FormVneurochnaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 557);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.vneurochnaya_deyatelnost_DataGridView);
            this.Name = "FormVneurochnaya";
            this.Text = "FormVneurochnaya";
            this.Load += new System.EventHandler(this.FormVneurochnaya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klassRukDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vneurochnaya_deyatelnost_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vneurochnaya_deyatelnost_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private KlassRukDataSet klassRukDataSet;
        private System.Windows.Forms.BindingSource vneurochnaya_deyatelnost_BindingSource;
        private KlassRukDataSetTableAdapters.vneurochnaya_deyatelnost_TableAdapter vneurochnaya_deyatelnost_TableAdapter;
        private KlassRukDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vneurochnaya_deyatelnost_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonDellete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
    }
}