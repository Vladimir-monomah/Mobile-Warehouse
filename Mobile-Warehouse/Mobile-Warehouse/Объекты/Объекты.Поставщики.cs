using DGV2Printer;
using Mobile_Warehouse.Properties;
using Mobile_Warehouse.Поставщики;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mobile_Warehouse.MobExpressDataSet;

namespace Mobile_Warehouse.Объекты
{
    public partial class Объекты
    {
        private void dataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = this.dataGridView.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridView.Rows[index].HeaderCell.Value = indexStr;
        }

        /// <summary>
        /// Добавить нового поставщика
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var открыть = new Новая_карточка_поставщика();
            открыть.ShowDialog();

            this.поставщикиЗапросTableAdapter.Fill(this.mobExpressDataSet.ПоставщикиЗапрос);
        }

        /// <summary>
        /// Импортирует данные из Exel-файла, выбранного в окне диалога
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonImport_Click(object sender, EventArgs e)
        {
            ПоставщикиDataTable providers = this.mobExpressDataSet.Поставщики;
            this.поставщикиTableAdapter.Fill(providers);
            this.ImportDataFromExcel(
                this.GetImportingExcelFileName(),
                providers,
                new[] { "ФИО" });
            this.поставщикиTableAdapter.Update(providers);
            this.Объекты_Load();
        }

        /// <summary>
        /// Экспорт файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExport_Click(object sender, EventArgs e)
        {
            var ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            for (int i = 0; i < this.dataGridView.Columns.Count; i++)
            {
                var cellCaption = this.dataGridView.Columns[i].HeaderText;
                var bracketIndex = cellCaption.IndexOf('(') - 1;
                if (bracketIndex > -1)
                {
                    cellCaption = cellCaption.Substring(0, bracketIndex);
                }

                cellCaption = cellCaption.Replace("Номер карточки", "Номер карточки");

                ExcelWorkSheet.Cells[1, i + 1] = cellCaption;
            }
            for (int i = 0; i < this.dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < this.dataGridView.Columns.Count; j++)
                {
                    ExcelWorkSheet.Cells[i + 2, j + 1] = this.dataGridView.Rows[i].Cells[j].Value.ToString();
                    if (!this.dataGridView.Columns[j].Visible)
                    {
                        ExcelWorkSheet.Cells[i + 2, j + 1].ColumnWidth = 0;
                    }
                }
            }

            for (int j = 0; j < this.dataGridView.Columns.Count; j++)
            {
                if (this.dataGridView.Columns[j].Visible)
                {
                    ExcelWorkSheet.Columns[j + 1].AutoFit();
                }
            }
            ExcelApp.Visible = true;
        }

        /// <summary>
        /// Кнопка удалить строку сотрудника из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var idProvider = ((ПоставщикиЗапросRow)((DataRowView)this.dataGridView.CurrentRow?.DataBoundItem)?.Row)?.Id;
            if (!idProvider.HasValue)
            {
                return;
            }

            var deleteEmployeeQuestionResult = MessageBox.Show("Вы действительно хотите удалить поставщика?", "Информация",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteEmployeeQuestionResult != DialogResult.Yes)
            {
                return;
            }
            using (var connection = new OleDbConnection(Settings.Default.MobExpressConnectionString))
            {
                connection.Open();
                using (var sqlCommand = connection.CreateCommand())
                {
                    sqlCommand.CommandText = $"DELETE FROM Поставщики WHERE Id = {idProvider.Value}";
                    sqlCommand.ExecuteNonQuery();
                }
            }
            this.Объекты_Load();
        }

        private void UpdateПоставщики()
        {
            this.поставщикиTableAdapter.Update(this.mobExpressDataSet.Поставщики);
            this.поставщикиTableAdapter.Fill(this.mobExpressDataSet.Поставщики);
        }

        /// <summary>
        /// Открывает окно на редактирование поставщиков
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //заполнить после
        }

        /// <summary>
        /// Очистить текстовое поле сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>   
        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = "";
        }

        #region Фильтрация отображаемых значений
        /// <summary>
        /// фильтрация читателей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.поставщикиЗапросBindingSource.Filter = this.BuildWorkerCardFilter();
        }

        private string BuildWorkerCardFilter()
        {
            var filterExpressionList = new List<string>();
            var fieldFilter = this.textBox3.Text;
            if (!string.IsNullOrEmpty(fieldFilter))
            {
                filterExpressionList.Add(string.Format("(([ФИО] Like '%{0}%'))", fieldFilter));
            }

            return string.Join(" AND ", filterExpressionList);
        }
        #endregion

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            var pr = new PrintDataGridView(this.dataGridView);
            pr.isRightToLeft = true;
            pr.ReportHeader = this.label6.Text;
            pr.Print();
        }
    }
}
