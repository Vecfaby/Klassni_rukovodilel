using Klassni_rukovodilel_.healt;
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
    public partial class FormKlas7 : Form
    {
        public FormKlas7()
        {
            InitializeComponent();
        }

        private void FormKlas7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.students7". При необходимости она может быть перемещена или удалена.
            this.students7TableAdapter.Fill(this.klassRukDataSet.students7);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormRoditeli7 r7 = new FormRoditeli7();
            r7.Left = this.Left;
            r7.Top = this.Top;
            r7.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVedomost7 v7 = new FormVedomost7();
            v7.Left = this.Left;
            v7.Top = this.Top;
            v7.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHealt7 h7 = new FormHealt7();
            h7.Left = this.Left;
            h7.Top = this.Top;
            h7.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPosechaemost7 p7 = new FormPosechaemost7();
            p7.Left = this.Left;
            p7.Top = this.Top;
            p7.Show();
            this.Hide();
        }

        private void buttonPoisk_Click(object sender, EventArgs e)
        {
            FormStudent7 s7 = new FormStudent7();
            s7.Left = this.Left;
            s7.Top = this.Top;
            s7.Show();
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
