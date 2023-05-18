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
    public partial class ActivityTable : Form
    {
        private string PRINT_ALL = "SELECT " + // Запроос на заполнение таблицы данными из БД
                "[ActivityTable].[ID], " +
                "[ActivityTable].[NameT], " +
                "[ActivityTable].[SurnameT], " +
                "[ActivityTable].[FitClub], " +
                "[ActivityNameTable].[ActivityName], " +
                "[ActivityTable].[Date], " +
                "[ActivityTable].[StartTime], " +
                "[ActivityTable].[Time], " +
                "[ActivityNameTable].[Cost] " +
                "FROM " +
                "[ActivityNameTable], " +
                "[ActivityTable] " +
                "WHERE " +
                "[ActivityTable].[ActivityNameID]=[ActivityNameTable].[ID]";

        private string connectionString = "Data Source=FitClubDB.mssql.somee.com;Initial Catalog=FitClubDB;User ID=Albeda1310_SQLLogin_1;Password=qz6kfq6fgy";
        public ActivityTable()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            toolStripStatusLabelAccount.Text = Users.User;
            if (toolStripStatusLabelAccount.Text == "Пользователь: Гость")// Блокировка элемнтов при входе гостя
            {
                справкаToolStripMenuItem.Enabled = false;
                экспортДанныхToolStripMenuItem.Enabled = false;
                добавитьЗаписьToolStripMenuItem.Enabled = false;
                buttonDelete.Enabled = false;
                buttonFilter.Enabled = false;
                buttonSort.Enabled = false;
                buttonViewAll.Enabled = false;
                listBoxSort.Enabled = false;
                comboBoxActivityName.Enabled = false;
            }
            
        }
        private System.Windows.Forms.DataGridViewColumn COL;
        private AddActivity addActivity;
        private ActivityTable activityTable;
        private CustomersTable customersTable;
        private AuthorizationForm authorizationForm;
        private void Form1_Load(object sender, EventArgs e)
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

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e) // Открытие окна добавления рассписания занятий
        {
            addActivity = new AddActivity();
            if (addActivity.ShowDialog() == DialogResult.OK)
            {
                TableLoad(PRINT_ALL);
            }
        }

        private void просмотрСправкиToolStripMenuItem_Click(object sender, EventArgs e) // Открытие справки с данными о программе
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

            switch (listBoxSort.SelectedIndex) // Обработка выбранного столбца
            {
                case 0:
                    COL = NameTDataGridViewTextBoxColumn;
                    break;
                case 1:
                    COL = SurnameTDataGridViewTextBoxColumn;
                    break ;
                case 2:
                    COL = ActivityNameIDDataGridViewTextBoxColumn;
                    break;
                case 3:
                    COL = DateDataGridViewTextBoxColumn;
                    break;
                case 4:
                    COL = TimeDataGridViewTextBoxColumn;
                    break;
                case 5:
                    COL = CostDataGridViewTextBoxColumn;
                    break;
            }
            if(radioButtonUp.Checked)
                dataGridViewActivity.Sort(COL, 
                    System.ComponentModel.ListSortDirection.Ascending); // Сортировка по возрастанию
            else
                dataGridViewActivity.Sort(COL, 
                    System.ComponentModel.ListSortDirection.Descending); // Сортировка по убыванию
        } 

        private void buttonFilter_Click(object sender, EventArgs e) // Фильтрация по выбранному наименованию
        {
            TableLoad(PRINT_ALL + " AND " +
               $"[ActivityTable].[ActivityName]='{comboBoxActivityName.SelectedValue}'");
        }

        private void buttonViewAll_Click(object sender, EventArgs e) // Кнопка, которая показывает все даннные таблицы
        {
            TableLoad(PRINT_ALL);
        }

        private void buttonSearch_Click(object sender, EventArgs e) // Поиск по таблице
        {
            bool proverka = false;
            for(int i = 0; i < dataGridViewActivity.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridViewActivity.RowCount - 1; j++)
                {
                    dataGridViewActivity[i, j].Style.BackColor = Color.White;
                    dataGridViewActivity[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < dataGridViewActivity.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridViewActivity.RowCount - 1; j++)
                {
                    if(dataGridViewActivity[i, j].Value.ToString().IndexOf(textBoxCriteria.Text) != -1)
                    {
                        dataGridViewActivity[i, j].Style.BackColor = Color.AliceBlue;
                        dataGridViewActivity[i, j].Style.ForeColor = Color.Blue;
                        proverka = true;
                    }
                }
            }
            if(!proverka)
            {
                MessageBox.Show("Введенные данные не найдены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxActivityName_MouseEnter(object sender, EventArgs e) // Вывод подсказки
        {
            toolStripStatusLabelHint.Text = "Выберите наименование занятия для фильтрации";
        } 
        
        private void textBoxCriteria_MouseEnter(object sender, EventArgs e) // Вывод подсказки
        {
            toolStripStatusLabelHint.Text = "Введите критерий для поиска по таблице";
        } 
        private void comboBoxActivityName_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelHint.Text = " ";
        }
        private void textBoxCriteria_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelHint.Text = " ";
        }
        private void экспортДанныхToolStripMenuItem_Click(object sender, EventArgs e) // Экспорт таблицы в Excel
        {
            var iRow = 1;
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Report Activity";
            saveFile.Filter = "Excel files |= xlsx";
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                Excel.Application ExcelApp = new Excel.Application();
                Excel.Workbook ExcelBook;
                Excel.Worksheet ExcelSheet;
                ExcelBook = ExcelApp.Workbooks.Add();
                ExcelApp.Columns.ColumnWidth = 25;
                ExcelSheet =(Excel.Worksheet)ExcelBook.Sheets[1];
                ExcelSheet.Name = "Расписание занятий FITHIT";
                ExcelSheet.Cells[1,1] = "Код занятия";
                ExcelSheet.Cells[1,2] = "Имя тренера";
                ExcelSheet.Cells[1,3] = "Фамилия тренера";
                ExcelSheet.Cells[1,4] = "Фитнес-клуб";
                ExcelSheet.Cells[1,5] = "Занятие";
                ExcelSheet.Cells[1,6] = "Дата проведения";
                ExcelSheet.Cells[1,7] = "Время проведения";
                ExcelSheet.Cells[1,8] = "Длительность занятия";
                ExcelSheet.Cells[1,9] = "Стоимость";

                for(int i = 0; i < dataGridViewActivity.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridViewActivity.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dataGridViewActivity.Rows[i].Cells[j].Value.ToString();
                    }
                }
                ExcelApp.Rows[$"{iRow}:{iRow}"].Interior.Color = Color.LightBlue;
                ExcelApp.Visible = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e) // Удаление выбранного из занятий и привязанных к этому занятию клиентов
        {
            if (dataGridViewActivity.SelectedRows.Count > 0)
            {
                var Id = Convert.ToInt32(dataGridViewActivity.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value);
                if (MessageBox.Show(Get(Id), "Удалить", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string query = $"DELETE FROM CustomersTable WHERE ActivityId = {Id}";
                    ReadQuery(query);

                    query = $"DELETE FROM ActivityTable WHERE ID = {Id}";
                    ReadQuery(query);
                    TableLoad(PRINT_ALL);
                }
            }
            else
            {
                MessageBox.Show("Чтобы удалить запись выберите строку в которой она находиться!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReadQuery(string query)// Метод считывания запроса
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        private string Get(int ID) // Метод подтверждения удаления и вывода привязанных клиентов и занятия
        {
            string query = $"SELECT Name, Surname FROM CustomersTable WHERE ActivityId = {ID}";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            var sb = new StringBuilder();
            
            if (reader.HasRows) // если есть данные
            {
                sb.Append("Вы уверены что хотите удалить занятие?\nПосле удаления данного занятия удалятся такие клиенты как :\n");
                while (reader.Read()) // построчно считываем данные
                {
                    var name = reader.GetString(0);
                    var surname = reader.GetString(1);
                    sb.Append($"{name.Remove(name.IndexOf(' '))} {surname.Remove(surname.IndexOf(' '))}\n");
                }
            }
            else
            {
                sb.Append("Вы уверены что хотите удалить занятие?");
            }
            reader.Close();
            connection.Close();
            return sb.ToString();
        }
        private void TableLoad(string query) // Метод заполняющий dataGridView значениями при помощи запроса
        {
            dataGridViewActivity.Rows.Clear();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[9]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
            }
            reader.Close();

            foreach (string[] s in data)
                dataGridViewActivity.Rows.Add(s);

            connection.Close();

        }

        private void ActivityTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
