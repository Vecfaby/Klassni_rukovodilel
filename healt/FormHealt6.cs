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
    public partial class FormHealt6 : Form
    {
        public FormHealt6()
        {
            InitializeComponent();
        }

        private void karta_health6BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.karta_health6BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormHealt6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.karta_health6". При необходимости она может быть перемещена или удалена.
            this.karta_health6TableAdapter.Fill(this.klassRukDataSet.karta_health6);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            karta_health6TableAdapter.Update(klassRukDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            karta_health6DataGridView.Rows.RemoveAt(karta_health6DataGridView.CurrentCell.RowIndex);
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormKlas6 k6 = new FormKlas6();
            k6.Left = this.Left;
            k6.Top = this.Top;
            k6.Show();
            this.Hide();
        }
    }
}
