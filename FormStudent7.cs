﻿using System;
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
    public partial class FormStudent7 : Form
    {
        public FormStudent7()
        {
            InitializeComponent();
        }

        private void students7BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.students7BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormStudent7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.students7". При необходимости она может быть перемещена или удалена.
            this.students7TableAdapter.Fill(this.klassRukDataSet.students7);
            SqlConnection con = new SqlConnection("Data Source='.\\SQLEXPRESS';Integrated Security='true';Initial Catalog='KlassRuk'");
            SqlCommand cmd = new SqlCommand("SELECT name_student FROM students7", con);
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
            students7BindingSource.Filter = "name_student = \'" + textBoxSearch.Text + "\'";
        }

        private void buttonOtobr_Click(object sender, EventArgs e)
        {
            students7BindingSource.Filter = null;
            textBoxSearch.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            students7TableAdapter.Update(klassRukDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            students7DataGridView.Rows.RemoveAt(students7DataGridView.CurrentCell.RowIndex);
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
            worksheet.Name = "Ученики 5 класса";
            // сохраняем часть заголовка в Excel  
            for (int i = 1; i < students7DataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = students7DataGridView.Columns[i - 1].HeaderText;
            }
            // сохраняем значение каждой строки и столбца в листе Excel  
            for (int i = 0; i < students7DataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < students7DataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = students7DataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            // сохранить приложение  
            workbook.SaveAs();
            MessageBox.Show("Данные экспортированы");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormStudents stud = new FormStudents();
            stud.Left = this.Left;
            stud.Top = this.Top;
            stud.Show();
            this.Hide();
        }
    }
    }

