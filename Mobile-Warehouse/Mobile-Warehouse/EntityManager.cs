using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobile_Warehouse.MobExpressDataSetTableAdapters;
using static Mobile_Warehouse.MobExpressDataSet;
using System.Data.OleDb;
using System.Data;

namespace Mobile_Warehouse
{
    public class EntityManager
    {
        static MobExpressDataSet MobExpressDataSet = new MobExpressDataSet();

        private static ПользователиTableAdapter пользователиTableAdapter = new ПользователиTableAdapter();
        private static ПоставщикиTableAdapter ПоставщикиTableAdapter = new ПоставщикиTableAdapter();

        public static ПользователиDataTable UserDataTable
        {
            get
            {
                return MobExpressDataSet.Пользователи;
            }
        }

        public static ПоставщикиDataTable ProviderDataTable
        {
            get
            {
                return MobExpressDataSet.Поставщики;
            }
        }

        public static void UpdateUsers()
        {
            пользователиTableAdapter.Adapter.Update(UserDataTable);
        }

        public static void UpdateProviders()
        {
            ПоставщикиTableAdapter.Adapter.Update(ProviderDataTable);
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу пользователей по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static ПользователиDataTable FilterUsers(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterUserCommand = new OleDbCommand()
            {
                Connection = пользователиTableAdapter.Connection,
                CommandText = "SELECT Id_user, Фамилия, Имя, Отчество, Логин, Пароль, " +
                $"[Является администратором] FROM Пользователи {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(пользователиTableAdapter.Adapter, filterUserCommand, UserDataTable);

            return UserDataTable;
        }

        /// <summary>
        /// Возвращает отфильтрованную таблицу поставщиков по условию <paramref name="condition"/>
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static ПоставщикиDataTable FilterProviders(string condition = null)
        {
            var whereCondition = string.Empty;
            if (!string.IsNullOrEmpty(condition))
            {
                whereCondition = $"WHERE {condition}";
            }

            var filterProvidersCommand = new OleDbCommand()
            {
                Connection = ПоставщикиTableAdapter.Connection,
                CommandText = "SELECT Id, [Номер карточки], ФИО, Наименование, Адрес, Телефон, " +
                "Email, ИНН, КПП, ОКПО, [Банковские реквизиты], Бренд, [Тип товара], [Общая сумма закупок]" +
                "[Общая сумма возвратов], [Сумма (закупки-возврты)], Депозит, [Долг перед поставщиком], " +
                "[Дата поступления товара], [Реальная дата привоза], Прострочка, Примечание" +
                $"FROM Поставщики {whereCondition}",
                CommandType = global::System.Data.CommandType.Text
            };

            FillFilteredTable(ПоставщикиTableAdapter.Adapter, filterProvidersCommand, ProviderDataTable);

            return ProviderDataTable;
        }

        /// <summary>
        /// Создает строку для фильтрации: всевозможные комбинации по сравнению предоставленных полей с текстом поиска
        /// </summary>
        /// <param name="fields"></param>
        /// <param name="searchText"></param>
        /// <returns></returns>
        public static string GetFilterStringByFields(string[] fields, string searchText)
        {
            var findValues = string.IsNullOrEmpty(searchText)
                ? new string[] { }
                : searchText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var filterStrings = new List<string>();
            foreach (var findingField in fields)
            {
                foreach (var findingValue in findValues)
                {
                    filterStrings.Add($"{findingField} LIKE '%{findingValue}%'");
                }
            }

            return string.Join(" OR ", filterStrings);
        }

        /// <summary>
        /// Заполняет таблицу по фильтрующей команде выбора строк
        /// </summary>
        /// <param name="adapter"></param>
        /// <param name="selectCommand"></param>
        /// <param name="table"></param>
        private static void FillFilteredTable(OleDbDataAdapter adapter, OleDbCommand selectCommand, DataTable table)
        {
            var oldSelectComand = adapter.SelectCommand;
            adapter.SelectCommand = selectCommand;

            table.Clear();

            adapter.Fill(table);
            adapter.SelectCommand = oldSelectComand;
        }
    }
}
