using MySqlConnector;
using System.Data.SQLite;

namespace FulBank.Model
{
    internal class ModelRepository
    {
        private MySqlConnection connexion;
        public string testconnexion()
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "172.16.119.1",
                UserID = "mathieu",
                Password = "squeezie",
                Database = "fulbank",
            };

            connexion = new MySqlConnection(builder.ConnectionString);

            try
            {
                connexion.Open();
                return("reussie");

            }
            catch (Exception ex)
            {
                return(ex.Message);
            }
        }
    }
}