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
    public partial class frm_creerVisiteur : Form
    {
        public frm_creerVisiteur()
        {
            InitializeComponent();
        }

        private async void btnCreer_Click(object sender, EventArgs e)
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
                string message = String.Empty;
                if (!txtTelephone.Text.All(char.IsDigit) || txtTelephone.Text.Length != 10)
                {
                    message = "Le numéro de téléphone doit contenir exactement 10 chiffres.\n";
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"))
                {
                    message += "L'adresse email est invalide.";
                }
                if (message == String.Empty)
                {
                    //Passerelle.addVisiteur(new Visiteur(int.Parse(txtId.Text), txtNom.Text, txtPrenom.Text, txtTelephone.Text, txtEmail.Text));
                    await Passerelle.ajouteVisiteur(txtNom.Text, txtPrenom.Text, txtTelephone.Text, txtEmail.Text);
                    MessageBox.Show("Le visiteur a été créé");
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
        }
    }
}
