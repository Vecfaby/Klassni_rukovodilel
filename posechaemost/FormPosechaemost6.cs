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
    public partial class FormPosechaemost6 : Form
    {
        public FormPosechaemost6()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            posechaemost6TableAdapter.Update(klassRukDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void posechaemost6BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.posechaemost6BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormPosechaemost6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.posechaemost6". При необходимости она может быть перемещена или удалена.
            this.posechaemost6TableAdapter.Fill(this.klassRukDataSet.posechaemost6);

        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            posechaemost6DataGridView.Rows.RemoveAt(posechaemost6DataGridView.CurrentCell.RowIndex);
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
