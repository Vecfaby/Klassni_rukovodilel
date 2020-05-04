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
    public partial class FormPosechaemost8 : Form
    {
        public FormPosechaemost8()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            posechaemost8TableAdapter.Update(klassRukDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void posechaemost8BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.posechaemost8BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormPosechaemost8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.posechaemost8". При необходимости она может быть перемещена или удалена.
            this.posechaemost8TableAdapter.Fill(this.klassRukDataSet.posechaemost8);

        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            posechaemost8DataGridView.Rows.RemoveAt(posechaemost8DataGridView.CurrentCell.RowIndex);
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
