using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klassni_rukovodilel_
{
    public partial class FormSchool : Form
    {
        public FormSchool()
        {
            InitializeComponent();
        }

        private void schoolBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.schoolBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormSchool_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.Klass_ruk". При необходимости она может быть перемещена или удалена.
            this.klass_rukTableAdapter.Fill(this.klassRukDataSet.Klass_ruk);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.school". При необходимости она может быть перемещена или удалена.
            this.schoolTableAdapter.Fill(this.klassRukDataSet.school);

           
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form me = new FormMenu();
            me.Left = this.Left;
            me.Top = this.Top;
            me.Show();
            this.Hide();
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            MessageBox.Show("Запись удалена из базы данных");
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            klass_rukTableAdapter.Update(klassRukDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRukEdit re = new FormRukEdit();
            re.Left = this.Left;
            re.Top = this.Top;
            re.Show();
            this.Hide();
        }


    }
}
