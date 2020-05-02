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

        private void buttonSch_Click(object sender, EventArgs e)
        {
            FormSchool sch = new FormSchool();
            sch.Left = this.Left;
            sch.Top = this.Top;
            sch.Show();
            this.Hide();
        }

        private void buttonstudent_Click(object sender, EventArgs e)
        {
            FormStudent stu = new FormStudent();
            stu.Left = this.Left;
            stu.Top = this.Top;
            stu.Show();
            this.Hide();
        }
    }
}
