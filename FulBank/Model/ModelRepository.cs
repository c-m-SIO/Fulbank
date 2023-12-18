using MySqlConnector;
<<<<<<< HEAD
using System.Data.SqlClient;
=======
using System.Data;
>>>>>>> f51b3a1f704be5ae7904b249e407a7c799c051a9
using System.Data.SQLite;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FulBank.Model
{
    internal class ModelRepository
    {
<<<<<<< HEAD
        private string IPDB = "172.16.119.7";
        private string UserDB = "mathieu";
        private string PasswordDB = "squeezie";
        private string DatabaseDB = "fulbank";
        public string GetMdpBd(string Username)
=======
        private MySqlConnection connexion;
        public ModelRepository()
>>>>>>> f51b3a1f704be5ae7904b249e407a7c799c051a9
        {
            using (MySqlConnection connexion = new MySqlConnection())
            {
<<<<<<< HEAD
                
                string stringconnexion = @"server=" + IPDB + ";userid=" + UserDB + ";password=" + PasswordDB + ";database=" + DatabaseDB;
                connexion.ConnectionString = stringconnexion;
                try
                {
                    connexion.Open();
                    string query = "Select C.password from Client C where C.prenom = @Username;";
                    MySqlCommand cmd = new MySqlCommand(query, connexion);
                    cmd.Parameters.AddWithValue("@Username", Username);
                    MySqlDataReader reader = cmd.ExecuteReader();
=======
                Server = "172.16.119.7",
                UserID = "mathieu",
                Password = "squeezie",
                Database = "fulbank",
            };
>>>>>>> f51b3a1f704be5ae7904b249e407a7c799c051a9

                    while (reader.Read())
                    {
                        return (string)reader["password"];
                    }

<<<<<<< HEAD
                }
                catch
                {
                    Console.WriteLine("Impossible de se connecter à la base de donnée");
                }

            }return "erreur";
=======
            try
            {
                connexion.Open();
                //MessageBox.Show("reussie");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
>>>>>>> f51b3a1f704be5ae7904b249e407a7c799c051a9
        }

        public DataTable recupCompteDb()
        {
           
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Compte", connexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                

            return dataTable;

                //foreach (DataRow row in dataTable.Rows)
                //{
                //    int rib = Convert.ToInt32(row["RIB"]);
                //    string nom = row["nom"].ToString();
                //    string type = row["type"].ToString();

                //    // Ajoutez un élément à la combobox en utilisant le nom de l'arme
                //    // et conservez l'id de l'arme comme valeur associée à l'élément.
                //    Compte unCompte = new Compte { Text = nom, Value = id, Type = type };
                //    comboBoxArmes.Items.Add(uneArme);
                //}
            
        }
    }
}
