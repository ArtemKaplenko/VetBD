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
    public partial class Appointment : Form
    {
        
        public Appointment()
        {
            InitializeComponent();
            labelID.Text += MyDataTransfer.ID.ToString();
            LoadData();
        }

        private void LoadData()
        {

            using (SqlConnection connection = new SqlConnection(MyDataTransfer.ConnectionString))
            {
                string query = "select * from specialty;";

                connection.Open();
                SqlCommand commmand = new SqlCommand(query, connection);
                SqlDataReader read = commmand.ExecuteReader();
                while (read.Read())
                {
                    comboBox1.Items.Add(read["spec"].ToString());
                }
                read.Close();
                connection.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryDoc = "select doctor.id, FIOd as 'ФИО', spec as 'специальность', cabinet as 'кабинет', time_start as 'прием с', time_end as 'прием до'"+
                              " from doctor, specialty"+
                              $" where id_spec = { Convert.ToInt64(comboBox1.SelectedIndex + 1) } and specialty.id = id_spec;";

            using (SqlConnection connection = new SqlConnection(MyDataTransfer.ConnectionString))
            {
                connection.Open();

                // вывод специалистов
                SqlDataAdapter adapterD = new SqlDataAdapter(queryDoc, connection);
                DataSet dsDoc = new DataSet();
                adapterD.Fill(dsDoc);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.DataSource = dsDoc.Tables[0];
                dataGridView1.ReadOnly = true;

                connection.Close();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query= "insert into appointment(id_doc, id_client, id_animal, time_, dat)"+
                         $" values({Convert.ToInt64(dataGridView1[0, dataGridView1.CurrentRow.Index].Value)}, {Convert.ToInt64(MyDataTransfer.IDclient)}, {Convert.ToInt64(MyDataTransfer.ID)}, '{comboBox2.SelectedItem.ToString()}', '{dateTimePicker1.Value.ToShortDateString()}');";

            using (SqlConnection connection = new SqlConnection(MyDataTransfer.ConnectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                connection.Close();

                MessageBox.Show("Запись на прием добавлена!");
            }
        }
    }
}
