namespace Klassni_rukovodilel_.klass
{
    partial class FormKlas9
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonPoisk = new System.Windows.Forms.Button();
            this.students5DataGridView = new System.Windows.Forms.DataGridView();
            this.idstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idschoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idklassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namestudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameparentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passerialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pasnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.students9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klassRukDataSet = new Klassni_rukovodilel_.KlassRukDataSet();
            this.students9TableAdapter = new Klassni_rukovodilel_.KlassRukDataSetTableAdapters.students9TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.students5DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students9BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassRukDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(51, 507);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 67);
            this.button4.TabIndex = 64;
            this.button4.Text = "Родители";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(256, 507);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 67);
            this.button3.TabIndex = 63;
            this.button3.Text = "Сводная ведомость";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(463, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 67);
            this.button2.TabIndex = 62;
            this.button2.Text = "Карта здоровья";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(696, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 67);
            this.button1.TabIndex = 61;
            this.button1.Text = "Посещаемость";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(1167, 507);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(187, 67);
            this.buttonBack.TabIndex = 60;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonPoisk
            // 
            this.buttonPoisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonPoisk.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPoisk.Location = new System.Drawing.Point(931, 507);
            this.buttonPoisk.Name = "buttonPoisk";
            this.buttonPoisk.Size = new System.Drawing.Size(216, 67);
            this.buttonPoisk.TabIndex = 59;
            this.buttonPoisk.Text = "Редактировать";
            this.buttonPoisk.UseVisualStyleBackColor = false;
            this.buttonPoisk.Click += new System.EventHandler(this.buttonPoisk_Click);
            // 
            // students5DataGridView
            // 
            this.students5DataGridView.AutoGenerateColumns = false;
            this.students5DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.students5DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.students5DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstudentDataGridViewTextBoxColumn,
            this.idschoolDataGridViewTextBoxColumn,
            this.idklassDataGridViewTextBoxColumn,
            this.namestudentDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.polDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.nameparentDataGridViewTextBoxColumn,
            this.passerialDataGridViewTextBoxColumn,
            this.pasnumberDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn});
            this.students5DataGridView.DataSource = this.students9BindingSource;
            this.students5DataGridView.Location = new System.Drawing.Point(-5, -1);
            this.students5DataGridView.Name = "students5DataGridView";
            this.students5DataGridView.RowHeadersWidth = 51;
            this.students5DataGridView.RowTemplate.Height = 24;
            this.students5DataGridView.Size = new System.Drawing.Size(1372, 468);
            this.students5DataGridView.TabIndex = 58;
            // 
            // idstudentDataGridViewTextBoxColumn
            // 
            this.idstudentDataGridViewTextBoxColumn.DataPropertyName = "id_student";
            this.idstudentDataGridViewTextBoxColumn.HeaderText = "id_student";
            this.idstudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idstudentDataGridViewTextBoxColumn.Name = "idstudentDataGridViewTextBoxColumn";
            this.idstudentDataGridViewTextBoxColumn.Width = 103;
            // 
            // idschoolDataGridViewTextBoxColumn
            // 
            this.idschoolDataGridViewTextBoxColumn.DataPropertyName = "id_school";
            this.idschoolDataGridViewTextBoxColumn.HeaderText = "id_school";
            this.idschoolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idschoolDataGridViewTextBoxColumn.Name = "idschoolDataGridViewTextBoxColumn";
            this.idschoolDataGridViewTextBoxColumn.Width = 97;
            // 
            // idklassDataGridViewTextBoxColumn
            // 
            this.idklassDataGridViewTextBoxColumn.DataPropertyName = "id_klass";
            this.idklassDataGridViewTextBoxColumn.HeaderText = "id_klass";
            this.idklassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idklassDataGridViewTextBoxColumn.Name = "idklassDataGridViewTextBoxColumn";
            this.idklassDataGridViewTextBoxColumn.Width = 88;
            // 
            // namestudentDataGridViewTextBoxColumn
            // 
            this.namestudentDataGridViewTextBoxColumn.DataPropertyName = "name_student";
            this.namestudentDataGridViewTextBoxColumn.HeaderText = "name_student";
            this.namestudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namestudentDataGridViewTextBoxColumn.Name = "namestudentDataGridViewTextBoxColumn";
            this.namestudentDataGridViewTextBoxColumn.Width = 127;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "birthday";
            this.birthdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.Width = 88;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 73;
            // 
            // polDataGridViewTextBoxColumn
            // 
            this.polDataGridViewTextBoxColumn.DataPropertyName = "pol";
            this.polDataGridViewTextBoxColumn.HeaderText = "pol";
            this.polDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.polDataGridViewTextBoxColumn.Name = "polDataGridViewTextBoxColumn";
            this.polDataGridViewTextBoxColumn.Width = 56;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.Width = 133;
            // 
            // nameparentDataGridViewTextBoxColumn
            // 
            this.nameparentDataGridViewTextBoxColumn.DataPropertyName = "name_parent";
            this.nameparentDataGridViewTextBoxColumn.HeaderText = "name_parent";
            this.nameparentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameparentDataGridViewTextBoxColumn.Name = "nameparentDataGridViewTextBoxColumn";
            this.nameparentDataGridViewTextBoxColumn.Width = 121;
            // 
            // passerialDataGridViewTextBoxColumn
            // 
            this.passerialDataGridViewTextBoxColumn.DataPropertyName = "pas_serial";
            this.passerialDataGridViewTextBoxColumn.HeaderText = "pas_serial";
            this.passerialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passerialDataGridViewTextBoxColumn.Name = "passerialDataGridViewTextBoxColumn";
            this.passerialDataGridViewTextBoxColumn.Width = 102;
            // 
            // pasnumberDataGridViewTextBoxColumn
            // 
            this.pasnumberDataGridViewTextBoxColumn.DataPropertyName = "pas_number";
            this.pasnumberDataGridViewTextBoxColumn.HeaderText = "pas_number";
            this.pasnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pasnumberDataGridViewTextBoxColumn.Name = "pasnumberDataGridViewTextBoxColumn";
            this.pasnumberDataGridViewTextBoxColumn.Width = 116;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Width = 86;
            // 
            // students9BindingSource
            // 
            this.students9BindingSource.DataMember = "students9";
            this.students9BindingSource.DataSource = this.klassRukDataSet;
            // 
            // klassRukDataSet
            // 
            this.klassRukDataSet.DataSetName = "KlassRukDataSet";
            this.klassRukDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // students9TableAdapter
            // 
            this.students9TableAdapter.ClearBeforeFill = true;
            // 
            // FormKlas9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 581);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonPoisk);
            this.Controls.Add(this.students5DataGridView);
            this.Name = "FormKlas9";
            this.Text = "9 Класс ";
            this.Load += new System.EventHandler(this.FormKlas9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.students5DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students9BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassRukDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonPoisk;
        private System.Windows.Forms.DataGridView students5DataGridView;
        private KlassRukDataSet klassRukDataSet;
        private System.Windows.Forms.BindingSource students9BindingSource;
        private KlassRukDataSetTableAdapters.students9TableAdapter students9TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idschoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namestudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameparentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passerialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pasnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
    }
}