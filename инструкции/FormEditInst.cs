using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klassni_rukovodilel_.инструкции
{
    public partial class FormEditInst : Form
    {
        public FormEditInst()
        {
            InitializeComponent();
        }

        private void instruktionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.instruktionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormEditInst_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.zhurnal_TB". При необходимости она может быть перемещена или удалена.
            this.zhurnal_TBTableAdapter.Fill(this.klassRukDataSet.zhurnal_TB);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet.Instruktion". При необходимости она может быть перемещена или удалена.
            this.instruktionTableAdapter.Fill(this.klassRukDataSet.Instruktion);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
           zhurnal_TBTableAdapter.Update(klassRukDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
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
            worksheet.Name = "Проведенные инструктажи";
            // сохраняем часть заголовка в Excel  
            for (int i = 1; i < zhurnal_TBDataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = zhurnal_TBDataGridView.Columns[i - 1].HeaderText;
            }
            // сохраняем значение каждой строки и столбца в листе Excel  
            for (int i = 0; i < zhurnal_TBDataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < zhurnal_TBDataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = zhurnal_TBDataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            // Выход из приложения  
            app.Quit();
            MessageBox.Show("Данные экспортированы");
        }

        private void buttonDellete_Click(object sender, EventArgs e)
        {
            zhurnal_TBDataGridView.Rows.RemoveAt(zhurnal_TBDataGridView.CurrentCell.RowIndex);
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormZhurnal zh = new FormZhurnal();
            zh.Left = this.Left;
            zh.Top = this.Top;
            zh.Show();
            this.Hide();
        }
    }
    }

