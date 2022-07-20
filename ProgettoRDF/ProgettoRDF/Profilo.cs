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
    public partial class Profilo : Form
    {
        myDBconnection con = new myDBconnection();
        public Profilo()
        {
            InitializeComponent();
            con.cn.Open();
            string query = "SELECT * FROM utenti WHERE email = '" + LoginInfo.UserID + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, con.cn);
        }
    }
}
