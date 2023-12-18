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

namespace FulBank
{
    public partial class ChoixCompte : Form
    {
        private unCompte leCompte;
        private ModelRepository model;
        private DataTable donneesCompte;
        public ChoixCompte()
        {
            InitializeComponent();
            model = new Model.ModelRepository();
            donneesCompte = new DataTable();
            donneesCompte = model.recupComptesUtilisateur();

            foreach (DataRow row in donneesCompte.Rows)
            {
                int rib = Convert.ToInt32(row["RIB"]);
                string nom = row["nom_proprietaire"].ToString();
                decimal taux = Convert.ToDecimal(row["taux_interet"]);
                decimal solde = Convert.ToDecimal(row["solde"]);
                decimal plafond = Convert.ToDecimal(row["plafond"]);
                decimal decouvert = Convert.ToDecimal(row["decouvert"]);

                leCompte = new unCompte(rib, taux, nom, solde, plafond, decouvert);
                
                MessageBox.Show(rib.ToString());

                // Ajoutez un élément à la combobox en utilisant le nom de l'arme
                // et conservez l'id de l'arme comme valeur associée à l'élément.
                //Compte unCompte = new Compte { Text = nom, Value = id, Type = type };
                //comboBoxArmes.Items.Add(uneArme);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ChoixCompte_Load(object sender, EventArgs e)
        {


        }
    }
}
