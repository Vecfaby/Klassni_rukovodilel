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
    public partial class FormHealt9 : Form
    {
        public FormHealt9()
        {
            InitializeComponent();
        }

        private void karta_health5BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.karta_health5BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormHealt9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.karta_health9". При необходимости она может быть перемещена или удалена.
            this.karta_health9TableAdapter.Fill(this.klassRukDataSet.karta_health9);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.karta_health5". При необходимости она может быть перемещена или удалена.
            this.karta_health5TableAdapter.Fill(this.klassRukDataSet.karta_health5);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            karta_health9TableAdapter.Update(klassRukDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            karta_health9DataGridView.Rows.RemoveAt(karta_health9DataGridView.CurrentCell.RowIndex);
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormKlas9 k9 = new FormKlas9();
            k9.Left = this.Left;
            k9.Top = this.Top;
            k9.Show();
            this.Hide();
        }
    }
}
