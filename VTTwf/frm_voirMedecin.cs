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
    public partial class frm_voirMedecin : Form
    {
        public frm_voirMedecin()
        {
            InitializeComponent();
        }
        private void frm_voirMedecin_Load(object sender, EventArgs e)
        {
            /*
            if (Passerelle.getLesMedecins().Count() == 0)
            {
                Passerelle.jeuEssai();
            }
            */
            actualiseDonnee();
        }
        private async void actualiseDonnee()
        {
            this.Controls.Clear();
            DataGridView dgvMedecin = new DataGridView();
            dgvMedecin.Dock = DockStyle.Fill;

            this.Controls.Add(dgvMedecin);
            dgvMedecin.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Identifiant",
                Name = "id"
            });

            dgvMedecin.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nom",
                Name = "nom"
            });

            dgvMedecin.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Prénom",
                Name = "prenom"
            });

            dgvMedecin.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Téléphone",
                Name = "telephone"
            });

            dgvMedecin.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email",
                Name = "email"
            });
            List<Medecin> list = new List<Medecin>();
            list = await Passerelle.getLesMedecins();
            foreach (Medecin medecin in list)
            {
                dgvMedecin.Rows.Add(
                    medecin.Id,
                    medecin.Nom,
                    medecin.Prenom,
                    medecin.Telephone,
                    medecin.Email,
                    medecin.Rue,
                    medecin.NumRue,
                    medecin.Cp,
                    medecin.Ville
                );
            }
        }
    }
}
