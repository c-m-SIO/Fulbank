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
using FulBank.Model;
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
                MessageBox.Show("Le champ USERNAME doit être remplie.");
            }
            else if (password.Text == "")
            {
                MessageBox.Show("Le champ PASSWORD doit être remplie.");
            }
            else
            {
            }

            MessageBox.Show(ConnexionViewModel.testconnexion());

                string about_this_user_query = "select * from user where username = " + Username.Text + ";";

                /* about_this_user == mysql.execute(about_this_user_query); */

                if (null == "" /*about_this_user*/)
                {
                    MessageBox.Show("Cet utilisateur n'existe pas.");
                }
                else
                {
                    string wanted_password_request = ("select password from user where username =" + Username.Text + ";");
                }

                    /* wanted_password = mysql.execute(wanted_password_request) */

                    /*if (HashPasword(password.Text, out var salt) == ""/*wanted_password*/
                    //{
                        /* rediriger vers la vue de choix de compte, parmis les comptes correspondants à l'username */
                    /*}
                    else
                    {
                        MessageBox.Show("Mauvais mot de passe.");
                    }*/
                
            }
        }
    }