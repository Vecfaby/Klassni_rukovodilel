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
    public partial class FormRoditeli7 : Form
    {
        public FormRoditeli7()
        {
            InitializeComponent();
        }

        private void roditeli7BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roditeli7BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormRoditeli7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.roditeli7". При необходимости она может быть перемещена или удалена.
            this.roditeli7TableAdapter.Fill(this.klassRukDataSet.roditeli7);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            roditeli7TableAdapter.Update(klassRukDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            roditeli7DataGridView.Rows.RemoveAt(roditeli7DataGridView.CurrentCell.RowIndex);
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
