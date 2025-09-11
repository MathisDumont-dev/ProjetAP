
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
    public partial class frm_supprimerMedecin : Form
    {
        public frm_supprimerMedecin()
        {
            InitializeComponent();
        }

        private async void frm_supprimerMedecin_Load(object sender, EventArgs e)
        {
            cmbMedecin.Items.Clear();
            List<Medecin> list = new List<Medecin>();
            list = await Passerelle.getLesMedecins();
            foreach (Medecin medecin in list)
            {
                cmbMedecin.Items.Add(medecin);
            }
        }

        private async void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (cmbMedecin.SelectedItem != null)
            {
                Medecin selectedMedecin = (Medecin)cmbMedecin.SelectedItem;
                //Passerelle.delMedecin(selectedMedecin);
                await Passerelle.deleteMedecin(selectedMedecin.Id);
                MessageBox.Show("Le medecin a bien été supprimé !");
                cmbMedecin.Items.Remove(cmbMedecin.SelectedItem);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un medecin à supprimer !");
            }
        }
    }
}
