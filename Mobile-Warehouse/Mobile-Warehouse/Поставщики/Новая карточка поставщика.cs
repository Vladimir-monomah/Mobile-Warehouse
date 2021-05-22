using DGV2Printer;
using Mobile_Warehouse.MobExpressDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mobile_Warehouse.MobExpressDataSet;

namespace Mobile_Warehouse.Поставщики
{
    public partial class Новая_карточка_поставщика : Form
    {
        private ПоставщикиRow поставщики;

        public Новая_карточка_поставщика()
        {
            this.InitializeComponent();

            this.ReceiptDateTimePicker.Value = DateTime.Now;
        }

        public void LoadКарточка_поставщика(ПоставщикиЗапросRow поставщики)
        {
            this.поставщики = EntityManager.FilterProviders($"Id={поставщики.Id}").FirstOrDefault();
            this.ProviderFIO.Text = поставщики.ФИО;
            this.NameCompany.Text = поставщики.Наименование;
            this.AddressCompany.Text = поставщики.Адрес;
            this.Phone.Text = Convert.ToInt32(поставщики.Телефон).ToString();
            this.Email.Text = поставщики.Email;
            this.INN.Text = Convert.ToInt32(поставщики.ИНН).ToString();
            this.KPP.Text = Convert.ToInt32(поставщики.КПП).ToString();
            this.OKPO.Text = Convert.ToInt32(поставщики.ОКПО).ToString();
            this.BankDetails.Text = поставщики.Банковские_реквизиты;
            this.ProductBrand.Text = поставщики.Бренд;
            this.TypeProduct.Text = поставщики.Тип_товара;
            this.TotalPurchaseAmount.Text = Convert.ToInt32(поставщики.Общая_сумма_закупок).ToString();
            this.TotalRefunds.Text = Convert.ToInt32(поставщики.Общая_сумма_возвратов).ToString();
            this.Amount.Text = Convert.ToInt32(поставщики._Сумма__закупки_возвраты_).ToString();
            this.Depozit.Text = Convert.ToInt32(поставщики.Депозит).ToString();
            this.DebtSupplier.Text = Convert.ToInt32(поставщики.Долг_перед_поставщиком).ToString();
            this.Note.Text = поставщики.Примечание;
        }

        private bool CheckTextBoxes()
        {
            if(this.ProviderFIO.Text==""||this.NameCompany.Text==""||this.AddressCompany.Text==""||this.INN.Text==""||
                this.KPP.Text==""||this.OKPO.Text==""||this.BankDetails.Text==""||
                this.ProductBrand.Text == "" || this.TypeProduct.Text == "")
            {
                return false;
            }
            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!this.CheckTextBoxes())
            {
                MessageBox.Show("Заполните необходимые поля!",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

                var idProvider = this.поставщики?.Id;
                var adapter = new ПоставщикиTableAdapter();
                adapter.Fill(EntityManager.ProviderDataTable);
                var savingProviders = EntityManager.ProviderDataTable.FindById(idProvider ?? -1)
                    ?? EntityManager.ProviderDataTable.NewПоставщикиRow();
                savingProviders.ФИО = this.ProviderFIO.Text;
            savingProviders.Дата_поступления_товара = this.ReceiptDateTimePicker.Value
                .AddHours(-this.ReceiptDateTimePicker.Value.Hour)
                .AddMinutes(-this.ReceiptDateTimePicker.Value.Minute)
                .AddSeconds(-this.ReceiptDateTimePicker.Value.Second)
                .AddMilliseconds(-this.ReceiptDateTimePicker.Value.Millisecond);
            savingProviders.Наименование = this.NameCompany.Text;
                savingProviders.Адрес = this.AddressCompany.Text;
                savingProviders.Телефон = Convert.ToInt32(this.Phone.Text);
                savingProviders.Email = this.Email.Text;
                savingProviders.ИНН = Convert.ToInt32(this.INN.Text);
                savingProviders.КПП = Convert.ToInt32(this.KPP.Text);
                savingProviders.ОКПО = Convert.ToInt32(this.OKPO.Text);
                savingProviders.Банковские_реквизиты = this.BankDetails.Text;
                savingProviders.Бренд = this.ProductBrand.Text;
                savingProviders.Тип_товара = this.TypeProduct.Text;
                savingProviders.Общая_сумма_закупок = Convert.ToInt32(this.TotalPurchaseAmount.Text);
                savingProviders.Общая_сумма_возвратов = Convert.ToInt32(this.TotalRefunds.Text);
                savingProviders._Сумма__закупки_возвраты_ = Convert.ToInt32(this.Amount.Text);
                savingProviders.Депозит = Convert.ToInt32(this.Depozit.Text);
                savingProviders.Долг_перед_поставщиком = Convert.ToInt32(this.DebtSupplier.Text);

                try
                {
                    if (this.поставщики == null)
                    {
                        EntityManager.ProviderDataTable.AddПоставщикиRow(savingProviders);
                        EntityManager.UpdateProviders();
                    }
                    else
                    {
                        var поставщикиTableAdapter = new ПоставщикиTableAdapter();
                        поставщикиTableAdapter.Adapter.Update(savingProviders.Table);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(
                        "Ошибка при добавлении/изменении! \r\n" + ex.ToString(),
                        "Ошибка",
                        MessageBoxButtons.OK);
                    return;
                }

                var message = this.поставщики == null
                    ? "Добавление прошло успешно!"
                    : "Изменение завершено успешно!";

                MessageBox.Show(message, "Информация", MessageBoxButtons.OK);
                this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Вы действиетльно хотите закрыть данную вкладку?",
                "Закрытие вкладки", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ReceiptDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var dateTimePicker = (DateTimePicker)sender;
            if (dateTimePicker.Enabled
                && (dateTimePicker.Value < DateTime.Now.Date))
            {
                MessageBox.Show("Нельзя выбрать предыдующую дату", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker.Value = DateTime.Now.Date;
                return;
            }
        }

        private void ProviderFIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void TotalPurchaseAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //var pr = new PrintDataGridView(this.dataGridView);
            //pr.isRightToLeft = true;
            //pr.ReportHeader = this.label22.Text;
            //pr.Print();
        }
    }
}
