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
    public partial class FormVneurochnaya : Form
    {
        public FormVneurochnaya()
        {
            InitializeComponent();
        }

        private void vneurochnaya_deyatelnost_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vneurochnaya_deyatelnost_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klassRukDataSet);

        }

        private void FormVneurochnaya_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klassRukDataSet._vneurochnaya_deyatelnost_". При необходимости она может быть перемещена или удалена.
            this.vneurochnaya_deyatelnost_TableAdapter.Fill(this.klassRukDataSet._vneurochnaya_deyatelnost_);

        }
    }
}
