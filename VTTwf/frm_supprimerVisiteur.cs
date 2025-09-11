
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
    public partial class frm_supprimerVisiteur : Form
    {
        public frm_supprimerVisiteur()
        {
            InitializeComponent();
        }
        private async void frm_supprimerVisiteur_Load(object sender, EventArgs e)
        {
            cmbVisiteur.Items.Clear();
            List<Visiteur> list = new List<Visiteur>();
            list = await Passerelle.getLesVisiteurs();
            foreach (Visiteur visiteur in list)
            {
                cmbVisiteur.Items.Add(visiteur);
            }
            
        }
        private async void btnSupp_Click(object sender, EventArgs e)
        {
            if (cmbVisiteur.SelectedItem != null)
            {
                Visiteur selectedVisiteur = (Visiteur)cmbVisiteur.SelectedItem;
                //Passerelle.delVisiteur(selectedVisiteur);
                await Passerelle.deleteVisiteur(selectedVisiteur.Id);
                MessageBox.Show("Le visiteur a bien été supprimé !");
                cmbVisiteur.Items.Remove(cmbVisiteur.SelectedItem);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un visiteur à supprimer !");
            }
        }
    }
}
