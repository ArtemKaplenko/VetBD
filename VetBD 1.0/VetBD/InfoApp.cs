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
    public partial class InfoApp : Form
    {
        public InfoApp()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string sqlApp = "select appointment.id, FIOd as 'ФИО врача', animal.kind as 'вид', animal.breed as 'порода', animal.name as 'кличка', animal.age as 'возраст', diagn, nazn" +
                           " from appointment, doctor, specialty, animal, client" +
                          $" where  appointment.id ={Convert.ToInt64(MyDataTransfer.ID)}" +
                           " and doctor.id = id_doc and client.id = appointment.id_client and animal.id = appointment.id_animal and specialty.id = doctor.id_spec;";

            //string query = "select animal.id, FIO as 'ФИО', kind as 'вид', breed as 'порода', name as 'кличка', age as 'лет', phone as 'телефон', address as 'адрес'" +
            //            " from animal, client" +
            //           $" where client.id=id_client and animal.id={Convert.ToInt64(MyDataTransfer.ID)};";

            using (SqlConnection connection = new SqlConnection(MyDataTransfer.ConnectionString))
            {
                connection.Open();
                SqlCommand commmand = new SqlCommand(sqlApp, connection);
                SqlDataReader read = commmand.ExecuteReader();
                while (read.Read())
                {
                    textBoxKind.Text = read["вид"].ToString();
                    textBoxBreed.Text = read["порода"].ToString();
                    textBoxName.Text = read["кличка"].ToString();
                    textBoxAge.Text = read["возраст"].ToString();
                    textBoxFIOd.Text = read["ФИО врача"].ToString();
                    textBoxDiag.Text = read["diagn"].ToString();
                    textBoxNazn.Text = read["nazn"].ToString();
                }
                read.Close();
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlUpdateApp = "update appointment" +
                                $" set diagn = '{textBoxDiag.Text}'," +
                                $" nazn = '{textBoxNazn.Text}'" +
                                 $" where id = {Convert.ToInt64(MyDataTransfer.ID)}; ";

            using (SqlConnection connection = new SqlConnection(MyDataTransfer.ConnectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sqlUpdateApp, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                //// Заполняем Dataset
                adapter.Fill(ds);
                connection.Close();
            }
        }
    }
}
