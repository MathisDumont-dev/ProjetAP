
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
    public partial class frm_modifierVisiteur : Form
    {
        public frm_modifierVisiteur()
        {
            InitializeComponent();
        }
        private async void frm_modifierVisiteur_Load(object sender, EventArgs e)
        {
            cmbVisiteur.Items.Clear();
            List<Visiteur> list = new List<Visiteur>();
            list = await Passerelle.getLesVisiteurs();
            foreach (Visiteur visiteur in list)
            {
                cmbVisiteur.Items.Add(visiteur);
                cmbVisiteur.DisplayMember = $"Visiteur {visiteur.Id}: {visiteur.Nom}, {visiteur.Prenom}";
                //cmbVisiteur.Text = $"Visiteur {visiteur.getId()}: {visiteur.getNom()}, {visiteur.getPrenom()}";
            }
            
        }
        private async void btnModifier_Click(object sender, EventArgs e)
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
                //Passerelle.editVisiteur(new Visiteur(int.Parse(txtId.Text), txtNom.Text, txtPrenom.Text, txtTelephone.Text, txtEmail.Text));
                await Passerelle.modifieVisiteur(txtId.Text, txtNom.Text, txtPrenom.Text, txtTelephone.Text, txtEmail.Text);
                MessageBox.Show("Le visiteur a été modifié");
            }
        }
    }
}
