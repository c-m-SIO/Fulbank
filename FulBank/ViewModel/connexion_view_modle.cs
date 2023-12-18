using FulBank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FB_M = FulBank.Model;

namespace FulBank.ViewModel
{
    internal class connexion_view_modle
    {
        private FB_M.ModelRepository Modele = new ModelRepository();
        public string testconnexion(string Username, string Password)
        {
            string res = Modele.GetMdpBd(Username);
            return res == Password ? "success" : res == "erreur" ? "erreur" : "badpwd";
        }
    }
}
