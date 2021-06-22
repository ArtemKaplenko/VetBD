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
    public partial class NewCard : Form
    {
        SqlConnection connection;
        //string ConnectionString = @"Data Source=A311_10\SQL_E1118P1; Initial Catalog=Vet_BD; User ID=E1118P1; Password=1P8111E";
        //string ConnectionString = @"Data Source=АРТЕМ-ПК\SQLEXPRESS; Initial Catalog=Vet_BD; Integrated Security=true";

        public NewCard()
        {
            InitializeComponent();
            LoadData();
        }

        //загркзка данных из БД
        private void LoadData()
        {
            /*  string ConnectionString = @"Data Source=АРТЕМ-ПК\SQLEXPRESS; Initial Catalog=Vet_BD; Integrated Security=true";*/
            //string ConnectionString = @"Data Source=A311_10\SQL_E1118P1; Initial Catalog=Vet_BD; User ID=E1118P1; Password=1P8111E";
            
            // sql запрос
            string query = "select id, FIO as 'ФИО', phone as 'телефон', address as 'адрес' from client;";

            using (connection = new SqlConnection(MyDataTransfer.ConnectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.ReadOnly = true;
                //dataGridView1.Columns["Id"].ReadOnly = true;
                connection.Close();
            }
        }

        private void FIObutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
                if (dataGridView1[1, i].FormattedValue.ToString().
                    Contains(SearchTextBox.Text.Trim()))
                {
                    dataGridView1.CurrentCell = dataGridView1[0, i];
                    return;
                }
        }

        // добавление животного
        private void AddAnimalButton_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "insert into animal(kind, breed, name, age, id_client) " +
                           $"values('{textBoxKind.Text}', '{textBoxBreed.Text}', '{textBoxName.Text}',{Convert.ToInt64(textBoxAge.Text)},{Convert.ToInt64(textBoxID.Text)});";
   
            using (connection = new SqlConnection(MyDataTransfer.ConnectionString))
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

                MessageBox.Show("Картачка животного содана!");
            }
            }
            catch
            {
                MessageBox.Show("Неверно указаны данные!", "Ошибка");
            }

        }

        // добавление клиента
        private void AddClientButton_Click(object sender, EventArgs e)
        {
            string sqlStr = "insert into client(FIO, phone, address) " +
                            $"values('{textBoxFIO.Text}', '{textBoxPhone.Text}', '{textBoxAddress.Text}'); ";
            using (connection = new SqlConnection(MyDataTransfer.ConnectionString))
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

                MessageBox.Show("Клиент добавлен!");
            }

        }
    }
}
