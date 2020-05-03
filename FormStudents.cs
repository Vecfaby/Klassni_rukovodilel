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

namespace Klassni_rukovodilel_
{
    public partial class FormStudents : Form
    {
        public FormStudents()
        {
            InitializeComponent();
        }

        private void students5BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.students5BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormStudents_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.students9". При необходимости она может быть перемещена или удалена.
            this.students9TableAdapter.Fill(this.klassRukDataSet.students9);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.students8". При необходимости она может быть перемещена или удалена.
            this.students8TableAdapter.Fill(this.klassRukDataSet.students8);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.students7". При необходимости она может быть перемещена или удалена.
            this.students7TableAdapter.Fill(this.klassRukDataSet.students7);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.students6". При необходимости она может быть перемещена или удалена.
            this.students6TableAdapter.Fill(this.klassRukDataSet.students6);
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

        private void button6_Click(object sender, EventArgs e)
        {
            FormVedomost6 v6 = new FormVedomost6();
            v6.Left = this.Left;
            v6.Top = this.Top;
            v6.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormRoditeli6 r6 = new FormRoditeli6();
            r6.Left = this.Left;
            r6.Top = this.Top;
            r6.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormRoditeli7 r7 = new FormRoditeli7();
            r7.Left = this.Left;
            r7.Top = this.Top;
            r7.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            FormRoditeli8 r8 = new FormRoditeli8();
            r8.Left = this.Left;
            r8.Top = this.Top;
            r8.Show();
            this.Hide();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            FormRoditeli9 r9 = new FormRoditeli9();
            r9.Left = this.Left;
            r9.Top = this.Top;
            r9.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FormVedomost7 v7 = new FormVedomost7();
            v7.Left = this.Left;
            v7.Top = this.Top;
            v7.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            FormVedomost8 v8 = new FormVedomost8();
            v8.Left = this.Left;
            v8.Top = this.Top;
            v8.Show();
            this.Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            FormVedomost9 v9 = new FormVedomost9();
            v9.Left = this.Left;
            v9.Top = this.Top;
            v9.Show();
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

        private void button7_Click(object sender, EventArgs e)
        {
            FormHealt6 h6 = new FormHealt6();
            h6.Left = this.Left;
            h6.Top = this.Top;
            h6.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FormHealt7 h7 = new FormHealt7();
            h7.Left = this.Left;
            h7.Top = this.Top;
            h7.Show();
            this.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            FormHealt8 h8 = new FormHealt8();
            h8.Left = this.Left;
            h8.Top = this.Top;
            h8.Show();
            this.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            FormPosechaemost8 p8 = new FormPosechaemost8();
            p8.Left = this.Left;
            p8.Top = this.Top;
            p8.Show();
            this.Hide();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            FormHealt9 h9 = new FormHealt9();
            h9.Left = this.Left;
            h9.Top = this.Top;
            h9.Show();
            this.Hide();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            FormPosechaemost9 p9 = new FormPosechaemost9();
            p9.Left = this.Left;
            p9.Top = this.Top;
            p9.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FormPosechaemost7 p7 = new FormPosechaemost7();
            p7.Left = this.Left;
            p7.Top = this.Top;
            p7.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormPosechaemost6 p6 = new FormPosechaemost6();
            p6.Left = this.Left;
            p6.Top = this.Top;
            p6.Show();
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

        private void button10_Click(object sender, EventArgs e)
        {
            FormStudent6 s6 = new FormStudent6();
            s6.Left = this.Left;
            s6.Top = this.Top;
            s6.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FormStudent7 s7 = new FormStudent7();
            s7.Left = this.Left;
            s7.Top = this.Top;
            s7.Show();
            this.Hide();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            FormStudent8 s8 = new FormStudent8();
            s8.Left = this.Left;
            s8.Top = this.Top;
            s8.Show();
            this.Hide();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            FormStudent9 s9 = new FormStudent9();
            s9.Left = this.Left;
            s9.Top = this.Top;
            s9.Show();
            this.Hide();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Form me = new FormMenu();
            me.Left = this.Left;
            me.Top = this.Top;
            me.Show();
            this.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form me = new FormMenu();
            me.Left = this.Left;
            me.Top = this.Top;
            me.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form me = new FormMenu();
            me.Left = this.Left;
            me.Top = this.Top;
            me.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form me = new FormMenu();
            me.Left = this.Left;
            me.Top = this.Top;
            me.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form me = new FormMenu();
            me.Left = this.Left;
            me.Top = this.Top;
            me.Show();
            this.Hide();
        }
    }
}
