using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model = FulBank.Model;

namespace FulBank.ViewModel
{
    internal class connexion_view_modle
    {
        private Model.ModelRepository ModelRepository;
        public connexion_view_modle()
        {
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
    }
}
