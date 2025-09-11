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
    public partial class frm_voirVisiteur : Form
    {
        public frm_voirVisiteur()
        {
            InitializeComponent();
        }
        private void frm_voirVisiteur_Load(object sender, EventArgs e)
        {
            actualiseDonnee();
        }
        private async void actualiseDonnee()
        {
            this.Controls.Clear();
            DataGridView dgvVisiteur = new DataGridView();
            dgvVisiteur.Dock = DockStyle.Fill;

            this.Controls.Add(dgvVisiteur);
            dgvVisiteur.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Identifiant",
                Name = "id"
            });

            dgvVisiteur.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nom",
                Name = "nom"
            });

            dgvVisiteur.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Prénom",
                Name = "prenom"
            });

            dgvVisiteur.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Téléphone",
                Name = "telephone"
            });

            dgvVisiteur.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email",
                Name = "email"
            });
            List<Visiteur> list = new List<Visiteur>();
            list = await Passerelle.getLesVisiteurs();
            foreach (Visiteur visiteur in list)
            {
                dgvVisiteur.Rows.Add(
                    visiteur.Id,
                    visiteur.Nom,
                    visiteur.Prenom,
                    visiteur.Telephone,
                    visiteur.Email
                );
            }
        }
    }
}
