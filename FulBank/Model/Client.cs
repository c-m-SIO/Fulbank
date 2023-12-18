using System;
using System.Collections.Generic;
using System.Linq;
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
        }

        public void ajouterCompte(unCompte compte)
        {
            this._compteList.Add(compte);
        }
    }
}
