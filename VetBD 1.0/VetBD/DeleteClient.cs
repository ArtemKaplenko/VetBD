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

namespace VetBD
{
    public partial class DeleteClient : Form
    {
        //string ConnectionString = @"Data Source=АРТЕМ-ПК\SQLEXPRESS; Initial Catalog=Vet_BD; Integrated Security=true";
        //string ConnectionString = @"Data Source=A311_10\SQL_E1118P1; Initial Catalog=Vet_BD; User ID=E1118P1; Password=1P8111E";

        public DeleteClient()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            /*  string ConnectionString = @"Data Source=АРТЕМ-ПК\SQLEXPRESS; Initial Catalog=Vet_BD; Integrated Security=true";*/
            //string ConnectionString = @"Data Source=A311_10\SQL_E1118P1; Initial Catalog=Vet_BD; User ID=E1118P1; Password=1P8111E";

            // sql запрос
            string query = "select id, FIO as 'ФИО', phone as 'телефон', address as 'адрес' from client;";

            using (SqlConnection connection = new SqlConnection(MyDataTransfer.ConnectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridViewClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewClient.AllowUserToAddRows = false;
                dataGridViewClient.DataSource = ds.Tables[0];
                dataGridViewClient.ReadOnly = true;
                //dataGridView1.Columns["Id"].ReadOnly = true;
                connection.Close();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string sqlStr = "delete from client"
                        + $" where id = {Convert.ToInt64(dataGridViewClient[0, dataGridViewClient.CurrentRow.Index].Value)}; ";
            using (SqlConnection connection = new SqlConnection(MyDataTransfer.ConnectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                LoadData();
                connection.Close();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewClient.RowCount; i++)
                if (dataGridViewClient[1, i].FormattedValue.ToString().
                    Contains(textBoxSearch.Text.Trim()))
                {
                    dataGridViewClient.CurrentCell = dataGridViewClient[0, i];
                    return;
                }
        }
    }
}
