using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FB_VM = FulBank.ViewModel;

namespace FulBank
{
    public partial class Compte : Form
    {
        private FB_VM.connexion_view_model ConnexionViewModel;
        public Compte()
        {
            InitializeComponent();
            ConnexionViewModel = new FB_VM.connexion_view_model();
        }

        private void Compte_Load(object sender, EventArgs e)
        {

        }

        private void Comptef(object sender, EventArgs e)
        {

        }

        private void lbl_solde_Click(object sender, EventArgs e)
        {
            lbl_solde.Text = "0";
        }
    }
}
