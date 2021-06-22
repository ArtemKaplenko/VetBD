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
    public partial class Form2 : Form
    {
        //string ConnectionString = @"Data Source=АРТЕМ-ПК\SQLEXPRESS; Initial Catalog=Vet_BD; Integrated Security=true";
        //string ConnectionString = @"Data Source=A311_10\SQL_E1118P1; Initial Catalog=Vet_BD; User ID=E1118P1; Password=1P8111E";

        public Form2()
        {
            InitializeComponent();
            //загрузка данных из БД
            LoadData();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // завершене всех процессов
            Application.Exit();
        }

        //загркзка данных из БД
        private void LoadData()
        {
              //string ConnectionString = @"Data Source=АРТЕМ-ПК\SQLEXPRESS; Initial Catalog=Vet_BD; Integrated Security=true";
            //string ConnectionString = @"Data Source=A311_10\SQL_E1118P1; Initial Catalog=Vet_BD; User ID=E1118P1; Password=1P8111E";
           
            // sql запрос
            string query = "select animal.id, FIO as 'ФИО', kind as 'вид', breed as 'порода', name as 'кличка', age as 'лет', phone as 'телефон', address as 'адрес'"+
                           " from animal, client"+
                           " where client.id = id_client; ";

            string queryDoc = "select doctor.id, FIOd as 'ФИО', spec as 'специальность', cabinet as 'кабинет', time_start as 'прием с', time_end as 'прием до' " +
                             "from doctor, specialty " +
                             "where specialty.id = id_spec; ";

            string queryAp = "select appointment.id, FIO as 'ФИО клиента', FIOd as 'ФИО врача', spec as 'специальность', cabinet as 'кабинет', time_ as 'время', dat as 'дата'" +
                            " from appointment, doctor, specialty, animal, client" +
                            " where doctor.id = id_doc and client.id = appointment.id_client and animal.id = appointment.id_animal and specialty.id = doctor.id_spec; ";
                

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
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.ReadOnly = true;
                //dataGridView1.Columns["Id"].ReadOnly = true;

                // вывод докторов
                SqlDataAdapter adapterD = new SqlDataAdapter(queryDoc, connection);
                DataSet dsDoc = new DataSet();
                adapterD.Fill(dsDoc);
                dataGridViewDoctor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewDoctor.AllowUserToAddRows = false;
                dataGridViewDoctor.DataSource = dsDoc.Tables[0];
                dataGridViewDoctor.ReadOnly = true;

                // вывод приёмов
                SqlDataAdapter adapterAp = new SqlDataAdapter(queryAp, connection);
                DataSet dsAp = new DataSet();
                adapterAp.Fill(dsAp);
                dataGridViewAp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewAp.AllowUserToAddRows = false;
                dataGridViewAp.DataSource = dsAp.Tables[0];
                dataGridViewAp.ReadOnly = true;

                connection.Close();
            }
        }

        // поиск по dataGridView
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (radioButtonID.Checked == true)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                    if (dataGridView1[0, i].FormattedValue.ToString().
                        Contains(searchTextBox.Text.Trim()))
                    {
                        dataGridView1.CurrentCell = dataGridView1[0, i];
                        return;
                    }
            }
            if (radioButtonFIO.Checked == true)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                    if (dataGridView1[1, i].FormattedValue.ToString().
                        Contains(searchTextBox.Text.Trim()))
                    {
                        dataGridView1.CurrentCell = dataGridView1[0, i];
                        return;
                    }
            }
        }

        // открытие окна для создания новой карты пациента
        private void NewCardButton_Click(object sender, EventArgs e)
        {
            Form NewCard = new NewCard();
            NewCard.ShowDialog();
            LoadData();
        }

        // удаление карточки
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string sqlStr = "delete from animal"
                            + $" where id = {Convert.ToInt64(dataGridView1[0, dataGridView1.CurrentRow.Index].Value)}; ";
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

        // удаление клиента
        private void DeleteClientButton_Click(object sender, EventArgs e)
        {
            Form DeleteClient = new DeleteClient();
            DeleteClient.ShowDialog();
            LoadData();
        }

        // просмотр и изменение карточкм
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            MyDataTransfer.ID = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            Form UpdateCards = new UpdateCardcs();
            UpdateCards.ShowDialog();
            LoadData();
        }

        private void DocSearchbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewDoctor.RowCount; i++)
                if (dataGridViewDoctor[1, i].FormattedValue.ToString().
                    Contains(DocTextBox.Text.Trim()))
                {
                    dataGridViewDoctor.CurrentCell = dataGridViewDoctor[0, i];
                    return;
                }
        }

        // удаление врача
        private void DeleteDocButton_Click(object sender, EventArgs e)
        {
            // запрос на удаление по id, которое берется из dataGridView
            string sqlStr = "delete from doctor"
                            + $" where id = {Convert.ToInt64(dataGridViewDoctor[0, dataGridViewDoctor.CurrentRow.Index].Value)}; ";
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

        // добавление врача
        private void AddDocButton_Click(object sender, EventArgs e)
        {
            Form AddDoctor = new AddDoctor();
            AddDoctor.ShowDialog();
            LoadData();
        }

        private void ApButton_Click(object sender, EventArgs e)
        {
            MyDataTransfer.ID = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);


            string sql= "select id_client from animal"+
                      $" where id = { Convert.ToInt64(MyDataTransfer.ID)};";
            using (SqlConnection connection = new SqlConnection(MyDataTransfer.ConnectionString))
            {
                connection.Open();
                SqlCommand commmand = new SqlCommand(sql, connection);
                SqlDataReader read = commmand.ExecuteReader();
                while (read.Read())
                {
                    MyDataTransfer.IDclient = Convert.ToInt32(read["id_client"].ToString());
                }
                read.Close();
                connection.Close();
            }

            Form Appointment = new Appointment();
            Appointment.ShowDialog();
            LoadData();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MyDataTransfer.ID = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            Form UpdateCards = new UpdateCardcs();
            UpdateCards.ShowDialog();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queryAppDel = "delete from appointment" +
                               $" where id = {Convert.ToInt64(dataGridViewAp[0, dataGridViewAp.CurrentRow.Index].Value)}; ";
            using (SqlConnection connection = new SqlConnection(MyDataTransfer.ConnectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(queryAppDel, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                LoadData();
                connection.Close();
            }
        }

        private void buttonApSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewAp.RowCount; i++)
                if (dataGridViewAp[1, i].FormattedValue.ToString().
                    Contains(textBoxApSearch.Text.Trim()))
                {
                    dataGridViewAp.CurrentCell = dataGridViewAp[0, i];
                    return;
                }
        }
    }
}
