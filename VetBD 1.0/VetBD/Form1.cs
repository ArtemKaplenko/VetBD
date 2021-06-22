using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetBD
{
    public partial class Form1 : Form
    {
        bool showP = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (showP)
            {
                textBox2.UseSystemPasswordChar = false;
                showP = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                showP = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" & textBox2.Text=="12345")
            {
                Form MainForm = new Form2();
                MainForm.Show();
                this.Hide();
            }
            else if(textBox1.Text == "doctor" & textBox2.Text=="12345")
            {
                Form DoctorForm = new DoctorForm();
                DoctorForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }
    }
}
