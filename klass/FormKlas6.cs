using Klassni_rukovodilel_.parent;
using Klassni_rukovodilel_.posechaemost;
using Klassni_rukovodilel_.vedomosti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klassni_rukovodilel_.klass
{
    public partial class FormKlas6 : Form
    {
        public FormKlas6()
        {
            InitializeComponent();
        }

        private void FormKlas6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.students6". При необходимости она может быть перемещена или удалена.
            this.students6TableAdapter.Fill(this.klassRukDataSet.students6);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormRoditeli6 r6 = new FormRoditeli6();
            r6.Left = this.Left;
            r6.Top = this.Top;
            r6.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVedomost6 v6 = new FormVedomost6();
            v6.Left = this.Left;
            v6.Top = this.Top;
            v6.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHealt6 h6 = new FormHealt6();
            h6.Left = this.Left;
            h6.Top = this.Top;
            h6.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPosechaemost6 p6 = new FormPosechaemost6();
            p6.Left = this.Left;
            p6.Top = this.Top;
            p6.Show();
            this.Hide();
        }

        private void buttonPoisk_Click(object sender, EventArgs e)
        {
            FormStudent6 s6 = new FormStudent6();
            s6.Left = this.Left;
            s6.Top = this.Top;
            s6.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAuto a = new FormAuto();
            a.Left = this.Left;
            a.Top = this.Top;
            a.Show();
            this.Hide();
        }
    }
}
