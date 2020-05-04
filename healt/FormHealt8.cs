using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klassni_rukovodilel_.healt
{
    public partial class FormHealt8 : Form
    {
        public FormHealt8()
        {
            InitializeComponent();
        }

        private void karta_health8BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.karta_health8BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormHealt8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.karta_health8". При необходимости она может быть перемещена или удалена.
            this.karta_health8TableAdapter.Fill(this.klassRukDataSet.karta_health8);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            karta_health8TableAdapter.Update(klassRukDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            karta_health8DataGridView.Rows.RemoveAt(karta_health8DataGridView.CurrentCell.RowIndex);
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
