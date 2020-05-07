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
    public partial class FormVedomost5 : Form
    {
        public FormVedomost5()
        {
            InitializeComponent();
        }

        private void svodnaya_vedomost5kBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.svodnaya_vedomost5kBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormVedomost5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.svodnaya_vedomost5k". При необходимости она может быть перемещена или удалена.
            this.svodnaya_vedomost5kTableAdapter.Fill(this.klassRukDataSet.svodnaya_vedomost5k);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            svodnaya_vedomost5kTableAdapter.Update(klassRukDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            svodnaya_vedomost5kDataGridView.Rows.RemoveAt(svodnaya_vedomost5kDataGridView.CurrentCell.RowIndex);
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
