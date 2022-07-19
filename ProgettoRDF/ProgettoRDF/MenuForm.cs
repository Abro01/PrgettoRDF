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
        string email_utente, password_utente;
        MySqlCommand query;
        MySqlDataAdapter da;
        DataTable dt = new DataTable();
        myDBconnection con = new myDBconnection();
        public MenuForm(TextBox valore1, TextBox valore2)
        {
            con.cn.Open();
            InitializeComponent();
            email_utente = valore1.Text;
            password_utente = valore2.Text;

            query = new MySqlCommand("SELECT * FROM utenti WHERE email = '" + email_utente + "' AND password = '" + password_utente + "'");

            query.ExecuteNonQuery();
            da = new MySqlDataAdapter(query);
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            con.cn.Close();

        }

        private void btProva_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LoginInfo.UserID);
        }
    }
}
