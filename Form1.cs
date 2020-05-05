using Klassni_rukovodilel_.klass;
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

        private void buttonReg_Click(object sender, EventArgs e)
        {
            FormReg reg = new FormReg();
            reg.Left = this.Left;
            reg.Top = this.Top;
            reg.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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
                string loginUser = textBoxLogin.Text;
                string passUser = textBoxPassword.Text;

                ClassIniDatabase db = new ClassIniDatabase();

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand commandagent = new SqlCommand(@"SELECT * FROM [Users] WHERE Login = @uL AND Password = @uP AND Role= 'admin'", db.GetConnection());
                commandagent.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
                commandagent.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;
                adapter.SelectCommand = commandagent;
                adapter.Fill(table);



                DataTable table1 = new DataTable();
                SqlDataAdapter adapter1 = new SqlDataAdapter();
                SqlCommand commandruk5 = new SqlCommand(@"SELECT * FROM [Users] WHERE Login = @uL AND Password = @uP AND Role = 'Руководитель 5кл' ", db.GetConnection());
                commandruk5.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
                commandruk5.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;
                adapter1.SelectCommand = commandruk5;
                adapter1.Fill(table1);

                DataTable table2 = new DataTable();
                SqlDataAdapter adapter2 = new SqlDataAdapter();
                SqlCommand commandruk6 = new SqlCommand(@"SELECT * FROM [Users] WHERE Login = @uL AND Password = @uP AND Role = 'Руководитель 6кл' ", db.GetConnection());
                commandruk6.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
                commandruk6.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;
                adapter2.SelectCommand = commandruk6;
                adapter2.Fill(table2);

                DataTable table3 = new DataTable();
                SqlDataAdapter adapter3 = new SqlDataAdapter();
                SqlCommand commandruk7 = new SqlCommand(@"SELECT * FROM [Users] WHERE Login = @uL AND Password = @uP AND Role = 'Руководитель 7кл' ", db.GetConnection());
                commandruk7.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
                commandruk7.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;
                adapter3.SelectCommand = commandruk7;
                adapter3.Fill(table3);

                DataTable table4 = new DataTable();
                SqlDataAdapter adapter4 = new SqlDataAdapter();
                SqlCommand commandruk8 = new SqlCommand(@"SELECT * FROM [Users] WHERE Login = @uL AND Password = @uP AND Role = 'Руководитель 8кл' ", db.GetConnection());
                commandruk8.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
                commandruk8.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;
                adapter4.SelectCommand = commandruk7;
                adapter4.Fill(table4);

                DataTable table5 = new DataTable();
                SqlDataAdapter adapter5 = new SqlDataAdapter();
                SqlCommand commandruk9 = new SqlCommand(@"SELECT * FROM [Users] WHERE Login = @uL AND Password = @uP AND Role = 'Руководитель 9кл' ", db.GetConnection());
                commandruk9.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
                commandruk9.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;
                adapter5.SelectCommand = commandruk7;
                adapter5.Fill(table5);
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
                    if (table1.Rows.Count > 0)
                    {
                        FormKlas5 k5 = new FormKlas5();
                        k5.Left = this.Left;
                        k5.Top = this.Top;
                        k5.Show();
                        this.Hide();
                    }
                    if (table2.Rows.Count > 0)
                    {
                        FormKlas6 k6 = new FormKlas6();
                        k6.Left = this.Left;
                        k6.Top = this.Top;
                        k6.Show();
                        this.Hide();
                    }
                    else
                    {
                        if (table3.Rows.Count > 0)
                        {
                            FormKlas7 k7 = new FormKlas7();
                            k7.Left = this.Left;
                            k7.Top = this.Top;
                            k7.Show();
                            this.Hide();
                        }
                        else
                        {
                            if (table4.Rows.Count > 0)
                            {
                                FormKlas8 k8 = new FormKlas8();
                                k8.Left = this.Left;
                                k8.Top = this.Top;
                                k8.Show();
                                this.Hide();
                            }
                            else
                            {
                                if (table5.Rows.Count > 0)
                                {
                                    FormKlas9 k9 = new FormKlas9();
                                    k9.Left = this.Left;
                                    k9.Top = this.Top;
                                    k9.Show();
                                    this.Hide();
                                }
                                else


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
                    }
                }
            }
            finally { }

        }
    }
}
        
        
        
        