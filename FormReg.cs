using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klassni_rukovodilel_


{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-QJJ19PD\SQLEXPRESS;Initial Catalog=KlassRuk;Integrated Security=True");

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormReg_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.klassRukDataSet.Users);
            this.rukiTableAdapter1.Fill(this.klassRukDataSet.ruki);

            SqlConnection con = new SqlConnection("Data Source='.\\SQLEXPRESS';Integrated Security='true';Initial Catalog='KlassRuk'");
            SqlCommand cmd = new SqlCommand("SELECT ruk FROM ruki", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection SCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                SCollection.Add(reader.GetString(0));
            }
            roleTextBox.AutoCompleteCustomSource = SCollection;
            con.Close();

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "INSERT INTO [Users] ([login], [password], [role]) VALUES ('" + loginTextBox.Text + "','" + passwordTextBox.Text + "','" + roleTextBox.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Регистрация прошла успешно");
            FormAuto a = new FormAuto();
            a.Left = this.Left;
            a.Top = this.Top;
            a.Show();
            this.Hide();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void roleTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void roleTextBox_TextChanged_1(object sender, EventArgs e)
        {
            

        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            FormAuto a = new FormAuto();
            a.Left = this.Left;
            a.Top = this.Top;
            a.Show();
            this.Hide();
        }
    }
}

