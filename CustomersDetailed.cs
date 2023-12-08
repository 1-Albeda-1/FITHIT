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

namespace FITHIT
{
    public partial class CustomersDetailed : Form
    {
        public CustomersDetailed()
        {
            InitializeComponent();
        }
        private string PRINT_ALL = "SELECT " + // Запроос на заполнение таблицы данными из БД
                "[CustomersTable].[Name], " +
                "[CustomersTable].[Surname], " +
                "[ActivityNameTable].[ActivityName], " +
                "[ActivityTable].[FitClub], " +
                "[ActivityTable].[Date], " +
                "[ActivityNameTable].[Cost], " +
                "[CustomersTable].[SeasonTTF] " +
                "FROM " +
                "[ActivityNameTable], " +
                "[ActivityTable], " +
                "[CustomersTable] " +
                "WHERE " +
                "[ActivityTable].[ActivityNameID]=[ActivityNameTable].[ID] AND " +
                "[CustomersTable].[ActivityId]=[ActivityTable].[ID]";

        private string connectionString = "Data Source=SMIRNOVAPC;Initial Catalog=FitClubDB;Integrated Security=True";

        private void CustomersList_Load(object sender, EventArgs e)
        {

            TableLoad(PRINT_ALL);
        }
        private void TableLoad(string query) // Метод заполняющий dataGridView значениями при помощи запроса
        {
            dataGridViewCustActivity.Rows.Clear();
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
                dataGridViewCustActivity.Rows.Add(s);

            connection.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var iRow = 1;
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Report Details";
            saveFile.Filter = "Excel files |= xlsx";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                Excel.Application ExcelApp = new Excel.Application();
                Excel.Workbook ExcelBook;
                Excel.Worksheet ExcelSheet;
                ExcelBook = ExcelApp.Workbooks.Add();
                ExcelApp.Columns.ColumnWidth = 25;
                ExcelSheet = (Excel.Worksheet)ExcelBook.Sheets[1];
                ExcelSheet.Name = "Детальная сводка";
                ExcelSheet.Cells[1, 1] = "Имя";
                ExcelSheet.Cells[1, 2] = "Фамилия";
                ExcelSheet.Cells[1, 3] = "Занятие";
                ExcelSheet.Cells[1, 4] = "Фитнес-клуб";
                ExcelSheet.Cells[1, 5] = "Дата проведения";
                ExcelSheet.Cells[1, 6] = "Стоимость";
                ExcelSheet.Cells[1, 7] = "Наличие абонемента";

                for (int i = 0; i < dataGridViewCustActivity.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewCustActivity.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dataGridViewCustActivity.Rows[i].Cells[j].Value.ToString();
                    }
                }
                ExcelApp.Rows[$"{iRow}:{iRow}"].Interior.Color = Color.LightBlue;
                ExcelApp.Visible = true;
            }
        }
    }
}
