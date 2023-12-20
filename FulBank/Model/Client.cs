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
        private int _salt;
        private List<unCompte> _compteList;
        public Client(int id, string prenom, string password, int salt) {
            _id = id;
            _prenom = prenom; 
            _password = password;
            _salt = salt;
        }

        public void ajouterCompte(unCompte compte)
        {
            this._compteList.Add(compte);
        }
    }
}
