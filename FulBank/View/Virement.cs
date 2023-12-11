using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FulBank
{
    public partial class Virement : Form
    {
        public Virement()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string levirementstring = amount.Text;
            try
            {
                levirementstring.Replace(',', '.');
                float levirement = float.Parse(levirementstring);
            }
            catch
            {
                MessageBox.Show("Merci de rentrer une valeur entière ou décimale. par exemple: 15.00 ou 15,00 ou 15");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void /*bouton + bénéficiaire*/ button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
