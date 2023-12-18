using MySqlConnector;
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace FulBank.Model
{
    internal class ModelRepository
    {
        private MySqlConnection connexion;
        public ModelRepository()
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "172.16.119.6",
                UserID = "mathieu",
                Password = "squeezie",
                Database = "fulbank",
            };
            connexion = new MySqlConnection(builder.ConnectionString);
            connexion.Open();
        }
        
        public string GetMdpBd(string Username)
        {
            connexion.Close();
            connexion.Open();
            string query = "Select C.password from Client C where C.prenom = @Username;";
            MySqlCommand cmd = new MySqlCommand(query, connexion);
            cmd.Parameters.AddWithValue("@Username", Username);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string res = reader.GetString(0);
                connexion.Close();
                return res;
            }
            connexion.Close();
            return "erreur";
        }


        public DataTable recupComptesUtilisateur()
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
