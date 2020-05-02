using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klassni_rukovodilel_
{
    public partial class FormAuto : Form
    {
        public FormAuto()
        {
            InitializeComponent();
        }
        int a = 0, b = 15, s = 0, d = 15;

        private void FormAuto_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b > 0)
            {
                b--;
                label4.Text = ("Вы заблокированы. Пожалуйста подождите: " + b);
                if (b == 0)
                {
                    b = d;
                    d += 5;
                    timer1.Enabled = false;
                    buttonEnter.Enabled = true;
                    label4.Visible = false;
                    buttonExit.Enabled = true;
                    label4.Text = "";
                    textBoxLogin.Enabled = true;
                    textBoxPassword.Enabled = true;
                }
            }
            s++;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string LoginUser = textBoxLogin.Text;
                string PassUser = textBoxPassword.Text;
                ClassIniDatabase db = new ClassIniDatabase();

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand commandagent = new SqlCommand(@"SELECT * FROM [Users] WHERE login = @ul AND password = @ul AND role ='admin'", db.GetConnection());
                commandagent.Parameters.Add("@uL", SqlDbType.VarChar).Value = LoginUser;
                commandagent.Parameters.Add("@uP", SqlDbType.VarChar).Value = PassUser;
                adapter.SelectCommand = commandagent;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    Form me = new FormMenu();
                    me.Left = this.Left;
                    me.Top = this.Top;
                    me.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Не верный логин или пароль");
                    textBoxLogin.Clear();
                    textBoxPassword.Clear();
                    a++;
                    if (a == 3)
                    {
                        timer1.Enabled = true;
                        buttonEnter.Enabled = false;
                        label4.Visible = true;
                        buttonExit.Enabled = false;
                        textBoxLogin.Enabled = false;
                        textBoxPassword.Enabled = false;
                    }
                }
            }
            finally
            {
            }
        }
    }
}
