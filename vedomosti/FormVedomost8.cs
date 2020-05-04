using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klassni_rukovodilel_.vedomosti
{
    public partial class FormVedomost8 : Form
    {
        public FormVedomost8()
        {
            InitializeComponent();
        }

        private void svodnaya_vedomost8kBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.svodnaya_vedomost8kBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormVedomost8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.svodnaya_vedomost8k". При необходимости она может быть перемещена или удалена.
            this.svodnaya_vedomost8kTableAdapter.Fill(this.klassRukDataSet.svodnaya_vedomost8k);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            svodnaya_vedomost8kTableAdapter.Update(klassRukDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            svodnaya_vedomost8kDataGridView.Rows.RemoveAt(svodnaya_vedomost8kDataGridView.CurrentCell.RowIndex);
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
