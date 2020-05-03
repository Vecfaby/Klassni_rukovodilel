namespace Klassni_rukovodilel_.инструкции
{
    partial class FormZhurnal
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
            this.zhurnal_TBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zhurnal_TBTableAdapter = new Klassni_rukovodilel_.KlassRukDataSetTableAdapters.zhurnal_TBTableAdapter();
            this.tableAdapterManager = new Klassni_rukovodilel_.KlassRukDataSetTableAdapters.TableAdapterManager();
            this.instruktionTableAdapter = new Klassni_rukovodilel_.KlassRukDataSetTableAdapters.InstruktionTableAdapter();
            this.instruktionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKzhurnalTBInstruktionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKzhurnalTBInstruktionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKzhurnalTBInstruktionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.instruktionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idinstrukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateinstrukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idklassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKzhurnalTBInstruktionBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.klassRukDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhurnal_TBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKzhurnalTBInstruktionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKzhurnalTBInstruktionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKzhurnalTBInstruktionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKzhurnalTBInstruktionBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // klassRukDataSet
            // 
            this.klassRukDataSet.DataSetName = "KlassRukDataSet";
            this.klassRukDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zhurnal_TBBindingSource
            // 
            this.zhurnal_TBBindingSource.DataMember = "zhurnal_TB";
            this.zhurnal_TBBindingSource.DataSource = this.klassRukDataSet;
            // 
            // zhurnal_TBTableAdapter
            // 
            this.zhurnal_TBTableAdapter.ClearBeforeFill = true;
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
            // instruktionTableAdapter
            // 
            this.instruktionTableAdapter.ClearBeforeFill = true;
            // 
            // instruktionBindingSource
            // 
            this.instruktionBindingSource.DataMember = "Instruktion";
            this.instruktionBindingSource.DataSource = this.klassRukDataSet;
            // 
            // fKzhurnalTBInstruktionBindingSource
            // 
            this.fKzhurnalTBInstruktionBindingSource.DataMember = "FK_zhurnal_TB_Instruktion";
            this.fKzhurnalTBInstruktionBindingSource.DataSource = this.instruktionBindingSource;
            // 
            // fKzhurnalTBInstruktionBindingSource1
            // 
            this.fKzhurnalTBInstruktionBindingSource1.DataMember = "FK_zhurnal_TB_Instruktion";
            this.fKzhurnalTBInstruktionBindingSource1.DataSource = this.instruktionBindingSource;
            // 
            // fKzhurnalTBInstruktionBindingSource2
            // 
            this.fKzhurnalTBInstruktionBindingSource2.DataMember = "FK_zhurnal_TB_Instruktion";
            this.fKzhurnalTBInstruktionBindingSource2.DataSource = this.instruktionBindingSource;
            // 
            // instruktionDataGridView
            // 
            this.instruktionDataGridView.AutoGenerateColumns = false;
            this.instruktionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instruktionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.instruktionDataGridView.DataSource = this.instruktionBindingSource;
            this.instruktionDataGridView.Location = new System.Drawing.Point(197, 39);
            this.instruktionDataGridView.Name = "instruktionDataGridView";
            this.instruktionDataGridView.RowHeadersWidth = 51;
            this.instruktionDataGridView.RowTemplate.Height = 24;
            this.instruktionDataGridView.Size = new System.Drawing.Size(454, 337);
            this.instruktionDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_instruk";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_instruk";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "number_instruk";
            this.dataGridViewTextBoxColumn3.HeaderText = "number_instruk";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "name_instruk";
            this.dataGridViewTextBoxColumn4.HeaderText = "name_instruk";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idinstrukDataGridViewTextBoxColumn,
            this.dateinstrukDataGridViewTextBoxColumn,
            this.idklassDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKzhurnalTBInstruktionBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(768, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(454, 337);
            this.dataGridView1.TabIndex = 2;
            // 
            // idinstrukDataGridViewTextBoxColumn
            // 
            this.idinstrukDataGridViewTextBoxColumn.DataPropertyName = "id_instruk";
            this.idinstrukDataGridViewTextBoxColumn.HeaderText = "id_instruk";
            this.idinstrukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idinstrukDataGridViewTextBoxColumn.Name = "idinstrukDataGridViewTextBoxColumn";
            this.idinstrukDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateinstrukDataGridViewTextBoxColumn
            // 
            this.dateinstrukDataGridViewTextBoxColumn.DataPropertyName = "date_instruk";
            this.dateinstrukDataGridViewTextBoxColumn.HeaderText = "date_instruk";
            this.dateinstrukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateinstrukDataGridViewTextBoxColumn.Name = "dateinstrukDataGridViewTextBoxColumn";
            this.dateinstrukDataGridViewTextBoxColumn.Width = 125;
            // 
            // idklassDataGridViewTextBoxColumn
            // 
            this.idklassDataGridViewTextBoxColumn.DataPropertyName = "id_klass";
            this.idklassDataGridViewTextBoxColumn.HeaderText = "id_klass";
            this.idklassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idklassDataGridViewTextBoxColumn.Name = "idklassDataGridViewTextBoxColumn";
            this.idklassDataGridViewTextBoxColumn.Width = 125;
            // 
            // fKzhurnalTBInstruktionBindingSource3
            // 
            this.fKzhurnalTBInstruktionBindingSource3.DataMember = "FK_zhurnal_TB_Instruktion";
            this.fKzhurnalTBInstruktionBindingSource3.DataSource = this.instruktionBindingSource;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(768, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 58);
            this.button2.TabIndex = 45;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(1035, 449);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(187, 58);
            this.buttonBack.TabIndex = 44;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(459, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(529, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Выберите инструктаж для просмотра в каких классах он проведен";
            // 
            // FormZhurnal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 573);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.instruktionDataGridView);
            this.Name = "FormZhurnal";
            this.Text = "Журнал техники безопасности";
            this.Load += new System.EventHandler(this.FormZhurnal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klassRukDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zhurnal_TBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKzhurnalTBInstruktionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKzhurnalTBInstruktionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKzhurnalTBInstruktionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instruktionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKzhurnalTBInstruktionBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KlassRukDataSet klassRukDataSet;
        private System.Windows.Forms.BindingSource zhurnal_TBBindingSource;
        private KlassRukDataSetTableAdapters.zhurnal_TBTableAdapter zhurnal_TBTableAdapter;
        private KlassRukDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private KlassRukDataSetTableAdapters.InstruktionTableAdapter instruktionTableAdapter;
        private System.Windows.Forms.BindingSource instruktionBindingSource;
        private System.Windows.Forms.BindingSource fKzhurnalTBInstruktionBindingSource;
        private System.Windows.Forms.BindingSource fKzhurnalTBInstruktionBindingSource1;
        private System.Windows.Forms.BindingSource fKzhurnalTBInstruktionBindingSource2;
        private System.Windows.Forms.DataGridView instruktionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinstrukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateinstrukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklassDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKzhurnalTBInstruktionBindingSource3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label4;
    }
}