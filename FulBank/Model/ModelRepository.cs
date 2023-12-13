using MySqlConnector;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FulBank.Model
{
    internal class ModelRepository
    {
        private string IPDB = "172.16.119.7";
        private string UserDB = "mathieu";
        private string PasswordDB = "squeezie";
        private string DatabaseDB = "fulbank";
        public string GetMdpBd(string Username)
        {
            using (MySqlConnection connexion = new MySqlConnection())
            {
                
                string stringconnexion = @"server=" + IPDB + ";userid=" + UserDB + ";password=" + PasswordDB + ";database=" + DatabaseDB;
                connexion.ConnectionString = stringconnexion;
                connexion.Open();

                string query = "Select C.password from Client C where C.prenom = @Username;";
                MySqlCommand cmd = new MySqlCommand(query, connexion);
                cmd.Parameters.AddWithValue("@Username", Username);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return (string)reader["password"];
                }
            }return "erreur";
        }
    }
}
