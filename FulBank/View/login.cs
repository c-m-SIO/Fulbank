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
using FulBank.Model;

namespace FulBank
{
    public partial class login : Form
    {
        private FB_VM.connexion_view_model ConnexionViewModel;
        public login()
        {
            InitializeComponent();
            ConnexionViewModel = new FB_VM.connexion_view_model();
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
                MessageBox.Show("Le champ USERNAME doit �tre rempli.");
            }
            else if (password.Text == "")
            {
                MessageBox.Show("Le champ PASSWORD doit �tre rempli.");
            }
            else
            {
                switch (ConnexionViewModel.testconnexion(Username.Text, password.Text))
                {
                    case "success":
                        //Client Ceclient = new Client(ConnexionViewModel.getid(Username.Text),Username.Text,password.Text);
                        //ChoixCompte page_choixcompte = new ChoixCompte(Client Ceclient);
                        //page_choixcompte.Show();
                        this.Hide();
                        MessageBox.Show("Connexion r�ussie");
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