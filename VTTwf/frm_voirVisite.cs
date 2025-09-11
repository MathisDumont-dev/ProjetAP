
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
    public partial class frm_voirVisite : Form
    {
        public frm_voirVisite()
        {
            InitializeComponent();
        }
        private void frm_voirVisite_Load(object sender, EventArgs e)
        {
            actualiseDonnee();
        }
        private void actualiseDonnee()
        {
            this.Controls.Clear();
            DataGridView dgvVisite = new DataGridView();
            dgvVisite.Dock = DockStyle.Fill;

            this.Controls.Add(dgvVisite);

            dgvVisite.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Identifiant",
                Name = "id"
            });
            dgvVisite.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Medecin",
                Name = "medecin"
            });
            dgvVisite.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Visiteur",
                Name = "visiteur"
            });
            dgvVisite.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Date de visite",
                Name = "dateVisite"
            });
            dgvVisite.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Heure d'arrive",
                Name = "heureArrive"
            });
            dgvVisite.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Temps d'attente",
                Name = "tempsAttente"
            });
            dgvVisite.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Heure de départ",
                Name = "heureDepart"
            });
            dgvVisite.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Avec rendez-vous",
                Name = "avecRdv"
            });
            List<Visite> visites = Passerelle.getLesVisites();
            foreach (Visite visite in visites)
            {
                dgvVisite.Rows.Add(
                    visite.getId(),
                    visite.getMedecin().Nom + " " + visite.getMedecin().Prenom,
                    visite.getVisiteur().Nom + " " + visite.getVisiteur().Prenom,
                    visite.getDateVisite().ToString(),
                    visite.getHeureArrive().ToString(),
                    visite.getTempsAttente().ToString() + " minutes",
                    visite.getHeureDepart().ToString(),
                    visite.getAvecRdv().ToString()
                    );
            }
        }
    }
}
