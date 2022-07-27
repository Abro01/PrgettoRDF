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
        DataTable dt=new DataTable();

        public static string emailIN, passwordIN;

        public Login()
        {
            InitializeComponent();
            con.Connect();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Vuoi uscire?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.cn.Open();
                /*command = new MySqlCommand("Select * from utenti", con.cn);
                command.ExecuteNonQuery();
                dt = new DataTable();
                da = new MySqlDataAdapter(command);
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                con.cn.Close();*/
                string query = "SELECT * FROM utenti WHERE Email = '" + textEmail.Text + "' AND Password = MD5('" + textPassword.Text + "')";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, con.cn);

                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    emailIN = textEmail.Text;
                    passwordIN = textPassword.Text;
                    LoginInfo.UserID = textEmail.Text;
                    MenuForm form2 = new MenuForm();
                    form2.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Dati inseriti errati", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textEmail.Clear();
                    textPassword.Clear();

                    textEmail.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.cn.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textEmail.Clear();
            textPassword.Clear();

            textEmail.Focus();
        }

        private void lnkRegistrazione_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrazione reg = new Registrazione();
            reg.Show();
            this.Hide();
        }

    }
}
