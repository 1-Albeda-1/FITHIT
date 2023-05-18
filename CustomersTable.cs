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
using Excel = Microsoft.Office.Interop.Excel;


namespace Курсовая_СмирноваКристина_ИП_20_3
{
    public partial class CustomersTable : Form
    {
        public CustomersTable()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            TableLoad(PRINT_ALL);
            toolStripStatusLabelAccount.Text = Users.User;
            if (toolStripStatusLabelAccount.Text == "Пользователь: Гость") // Блокировка элемнтов при входе гостя
            {
                экспортДанныхToolStripMenuItem.Enabled = false;
                добавитьЗаписьToolStripMenuItem.Enabled = false;
                справкаToolStripMenuItem.Enabled = false;
                buttonFilter.Enabled = false;
                btnDelete.Enabled = false;
                buttonSort.Enabled = false;
                buttonViewAll.Enabled = false;
                listBoxSort.Enabled = false;
                comboBoxCustomersActivity.Enabled = false;
            }
        }
        private System.Windows.Forms.DataGridViewColumn COL;
        private AddCustomers addCustomers;
        private ActivityTable activityTable;
        private CustomersTable customersTable;
        private AuthorizationForm authorizationForm;
        private CustomersDetailed customersDetailed;

        private string PRINT_ALL = "SELECT " + // Запроос на заполнение таблицы данными из БД
                "[CustomersTable].[ID], " +
                "[CustomersTable].[Name], " +
                "[CustomersTable].[Surname], " +
                "[CustomersTable].[Phone], " +
                "[ActivityTable].[ActivityNameID], " +
                "[CustomersTable].[SeasonTTF], " +
                "[CustomersTable].[SeasonTicket] " +
                "FROM " +
                "[CustomersTable], " +
                "[ActivityTable] " +
                "WHERE " +
                "[CustomersTable].[ActivityId]=[ActivityTable].[ID]";

        private string connectionString = "Data Source=FitClubDB.mssql.somee.com;Initial Catalog=FitClubDB;User ID=Albeda1310_SQLLogin_1;Password=qz6kfq6fgy";

        private void CustomersTable_Load(object sender, EventArgs e)
        {
            TableLoad(PRINT_ALL);
        }

