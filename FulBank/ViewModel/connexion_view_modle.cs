using FulBank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FB_M = FulBank.Model;

namespace FulBank.ViewModel
{
    internal class connexion_view_model
    {
        private FB_M.ModelRepository Modele = new ModelRepository();
        public string testconnexion(string Username, string Password)
        {
            string res = Modele.GetMdpBd(Username);
            return res == ToSHA256(Password) ? "success" : res == "erreur" ? "erreur" : "badpwd";
        }
        public int getid(string Username)
        {
            return Modele.GetIdBd(Username);
        }

        public static string ToSHA256(string x)
        {
            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(x));
            var sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
