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
    public partial class AddDoctor : Form
    {
        SqlConnection connection;
        //string ConnectionString = @"Data Source=A311_10\SQL_E1118P1; Initial Catalog=Vet_BD; User ID=E1118P1; Password=1P8111E";
        //string ConnectionString = @"Data Source=АРТЕМ-ПК\SQLEXPRESS; Initial Catalog=Vet_BD; Integrated Security=true";

        public AddDoctor()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "insert into doctor(FIOd, id_spec, cabinet, time_start, time_end) " +
                                $"values('{textBoxFIO.Text}',{Convert.ToInt64(comboBox1.SelectedIndex + 1)} , {Convert.ToInt64(textBoxCab.Text)}, '{textBoxTimeS.Text}', '{textBoxTimeE.Text}'); ";

                using (connection = new SqlConnection(MyDataTransfer.ConnectionString))
                {
                    connection.Open();
                    // Создаем объект DataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, connection);
                    // Создаем объект Dataset
                    DataSet ds = new DataSet();
                    // Заполняем Dataset
                    adapter.Fill(ds);
                    connection.Close();

                    MessageBox.Show("Доктор успешно добавлен!");
                }
            }
            catch
            {
                MessageBox.Show("Неверно указаны данные!", "Ошибка");
            }
        }
    }
}
