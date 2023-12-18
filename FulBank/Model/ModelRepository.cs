using MySqlConnector;
using System.Data;
using System.Data.SQLite;

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

            try
            {
                connexion.Open();
                //MessageBox.Show("reussie");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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