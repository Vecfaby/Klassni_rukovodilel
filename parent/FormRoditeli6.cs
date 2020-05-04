using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klassni_rukovodilel_.parent
{
    public partial class FormRoditeli6 : Form
    {
        public FormRoditeli6()
        {
            InitializeComponent();
        }

        private void roditeli6BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roditeli6BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormRoditeli6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.roditeli6". При необходимости она может быть перемещена или удалена.
            this.roditeli6TableAdapter.Fill(this.klassRukDataSet.roditeli6);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            roditeli6TableAdapter.Update(klassRukDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            roditeli6DataGridView.Rows.RemoveAt(roditeli6DataGridView.CurrentCell.RowIndex);
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormStudents stud = new FormStudents();
            stud.Left = this.Left;
            stud.Top = this.Top;
            stud.Show();
            this.Hide();
        }
    }
}
