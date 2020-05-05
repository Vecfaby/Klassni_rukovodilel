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

namespace Klassni_rukovodilel_.vedomosti
{
    public partial class FormVedomost7 : Form
    {
        public FormVedomost7()
        {
            InitializeComponent();
        }

        private void svodnaya_vedomost7kBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.svodnaya_vedomost7kBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormVedomost7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.svodnaya_vedomost7k". При необходимости она может быть перемещена или удалена.
            this.svodnaya_vedomost7kTableAdapter.Fill(this.klassRukDataSet.svodnaya_vedomost7k);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            svodnaya_vedomost7kTableAdapter.Update(klassRukDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            svodnaya_vedomost7kDataGridView.Rows.RemoveAt(svodnaya_vedomost7kDataGridView.CurrentCell.RowIndex);
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
