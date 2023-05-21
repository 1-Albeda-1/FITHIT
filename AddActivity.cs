using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FITHIT
{
    public partial class AddActivity : Form
    {
        public AddActivity()
        {
            InitializeComponent();
            ToolTip tip = new ToolTip();
            tip.SetToolTip(nameTTextBox, "Введите имя тренера, который будет проводить занятие"); // Вывод подсказок
            tip.SetToolTip(surnameTTextBox, "Введите фамилию тренера, который будет проводить занятие");
        }
        private string connectionString = "Data Source=FitClubDB.mssql.somee.com;Initial Catalog=FitClubDB;User ID=Albeda1310_SQLLogin_1;Password=qz6kfq6fgy";
        private void AddActivity_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitClubDBDataSetHosting.ActivityNameTable". При необходимости она может быть перемещена или удалена.
            this.activityNameTableTableAdapter.Fill(this.fitClubDBDataSet.ActivityNameTable);
        }

        private void buttonAdd_Click(object sender, EventArgs e) // Кнопка добавить запись
        {
            if (nameTTextBox.Text.Length != 0 && surnameTTextBox.Text.Length != 0)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT ActivityName FROM ActivityNameTable WHERE [ActivityNameTable].[ID] = '{activityComboBox.SelectedValue}'", connection);
                String ActivityName = (string)command.ExecuteScalar();
                string query = $"INSERT INTO ActivityTable VALUES('{nameTTextBox.Text}', '{surnameTTextBox.Text}', '{fitclubComboBox.SelectedItem}', '{dateDateTimePicker.Text}', '{timeComboBox.SelectedItem}', '{activityComboBox.SelectedValue}', '{startTimecomboBox.Text}', '{ActivityName}')"; // Запрос на добавление данных введенных в поля в БД
                connection.Close();
                ReadQuery(query);
            }
            else
            {
                MessageBox.Show("Пожалуйста заполните все поля перед добалением!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void surnameTTextBox_KeyPress(object sender, KeyPressEventArgs e) // Проверка на ввод только символов
        {
            char l = e.KeyChar;
            if (l < 'А' || l > 'я')
            {
                e.Handled = true;
            }
        }

        private void nameTTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l < 'А' || l > 'я')
            {
                e.Handled = true;
            }
        }

        private void dateDateTimePicker_ValueChanged(object sender, EventArgs e) // Проверка на ввод даты (не позже сегодняшней)
        {
            if (dateDateTimePicker.Value < DateTime.Today)
            {
                dateDateTimePicker.Value = DateTime.Today;
            }
        }

    }
}
