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
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
            LoadData();
        }

        //загркзка данных из БД
        private void LoadData()
        {
            string query = "select animal.id, FIO as 'ФИО', kind as 'вид', breed as 'порода', name as 'кличка', age as 'лет', phone as 'телефон', address as 'адрес'" +
                          " from animal, client" +
                          " where client.id = id_client; ";

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

                connection.Close();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (radioButtonID.Checked == true)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                    if (dataGridView1[0, i].FormattedValue.ToString().
                        Contains(textBoxFIO.Text.Trim()))
                    {
                        dataGridView1.CurrentCell = dataGridView1[0, i];
                        return;
                    }
            }
            if (radioButtonFIO.Checked == true)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                    if (dataGridView1[1, i].FormattedValue.ToString().
                        Contains(textBoxFIO.Text.Trim()))
                    {
                        dataGridView1.CurrentCell = dataGridView1[0, i];
                        return;
                    }
            }
        }

        private void DoctorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // завершене всех процессов
            Application.Exit();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            MyDataTransfer.ID = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
            Form UpdateCards = new UpdateCardcs();
            UpdateCards.ShowDialog();
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
            string queryAp = "select appointment.id, FIO as 'ФИО клиента', FIOd as 'ФИО врача', spec as 'специальность', cabinet as 'кабинет', time_ as 'время', dat as 'дата'" +
                          " from appointment, doctor, specialty, animal, client" +
                         $" where doctor.id ={Convert.ToInt64(textBoxIDdoc.Text)}" +
                          " and doctor.id = id_doc and client.id = appointment.id_client and animal.id = appointment.id_animal and specialty.id = doctor.id_spec;";

            using (SqlConnection connection = new SqlConnection(MyDataTransfer.ConnectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(queryAp, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridViewApp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewApp.AllowUserToAddRows = false;
                dataGridViewApp.DataSource = ds.Tables[0];
                dataGridViewApp.ReadOnly = true;

                connection.Close();
            }
        }

        private void buttonSApp_Click(object sender, EventArgs e)
        {
                for (int i = 0; i < dataGridViewApp.RowCount; i++)
                    if (dataGridViewApp[1, i].FormattedValue.ToString().
                        Contains(textBoxSearchApp.Text.Trim()))
                    {
                        dataGridViewApp.CurrentCell = dataGridViewApp[0, i];
                        return;
                    }
        }

        private void buttonShowApp_Click(object sender, EventArgs e)
        {
            try
            {
                MyDataTransfer.ID = Convert.ToInt32(dataGridViewApp[0, dataGridViewApp.CurrentRow.Index].Value);
                Form InfoApp = new InfoApp();
                InfoApp.ShowDialog();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не выбран прием!");
            }
        }

        private void dataGridViewApp_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MyDataTransfer.ID = Convert.ToInt32(dataGridViewApp[0, dataGridViewApp.CurrentRow.Index].Value);
            Form InfoApp = new InfoApp();
            InfoApp.ShowDialog();
            LoadData();
        }
    }
}
