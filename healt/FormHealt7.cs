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

namespace Klassni_rukovodilel_.healt
{
    public partial class FormHealt7 : Form
    {
        public FormHealt7()
        {
            InitializeComponent();
        }

        private void karta_health7BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.karta_health7BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormHealt7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.karta_health7". При необходимости она может быть перемещена или удалена.
            this.karta_health7TableAdapter.Fill(this.klassRukDataSet.karta_health7);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            karta_health7TableAdapter.Update(klassRukDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            karta_health7DataGridView.Rows.RemoveAt(karta_health7DataGridView.CurrentCell.RowIndex);
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormKlas7 k7 = new FormKlas7();
            k7.Left = this.Left;
            k7.Top = this.Top;
            k7.Show();
            this.Hide();
        }
    }
}
