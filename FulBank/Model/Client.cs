using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FulBank.Model
{
    internal class Client
    {
        private int _id;
        private string _prenom;
        private string _password;
        private List<unCompte> _compteList;
        public Client(int id, string prenom, string password) {
            _id = id;
            _prenom = prenom; 
            _password = password;
            _compteList = new List<unCompte>();

        }

        public void ajouterCompte(unCompte compte)
        {
            this._compteList.Add(compte);
        }

        public int getId() { return this._id; }

        public string getPrenom() { return this._prenom;}
        public string getPassword() { return this._password;}
        public List<unCompte> getLesComptes() { return this._compteList;}
    }
}