        private void рассписаниеЗанятийToolStripMenuItem_Click(object sender, EventArgs e) // Открытие таблицы рассписания занятий
        {
            activityTable = new ActivityTable();
            activityTable.Visible = true;
            this.Hide();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e) // Открытие таблицы клиентов
        {
            customersTable = new CustomersTable();
            customersTable.Visible = true;
            this.Hide();
        }        
        private void btnCustomersDetailed_Click(object sender, EventArgs e) // Открытие таблицы подробной информации о записи
        {
            customersDetailed = new CustomersDetailed();
            customersDetailed.Visible = true;
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e) // Открытие окна добавления клиентов
        {
            addCustomers = new AddCustomers();
            if (addCustomers.ShowDialog() == DialogResult.OK)
            {
                TableLoad(PRINT_ALL);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e) // Удаление выбранного клиента
        {
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                var Id = Convert.ToInt32(dataGridViewCustomers.SelectedRows[0].Cells["ID"].Value);
                var Name = dataGridViewCustomers.SelectedRows[0].Cells["name"].Value.ToString();
                var Surname = dataGridViewCustomers.SelectedRows[0].Cells["surname"].Value.ToString();
                if (MessageBox.Show($"Вы уверены что хотите удалить клиента {Name} {Surname} ?", "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string query = $"DELETE CustomersTable WHERE ID = {Id}";
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();

                    connection.Close();
                    TableLoad(PRINT_ALL);
                }
            }
            else
            {
                MessageBox.Show("Чтобы удалить запись выберите строку в которой она находиться!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void просмотрСправкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
        }

        private void listBoxSort_SelectedIndexChanged(object sender, EventArgs e) 
        {
            buttonSort.Enabled = true;
        }

        private void buttonSort_Click(object sender, EventArgs e) // Сортировка таблицы по выбранному столбцу
        {
            COL = new System.Windows.Forms.DataGridViewColumn();

            switch (listBoxSort.SelectedItem.ToString()) // Обработка выбранного столбца
            {
                case "Имя клиента":
                    COL = name;
                    break;
                case "Фамилия клиента":
                    COL = surname;
                    break;
                case "Занятие":
                    COL = activityid;
                    break;
            }
            if (radioButtonUp.Checked)
                dataGridViewCustomers.Sort(COL, System.ComponentModel.ListSortDirection.Ascending); // Сортировка по возрастанию
            else
                dataGridViewCustomers.Sort(COL, System.ComponentModel.ListSortDirection.Descending); // Сортировка по убыванию
        }

        private void buttonFilter_Click(object sender, EventArgs e) // Фильтрация по выбранному наименованию
        {
            TableLoad(PRINT_ALL + " AND " +
               $"[CustomersTable].[Activityid]='{comboBoxCustomersActivity.SelectedValue}'");
        }

        private void buttonViewAll_Click(object sender, EventArgs e) // Кнопка, которая показывает все даннные таблицы
        {
            TableLoad(PRINT_ALL);
        }

        private void buttonSearch_Click(object sender, EventArgs e) // Поиск по таблице
        {
            bool proverka = false;
            for (int i = 0; i < dataGridViewCustomers.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridViewCustomers.RowCount - 1; j++)
                {
                    dataGridViewCustomers[i, j].Style.BackColor = Color.White;
                    dataGridViewCustomers[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < dataGridViewCustomers.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridViewCustomers.RowCount - 1; j++)
                {
                    if (dataGridViewCustomers[i, j].Value.ToString().IndexOf(textBoxCriteria.Text) != -1)
                    {
                        dataGridViewCustomers[i, j].Style.BackColor = Color.AliceBlue;
                        dataGridViewCustomers[i, j].Style.ForeColor = Color.Blue;
                        proverka = true;
                    }
                }
            }
            if (!proverka)
            {
                MessageBox.Show("Введенные данные не найдены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        private void экспортДанныхToolStripMenuItem_Click(object sender, EventArgs e) // Экспорт таблицы в Excel
        {
            var iRow = 1;
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Report Customers";
            saveFile.Filter = "Excel files |= xlsx";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                Excel.Application ExcelApp = new Excel.Application();
                Excel.Workbook ExcelBook;
                Excel.Worksheet ExcelSheet;
                ExcelBook = ExcelApp.Workbooks.Add();
                ExcelApp.Columns.ColumnWidth = 25;
                ExcelSheet = (Excel.Worksheet)ExcelBook.Sheets[1];
                ExcelSheet.Name = "Клиенты FITHIT";
                ExcelSheet.Cells[1, 1] = "Имя";
                ExcelSheet.Cells[1, 2] = "Фамилия";
                ExcelSheet.Cells[1, 3] = "Номер телефона";
                ExcelSheet.Cells[1, 4] = "Занятие";
                ExcelSheet.Cells[1, 5] = "Наличие абонемента";
                ExcelSheet.Cells[1, 6] = "Срок абонемента";

                for (int i = 0; i < dataGridViewCustomers.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridViewCustomers.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dataGridViewCustomers.Rows[i].Cells[j].Value.ToString();
                    }
                }
                ExcelApp.Rows[$"{iRow}:{iRow}"].Interior.Color = Color.LightBlue;
                ExcelApp.Visible = true;
            }
        }
        private void comboBoxCustomersName_MouseEnter(object sender, EventArgs e) // Вывод подсказки
        {
            toolStripStatusLabelHint.Text = "Выберите фамилию клиента для фильтрации";
        }
        private void textBoxCriteria_MouseEnter(object sender, EventArgs e) // Вывод подсказки
        {
            toolStripStatusLabelHint.Text = "Введите критерий для поиска по таблице";
        }

        private void textBoxCriteria_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelHint.Text = " ";
        }

        private void comboBoxCustomersActivity_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelHint.Text = " ";
        }       
        private void TableLoad(string query) // Метод заполняющий dataGridView значениями при помощи запроса
        {
            dataGridViewCustomers.Rows.Clear();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }
            reader.Close();

            foreach (string[] s in data)
                dataGridViewCustomers.Rows.Add(s);

            connection.Close();

        }

        private void CustomersTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
