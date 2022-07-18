using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProgettoRDF
{
    public partial class Login : Form
    {

        myDBconnection con = new myDBconnection();
        MySqlCommand command;
        MySqlDataAdapter da;
        DataTable dt;
        public Login()
        {
            InitializeComponent();
            con.Connect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Accedi_Click(object sender, EventArgs e)
        {
            string emailIN, passwordIN;

            emailIN = textEmail.Text;
            passwordIN = textPassword.Text;

            try
            {
                con.cn.Open();
                command = new MySqlCommand("Select * from utenti", con.cn);
                command.ExecuteNonQuery();
                dt = new DataTable();
                da = new MySqlDataAdapter(command);
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                con.cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
