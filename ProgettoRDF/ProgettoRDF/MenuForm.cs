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
    public partial class MenuForm : Form
    {

        myDBconnection con = new myDBconnection();
        MySqlCommand command;
        MySqlDataAdapter da;
        DataTable dt = new DataTable();
        string id;

        public MenuForm()
        {
            InitializeComponent();
            
        }

        private void btnProva_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LoginInfo.UserID);
            
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnProfilo_Click(object sender, EventArgs e)
        {
            /*;
            reg.Show();
            this.Hide();*/

            Profilo profilo = new Profilo();
            profilo.Show();
            this.Hide();

            /*
            try
            {
                con.cn.Open();
                /*command = new MySqlCommand("Select * from utenti", con.cn);
                command.ExecuteNonQuery();
                dt = new DataTable();
                da = new MySqlDataAdapter(command);
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                con.cn.Close()
                string query = "SELECT * FROM utenti WHERE ID = '" + id + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, con.cn);

                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    
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
                */
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login logout = new Login();
            logout.Show();
            this.Hide();
            con.cn.Close();
        }
    }
}
