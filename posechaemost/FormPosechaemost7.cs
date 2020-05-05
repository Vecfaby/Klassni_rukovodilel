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

namespace Klassni_rukovodilel_.posechaemost
{
    public partial class FormPosechaemost7 : Form
    {
        public FormPosechaemost7()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            posechaemost7TableAdapter.Update(klassRukDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void posechaemost7BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.posechaemost7BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormPosechaemost7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.posechaemost7". При необходимости она может быть перемещена или удалена.
            this.posechaemost7TableAdapter.Fill(this.klassRukDataSet.posechaemost7);

        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            posechaemost7DataGridView.Rows.RemoveAt(posechaemost7DataGridView.CurrentCell.RowIndex);
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
