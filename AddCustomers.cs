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
    public partial class AddCustomers : Form
    {
        public AddCustomers()
        {
            InitializeComponent();
            ToolTip tip = new ToolTip();
            tip.SetToolTip(nameTextBox, "Введите имя клиента"); // Вывод подсказок
            tip.SetToolTip(surnameTextBox, "Введите фамилию клиента");
            tip.SetToolTip(phoneMaskedTextBox, "Введите номер телефона клиента");
        }

        private void AddCustomers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitClubDBDataSetHosting.ActivityNameTable". При необходимости она может быть перемещена или удалена.
            this.activityNameTableTableAdapter.Fill(this.fitClubDBDataSet.ActivityNameTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitClubDBDataSetHosting.ActivityTable". При необходимости она может быть перемещена или удалена.
            this.activityTableTableAdapter.Fill(this.fitClubDBDataSet.ActivityTable);
        }
        private void seasonTTFComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(seasonTTFComboBox.SelectedIndex == 1)
            {
                seasonTicketComboBox.Enabled = false;
                seasonTicketComboBox.Text = " ";
            }
            else
            {
                seasonTicketComboBox.Enabled = true;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e) // Кнопка добавить запись
        {
             if (nameTextBox.Text.Length != 0 && surnameTextBox.Text.Length != 0 && phoneMaskedTextBox.Text.Length != 0)
             {
                string query = $"INSERT INTO CustomersTable VALUES('{nameTextBox.Text}', '{surnameTextBox.Text}', '{phoneMaskedTextBox.Text}', {activityidComboBox.SelectedValue}, '{seasonTTFComboBox.SelectedItem}', '{seasonTicketComboBox.SelectedItem}')"; // Запрос на добавление данных введенных в поля в БД
                string connectionString = "Data Source=FitClubDB.mssql.somee.com;Initial Catalog=FitClubDB;User ID=Albeda1310_SQLLogin_1;Password=qz6kfq6fgy";

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                connection.Close();
             }
             else
            {
                MessageBox.Show("Пожалуйста заполните все поля перед добалением!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e) // Проверка на ввод только символов
        {
            char l = e.KeyChar;
            if (l < 'А' || l > 'я')
            {
                e.Handled = true;
            }
        }

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e) // Проверка на ввод только символов
        {
            char l = e.KeyChar;
            if (l < 'А' || l > 'я')
            {
                e.Handled = true;
            }
        }

    }
}
