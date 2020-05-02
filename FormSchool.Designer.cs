namespace Klassni_rukovodilel_
{
    partial class FormSchool
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
            this.schoolDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klassRukDataSet = new Klassni_rukovodilel_.KlassRukDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idklassrukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namerukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idklassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idshcoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_shcool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKKlassrukschool1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.schoolTableAdapter = new Klassni_rukovodilel_.KlassRukDataSetTableAdapters.schoolTableAdapter();
            this.tableAdapterManager = new Klassni_rukovodilel_.KlassRukDataSetTableAdapters.TableAdapterManager();
            this.klass_rukTableAdapter = new Klassni_rukovodilel_.KlassRukDataSetTableAdapters.Klass_rukTableAdapter();
            this.buttonDellete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassRukDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKKlassrukschool1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // schoolDataGridView
            // 
            this.schoolDataGridView.AutoGenerateColumns = false;
            this.schoolDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.schoolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schoolDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.schoolDataGridView.DataSource = this.schoolBindingSource;
            this.schoolDataGridView.Location = new System.Drawing.Point(12, 57);
            this.schoolDataGridView.Name = "schoolDataGridView";
            this.schoolDataGridView.RowHeadersWidth = 51;
            this.schoolDataGridView.RowTemplate.Height = 24;
            this.schoolDataGridView.Size = new System.Drawing.Size(319, 367);
            this.schoolDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name_school";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название школы";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 136;
            // 
            // schoolBindingSource
            // 
            this.schoolBindingSource.DataMember = "school";
            this.schoolBindingSource.DataSource = this.klassRukDataSet;
            // 
            // klassRukDataSet
            // 
            this.klassRukDataSet.DataSetName = "KlassRukDataSet";
            this.klassRukDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idklassrukDataGridViewTextBoxColumn,
            this.namerukDataGridViewTextBoxColumn,
            this.idklassDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.idshcoolDataGridViewTextBoxColumn,
            this.name_shcool});
            this.dataGridView1.DataSource = this.fKKlassrukschool1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(339, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1062, 367);
            this.dataGridView1.TabIndex = 2;
            // 
            // idklassrukDataGridViewTextBoxColumn
            // 
            this.idklassrukDataGridViewTextBoxColumn.DataPropertyName = "id_klass_ruk";
            this.idklassrukDataGridViewTextBoxColumn.HeaderText = "Номер кл. рук-ля";
            this.idklassrukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idklassrukDataGridViewTextBoxColumn.Name = "idklassrukDataGridViewTextBoxColumn";
            this.idklassrukDataGridViewTextBoxColumn.Width = 137;
            // 
            // namerukDataGridViewTextBoxColumn
            // 
            this.namerukDataGridViewTextBoxColumn.DataPropertyName = "name_ruk";
            this.namerukDataGridViewTextBoxColumn.HeaderText = "Полное имя";
            this.namerukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namerukDataGridViewTextBoxColumn.Name = "namerukDataGridViewTextBoxColumn";
            this.namerukDataGridViewTextBoxColumn.Width = 107;
            // 
            // idklassDataGridViewTextBoxColumn
            // 
            this.idklassDataGridViewTextBoxColumn.DataPropertyName = "id_klass";
            this.idklassDataGridViewTextBoxColumn.HeaderText = "Класс";
            this.idklassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idklassDataGridViewTextBoxColumn.Name = "idklassDataGridViewTextBoxColumn";
            this.idklassDataGridViewTextBoxColumn.Width = 76;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 97;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 77;
            // 
            // idshcoolDataGridViewTextBoxColumn
            // 
            this.idshcoolDataGridViewTextBoxColumn.DataPropertyName = "id_shcool";
            this.idshcoolDataGridViewTextBoxColumn.HeaderText = "Код школы";
            this.idshcoolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idshcoolDataGridViewTextBoxColumn.Name = "idshcoolDataGridViewTextBoxColumn";
            this.idshcoolDataGridViewTextBoxColumn.Width = 101;
            // 
            // name_shcool
            // 
            this.name_shcool.DataPropertyName = "name_shcool";
            this.name_shcool.HeaderText = "Название школы";
            this.name_shcool.MinimumWidth = 6;
            this.name_shcool.Name = "name_shcool";
            this.name_shcool.Width = 136;
            // 
            // fKKlassrukschool1BindingSource
            // 
            this.fKKlassrukschool1BindingSource.DataMember = "FK_Klass_ruk_school1";
            this.fKKlassrukschool1BindingSource.DataSource = this.schoolBindingSource;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(40, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(573, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Выберите школу для просмотра информации о классных руководителях";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(1195, 455);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(187, 58);
            this.buttonBack.TabIndex = 16;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // schoolTableAdapter
            // 
            this.schoolTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InstruktionTableAdapter = null;
            this.tableAdapterManager.karta_healthTableAdapter = null;
            this.tableAdapterManager.klass_chasiTableAdapter = null;
            this.tableAdapterManager.Klass_rukTableAdapter = this.klass_rukTableAdapter;
            this.tableAdapterManager.posechaemost_TableAdapter = null;
            this.tableAdapterManager.predmetTableAdapter = null;
            this.tableAdapterManager.roditeliTableAdapter = null;
            this.tableAdapterManager.schoolTableAdapter = this.schoolTableAdapter;
            this.tableAdapterManager.studentsTableAdapter = null;
            this.tableAdapterManager.svodnaya_vedomostTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Klassni_rukovodilel_.KlassRukDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.vneurochnaya_deyatelnost_TableAdapter = null;
            this.tableAdapterManager.zhurnal_TBTableAdapter = null;
            // 
            // klass_rukTableAdapter
            // 
            this.klass_rukTableAdapter.ClearBeforeFill = true;
            // 
            // buttonDellete
            // 
            this.buttonDellete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDellete.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDellete.Location = new System.Drawing.Point(895, 455);
            this.buttonDellete.Name = "buttonDellete";
            this.buttonDellete.Size = new System.Drawing.Size(216, 58);
            this.buttonDellete.TabIndex = 41;
            this.buttonDellete.Text = "Удалить";
            this.buttonDellete.UseVisualStyleBackColor = false;
            this.buttonDellete.Click += new System.EventHandler(this.buttonDellete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(594, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 58);
            this.button1.TabIndex = 39;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 535);
            this.Controls.Add(this.buttonDellete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.schoolDataGridView);
            this.Name = "FormSchool";
            this.Text = "FormSchool";
            this.Load += new System.EventHandler(this.FormSchool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassRukDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKKlassrukschool1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KlassRukDataSet klassRukDataSet;
        private System.Windows.Forms.BindingSource schoolBindingSource;
        private KlassRukDataSetTableAdapters.schoolTableAdapter schoolTableAdapter;
        private KlassRukDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView schoolDataGridView;
        private KlassRukDataSetTableAdapters.Klass_rukTableAdapter klass_rukTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fKKlassrukschool1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklassrukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namerukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idshcoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_shcool;
        private System.Windows.Forms.Button buttonDellete;
        private System.Windows.Forms.Button button1;
    }
}