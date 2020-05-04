using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klassni_rukovodilel_.posechaemost
{
    public partial class FormPosechaemost5 : Form
    {
        public FormPosechaemost5()
        {
            InitializeComponent();
        }

        private void posechaemost5BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.posechaemost5BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormPosechaemost5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.posechaemost5". При необходимости она может быть перемещена или удалена.
            this.posechaemost5TableAdapter.Fill(this.klassRukDataSet.posechaemost5);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            posechaemost5TableAdapter.Update(klassRukDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            posechaemost5DataGridView.Rows.RemoveAt(posechaemost5DataGridView.CurrentCell.RowIndex);
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
