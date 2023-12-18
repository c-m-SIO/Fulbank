using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.Collections.Immutable;
using System.Security.Cryptography;
using FB_VM = FulBank.ViewModel;

namespace FulBank
{
    public partial class login : Form
    {
        private FB_VM.connexion_view_modle ConnexionViewModel;
        public login()
        {
            InitializeComponent();
            ConnexionViewModel = new FB_VM.connexion_view_modle();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click/* bouton_login */(object sender, EventArgs e)
        {

            if (Username.Text == "")
            {
                MessageBox.Show("Le champ USERNAME doit être rempli.");
            }
            else if (password.Text == "")
            {
                MessageBox.Show("Le champ PASSWORD doit être rempli.");
            }
            else
            {
                switch (ConnexionViewModel.testconnexion(Username.Text, password.Text))
                {
                    case "success":
                        MessageBox.Show("réussie");
                        break;
                    case "badpwd":
                        MessageBox.Show("Mauvais mot de passe");
                        break;
                    case "erreur":
                        MessageBox.Show("L'utilisateur " + Username.Text + " n'existe pas");
                        break;
                }
            }
        }
        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}