namespace Klassni_rukovodilel_.инструкции
{
    partial class FormEditInst
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
            this.instruktionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instruktionTableAdapter = new Klassni_rukovodilel_.KlassRukDataSetTableAdapters.InstruktionTableAdapter();
            this.tableAdapterManager = new Klassni_rukovodilel_.KlassRukDataSetTableAdapters.TableAdapterManager();
            this.zhurnal_TBTableAdapter = new Klassni_rukovodilel_.KlassRukDataSetTableAdapters.zhurnal_TBTableAdapter();
            this.zhurnal_TBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zhurnal_TBDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonDellete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.klassRukDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhurnal_TBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhurnal_TBDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // klassRukDataSet
            // 
            this.klassRukDataSet.DataSetName = "KlassRukDataSet";
            this.klassRukDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instruktionBindingSource
            // 
            this.instruktionBindingSource.DataMember = "Instruktion";
            this.instruktionBindingSource.DataSource = this.klassRukDataSet;
            // 
            // instruktionTableAdapter
            // 
            this.instruktionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InstruktionTableAdapter = this.instruktionTableAdapter;
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
            this.tableAdapterManager.rukiTableAdapter = null;
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
            this.tableAdapterManager.vneurochnaya_deyatelnost_TableAdapter = null;
            this.tableAdapterManager.zhurnal_TBTableAdapter = this.zhurnal_TBTableAdapter;
            // 
            // zhurnal_TBTableAdapter
            // 
            this.zhurnal_TBTableAdapter.ClearBeforeFill = true;
            // 
            // zhurnal_TBBindingSource
            // 
            this.zhurnal_TBBindingSource.DataMember = "zhurnal_TB";
            this.zhurnal_TBBindingSource.DataSource = this.klassRukDataSet;
            // 
            // zhurnal_TBDataGridView
            // 
            this.zhurnal_TBDataGridView.AutoGenerateColumns = false;
            this.zhurnal_TBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zhurnal_TBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.zhurnal_TBDataGridView.DataSource = this.zhurnal_TBBindingSource;
            this.zhurnal_TBDataGridView.Location = new System.Drawing.Point(431, 12);
            this.zhurnal_TBDataGridView.Name = "zhurnal_TBDataGridView";
            this.zhurnal_TBDataGridView.RowHeadersWidth = 51;
            this.zhurnal_TBDataGridView.RowTemplate.Height = 24;
            this.zhurnal_TBDataGridView.Size = new System.Drawing.Size(459, 372);
            this.zhurnal_TBDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_instruk";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_instruk";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "date_instruk";
            this.dataGridViewTextBoxColumn2.HeaderText = "date_instruk";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_klass";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_klass";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(521, 496);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 67);
            this.button4.TabIndex = 61;
            this.button4.Text = "Экспорт в Эксель";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonDellete
            // 
            this.buttonDellete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDellete.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDellete.Location = new System.Drawing.Point(787, 496);
            this.buttonDellete.Name = "buttonDellete";
            this.buttonDellete.Size = new System.Drawing.Size(216, 67);
            this.buttonDellete.TabIndex = 57;
            this.buttonDellete.Text = "Удалить";
            this.buttonDellete.UseVisualStyleBackColor = false;
            this.buttonDellete.Click += new System.EventHandler(this.buttonDellete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(220, 496);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(216, 67);
            this.buttonSave.TabIndex = 55;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(1124, 496);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(187, 67);
            this.buttonBack.TabIndex = 54;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormEditInst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 573);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.zhurnal_TBDataGridView);
            this.Name = "FormEditInst";
            this.Text = "FormEditInst";
            this.Load += new System.EventHandler(this.FormEditInst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klassRukDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhurnal_TBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhurnal_TBDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private KlassRukDataSet klassRukDataSet;
        private System.Windows.Forms.BindingSource instruktionBindingSource;
        private KlassRukDataSetTableAdapters.InstruktionTableAdapter instruktionTableAdapter;
        private KlassRukDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private KlassRukDataSetTableAdapters.zhurnal_TBTableAdapter zhurnal_TBTableAdapter;
        private System.Windows.Forms.BindingSource zhurnal_TBBindingSource;
        private System.Windows.Forms.DataGridView zhurnal_TBDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonDellete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
    }
}