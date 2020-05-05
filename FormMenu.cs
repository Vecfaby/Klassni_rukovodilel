using Klassni_rukovodilel_.инструкции;
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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

       

        private void buttonstudent_Click(object sender, EventArgs e)
        {
            FormStudent stu = new FormStudent();
            stu.Left = this.Left;
            stu.Top = this.Top;
            stu.Show();
            this.Hide();
        }

        private void buttonRuk_Click(object sender, EventArgs e)
        {
            FormSchool ruk = new FormSchool();
            ruk.Left = this.Left;
            ruk.Top = this.Top;
            ruk.Show();
            this.Hide();
        }

        private void buttonStud_Click(object sender, EventArgs e)
        {
            FormStudents stud = new FormStudents();
            stud.Left = this.Left;
            stud.Top = this.Top;
            stud.Show();
            this.Hide();
        }

        private void buttonZhur_Click(object sender, EventArgs e)
        {
            FormZhurnal zh = new FormZhurnal();
            zh.Left = this.Left;
            zh.Top = this.Top;
            zh.Show();
            this.Hide();
        }

        private void buttonVneur_Click(object sender, EventArgs e)
        {
            FormVneurochnaya vn = new FormVneurochnaya();
            vn.Left = this.Left;
            vn.Top = this.Top;
            vn.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
