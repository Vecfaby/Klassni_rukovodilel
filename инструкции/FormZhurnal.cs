using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klassni_rukovodilel_.инструкции
{
    public partial class FormZhurnal : Form
    {
        public FormZhurnal()
        {
            InitializeComponent();
        }

        private void zhurnal_TBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zhurnal_TBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormZhurnal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.Instruktion". При необходимости она может быть перемещена или удалена.
            this.instruktionTableAdapter.Fill(this.klassRukDataSet.Instruktion);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.zhurnal_TB". При необходимости она может быть перемещена или удалена.
            this.zhurnal_TBTableAdapter.Fill(this.klassRukDataSet.zhurnal_TB);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form me = new FormMenu();
            me.Left = this.Left;
            me.Top = this.Top;
            me.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEditInst me = new FormEditInst();
            me.Left = this.Left;
            me.Top = this.Top;
            me.Show();
            this.Hide();
        }
    }
}
