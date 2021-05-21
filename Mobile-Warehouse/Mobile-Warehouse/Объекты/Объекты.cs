using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Reflection;
using System.Windows.Forms;

namespace Mobile_Warehouse.Объекты
{
    public partial class Объекты : Form
    {
        private OleDbConnection connection;

        public Объекты()
        {
            this.InitializeComponent();
            this.Объекты_Load();
        }

        public TabPage GetTabByName(string tabName)
        {
            return (TabPage)this.GetType()
                .GetField(tabName, BindingFlags.NonPublic | BindingFlags.Instance)
                .GetValue(this);
        }

        private void Объекты_Load()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mobExpressDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.mobExpressDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mobExpressDataSet.ПоставщикиЗапрос". При необходимости она может быть перемещена или удалена.
            this.поставщикиЗапросTableAdapter.Fill(this.mobExpressDataSet.ПоставщикиЗапрос);
        }

        private void Объекты_Load(object sender, EventArgs e)
        {

        }
    }
}
