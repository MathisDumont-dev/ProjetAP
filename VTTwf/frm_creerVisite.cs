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
    public partial class frm_creerVisite : Form
    {
        public frm_creerVisite()
        {
            InitializeComponent();
        }
        private async void frm_creerVisite_Load(object sender, EventArgs e)
        {
            boxVisiteur.Items.Clear();
            List<Visiteur> list = new List<Visiteur>();
            list = await Passerelle.getLesVisiteurs();
            foreach (Visiteur visiteur in list)
            {
                boxVisiteur.Items.Add(visiteur);
                boxVisiteur.DisplayMember = $"Visiteur {visiteur.Id}: {visiteur.Nom}, {visiteur.Prenom}";
                boxMedecin.ValueMember = $"{visiteur.Id}";
                //boxVisiteur.Text = $"Visiteur {visiteur.getId()}: {visiteur.getNom()}, {visiteur.getPrenom()}";
            }
            
            boxMedecin.Items.Clear();
            List<Medecin> list2 = new List<Medecin>();
            list2 = await Passerelle.getLesMedecins();
            foreach (Medecin medecin in list2)
            {
                boxMedecin.Items.Add(medecin);
                boxMedecin.DisplayMember = $"Médecin {medecin.Id}: {medecin.Nom}, {medecin.Prenom}";
                boxMedecin.ValueMember = $"{medecin.Id}";
                //boxMedecin.Text = $"Medecin& {medecin.getId()}: {medecin.getNom()}, {medecin.getPrenom()}";
            }
        }
        private void btnCreer_Click(object sender, EventArgs e)
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
                //Passerelle.addVisite(new Visite(int.Parse(txtId.Text), boxMedecin, boxVisiteur, dateVisite, txtHeureArrive.Text, txtTempsAttente.Text, txtHeureDepart.Text, checkRdv));
                MessageBox.Show("La visite a été crée");
            }
        }
    }
}