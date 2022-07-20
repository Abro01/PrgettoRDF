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

        public MenuForm()
        {
            InitializeComponent();
            
        }

        private void btnProva_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LoginInfo.UserID);
        }

        private void btnProfilo_Click(object sender, EventArgs e)
        {
            Profilo reg = new Profilo();
            reg.Show();
            this.Hide();
        }
    }
}
