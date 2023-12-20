using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FulBank.Model;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace FulBank
{
    internal partial class ChoixCompte : Form
    {
        private unCompte leCompte;
        private ModelRepository model;
        private DataTable donneesCompte;
        private Client leclient;
        public ChoixCompte(Client client)
        {
            InitializeComponent();
            model = new Model.ModelRepository();
            donneesCompte = new DataTable();
            leclient = client;
            donneesCompte = model.recupComptesUtilisateur(leclient.getId());

            foreach (DataRow row in donneesCompte.Rows)
            {
                int rib = Convert.ToInt32(row["RIB"]);
                decimal taux = Convert.ToDecimal(row["taux_interet"]);
                decimal solde = Convert.ToDecimal(row["solde"]);
                decimal plafond = Convert.ToDecimal(row["plafond"]);
                decimal decouvert = Convert.ToDecimal(row["decouvert"]);

                leCompte = new unCompte(rib, taux, solde, plafond, decouvert);
                client.ajouterCompte(leCompte);
                //MessageBox.Show(rib.ToString());

                

            }
        }

        private void ChoixCompte_Load(object sender, EventArgs e)
        {
            foreach (unCompte compte in leclient.getLesComptes())
            {
                flowLayoutPanel1.Controls.Add(new Button { Text = "lol" });
                //groupBox1.Show();
                labelTypeCompte.Text = compte.getSolde().ToString();
            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            vScrollBar1.Minimum = flowLayoutPanel1.VerticalScroll.Minimum;
            vScrollBar1.Maximum = flowLayoutPanel1.VerticalScroll.Maximum;

        }
    }
}
