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
<<<<<<< HEAD
            string res = Modele.GetMdpBd(Username);
            return res == Password ? "sucess" : res == "erreur" ? "erreur" : "badpwd";
        }
=======
            ModelRepository = new Model.ModelRepository();
        }

        //public string testconnexion()
        //{
        //    if (ModelRepository.testconnexion()!="")
        //    {
        //        return ModelRepository.testconnexion();
        //    }
        //    return "";
        //}
>>>>>>> f51b3a1f704be5ae7904b249e407a7c799c051a9
    }
}
