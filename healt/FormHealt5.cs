using Klassni_rukovodilel_.klass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klassni_rukovodilel_
{
    public partial class FormHealt5 : Form
    {
        public FormHealt5()
        {
            InitializeComponent();
        }

        private void karta_health5BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.karta_health5BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormHealt5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.karta_health5". При необходимости она может быть перемещена или удалена.
            this.karta_health5TableAdapter.Fill(this.klassRukDataSet.karta_health5);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            karta_health5TableAdapter.Update(klassRukDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            karta_health5DataGridView.Rows.RemoveAt(karta_health5DataGridView.CurrentCell.RowIndex);
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormKlas5 k5 = new FormKlas5();
            k5.Left = this.Left;
            k5.Top = this.Top;
            k5.Show();
            this.Hide();
        }
    }
}
