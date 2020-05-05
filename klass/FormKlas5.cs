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
    public partial class FormKlas5 : Form
    {
        public FormKlas5()
        {
            InitializeComponent();
        }

        private void FormKlas5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.students5". При необходимости она может быть перемещена или удалена.
            this.students5TableAdapter.Fill(this.klassRukDataSet.students5);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormRoditeli5 r5 = new FormRoditeli5();
            r5.Left = this.Left;
            r5.Top = this.Top;
            r5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVedomost5 v5 = new FormVedomost5();
            v5.Left = this.Left;
            v5.Top = this.Top;
            v5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHealt5 h5 = new FormHealt5();
            h5.Left = this.Left;
            h5.Top = this.Top;
            h5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPosechaemost5 p5 = new FormPosechaemost5();
            p5.Left = this.Left;
            p5.Top = this.Top;
            p5.Show();
            this.Hide();
        }

        private void buttonPoisk_Click(object sender, EventArgs e)
        {
            FormStudent s5 = new FormStudent();
            s5.Left = this.Left;
            s5.Top = this.Top;
            s5.Show();
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
