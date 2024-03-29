﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FITHIT
{
    public partial class AuthorizationForm : Form
    {
       
        public AuthorizationForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }
        private string connectionString = "Data Source=SMIRNOVAPC;Initial Catalog=FitClubDB;Integrated Security=True";

        private void AuthorizationForm_Load(object sender, EventArgs e) // Ввод вмето пароля символа: '*'
        {
            textBoxPassword.PasswordChar = '*';
        }
        private void buttonOk_Click(object sender, EventArgs e) // Обработчик ввода логина и пароля
        {
            var loginUser = textBoxLogin.Text;
            var passwordUser = textBoxPassword.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select ID, Login, Password from UsersTable where Login = '{loginUser}' and Password = '{passwordUser}'"; // Запрос на сравнение введенного текста с БД 
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(querystring, conn);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1) // Сравнение прошло успешно
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Users.User = $"Пользователь: {loginUser}";
                ActivityTable activityTable = new ActivityTable();
                this.Hide();
                activityTable.Show();
            }
            else // Пароль или логин не совпали с БД
            {
                MessageBox.Show("Такого аккаунта не существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuest_Click(object sender, EventArgs e) // Вход пользователя в кацестве гостя
        {
            Users.User = "Пользователь: Гость";
            ActivityTable activityTable = new ActivityTable();
            this.Hide();
            activityTable.Show();
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
