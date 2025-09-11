
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisiTTracking
{
    public partial class frm_modifierMedecin : Form
    {
        public frm_modifierMedecin()
        {
            InitializeComponent();
        }

        private void frm_modifierMedecin_Load(object sender, EventArgs e)
        {

        }

        private async void btmModifier_Click(object sender, EventArgs e)
        {
            bool ecrit = true;
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (tb.Text == "")
                {
                    ecrit = false;
                }
            }
            if (ecrit == false)
            {
                MessageBox.Show("Veuillez completer les champs.");
            }
            else
            {
                //Passerelle.editMedecin(new Medecin(int.Parse(txtId.Text), txtNom.Text, txtPrenom.Text, txtTelephone.Text, txtEmail.Text, txtRue.Text, Convert.ToInt32(numRue.Value), Convert.ToInt32(numCp.Value), txtVille.Text));
                await Passerelle.modifieMedecin(txtId.Text, txtNom.Text, txtPrenom.Text, txtTelephone.Text, txtEmail.Text, txtRue.Text, Convert.ToInt32(numRue.Value), Convert.ToInt32(numCp.Value), txtVille.Text);
                MessageBox.Show("Le médecin a été modifié");
            }
        }
    }
}
