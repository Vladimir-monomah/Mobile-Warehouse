using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Warehouse.Объекты
{
    public partial class Объекты : Form
    {
        public Объекты()
        {
            this.InitializeComponent();
        }

        public TabPage GetTabByName(string tabName)
        {
            return (TabPage)this.GetType()
                .GetField(tabName, BindingFlags.NonPublic | BindingFlags.Instance)
                .GetValue(this);
        }

        private void Объекты_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mobExpressDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.mobExpressDataSet.Поставщики);

        }
    }
}
