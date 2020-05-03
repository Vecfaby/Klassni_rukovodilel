using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klassni_rukovodilel_
{
    public partial class FormRukEdit : Form
    {
        public FormRukEdit()
        {
            InitializeComponent();
        }

        private void klass_rukBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klass_rukBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormRukEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.Klass_ruk". При необходимости она может быть перемещена или удалена.
            this.klass_rukTableAdapter.Fill(this.klassRukDataSet.Klass_ruk);

            SqlConnection con = new SqlConnection("Data Source='.\\SQLEXPRESS';Integrated Security='true';Initial Catalog='KlassRuk'");
            SqlCommand cmd = new SqlCommand("SELECT name_ruk FROM Klass_ruk", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection SCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                SCollection.Add(reader.GetString(0));
            }
            textBoxSearch.AutoCompleteCustomSource = SCollection;
            con.Close();

        }

        private void buttonPoisk_Click(object sender, EventArgs e)
        {
            klass_rukBindingSource.Filter = "name_ruk = \'" + textBoxSearch.Text + "\'";
        }

        private void buttonOtobr_Click(object sender, EventArgs e)
        {
            klass_rukBindingSource.Filter = null;
            textBoxSearch.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            klass_rukTableAdapter.Update(klassRukDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            klass_rukDataGridView.Rows.RemoveAt(klass_rukDataGridView.CurrentCell.RowIndex);
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // создаем приложение Excel  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // создаем новую книгу в приложении Excel  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // создаем новый Excelsheet в книге  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // см. лист Excel за программой  
            app.Visible = true;
            // получить ссылку на первый лист. По умолчанию его имя Sheet1.  
            // сохранить ссылку на лист  
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            // меняем имя активного листа  
            worksheet.Name = "Классные руководители";
            // сохраняем часть заголовка в Excel  
            for (int i = 1; i < klass_rukDataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = klass_rukDataGridView.Columns[i - 1].HeaderText;
            }
            // сохраняем значение каждой строки и столбца в листе Excel  
            for (int i = 0; i < klass_rukDataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < klass_rukDataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = klass_rukDataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
             
           
            // Выход из приложения  
            app.Quit();
            MessageBox.Show("Данные экспортированы");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormSchool ruk = new FormSchool();
            ruk.Left = this.Left;
            ruk.Top = this.Top;
            ruk.Show();
            this.Hide();
        }
    }
    }

      
    
