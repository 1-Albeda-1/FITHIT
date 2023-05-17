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

namespace Курсовая_СмирноваКристина_ИП_20_3
{
    public partial class AddActivity : Form
    {
        public AddActivity()
        {
            InitializeComponent();
            ToolTip tip = new ToolTip();
            tip.SetToolTip(nameTTextBox, "Введите имя тренера, который будет проводить занятие"); // Вывод подсказок
            tip.SetToolTip(surnameTTextBox, "Введите фамилию тренера, который будет проводить занятие");
            tip.SetToolTip(costTextBox, "Введите стоимость занятия");
        }

        private void AddActivity_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitClubDBDataSet.ActivityTable". При необходимости она может быть перемещена или удалена.
            this.activityTableAdapter.Fill(this.fitClubDBDataSet.ActivityTable);
        }

        private void buttonAdd_Click(object sender, EventArgs e) // Кнопка добавить запись
        {
            activityBindingSource.AddNew();

        }
        private void buttonClear_Click(object sender, EventArgs e) // Кнопка очистки полей
        {
            nameTTextBox.Clear();
            surnameTTextBox.Clear();
            costTextBox.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e) // Кнопка сохранить запись
        {
            if (nameTTextBox.Text.Length != 0 && surnameTTextBox.Text.Length != 0 && costTextBox.Text.Length != 0)
            {
                this.Validate();
                this.activityBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.fitClubDBDataSet);
            }
            else
            {
                MessageBox.Show("Пожалуйста заполните все поля перед сохранением!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void costTextBox_KeyPress(object sender, KeyPressEventArgs e) // Проверка на ввод только цифр
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == '.') && (costTextBox.Text.IndexOf(".") == -1) && (costTextBox.Text.Length != 0)))
            {
                if (e.KeyChar != (char)Keys.Back) e.Handled = true;
            }
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
