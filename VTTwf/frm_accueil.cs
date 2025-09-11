namespace VisiTTracking
{
    public partial class frm_accueil : Form
    {
        public frm_accueil()
        {
            InitializeComponent();
        }

        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_voirVisiteur frm = new frm_voirVisiteur();
            foreach (Form f in this.MdiChildren)
            {
                if (f != frm)
                {
                    f.Close();
                }
            }
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void créerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_creerVisiteur frm = new frm_creerVisiteur();
            foreach (Form f in this.MdiChildren)
            {
                if (f != frm)
                {
                    f.Close();
                }
            }
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void consulterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_voirVisite frm = new frm_voirVisite();
            foreach (Form f in this.MdiChildren)
            {
                if (f != frm)
                {
                    f.Close();
                }
            }
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_supprimerVisiteur frm = new frm_supprimerVisiteur();
            foreach (Form f in this.MdiChildren)
            {
                if (f != frm)
                {
                    f.Close();
                }
            }
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_modifierVisiteur frm = new frm_modifierVisiteur();
            foreach (Form f in this.MdiChildren)
            {
                if (f != frm)
                {
                    f.Close();
                }
            }
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void créerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_creerVisite frm = new frm_creerVisite();
            foreach (Form f in this.MdiChildren)
            {
                if (f != frm)
                {
                    f.Close();
                }
            }
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void consulterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_voirMedecin frm = new frm_voirMedecin();
            foreach (Form f in this.MdiChildren)
            {
                if (f != frm)
                {
                    f.Close();
                }
            }
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void créerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_creerMedecin frm = new frm_creerMedecin();
            foreach (Form f in this.MdiChildren)
            {
                if (f != frm)
                {
                    f.Close();
                }
            }
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void modifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_modifierMedecin frm = new frm_modifierMedecin();
            foreach (Form f in this.MdiChildren)
            {
                if (f != frm)
                {
                    f.Close();
                }
            }
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void supprimerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_supprimerMedecin frm = new frm_supprimerMedecin();
            foreach (Form f in this.MdiChildren)
            {
                if (f != frm)
                {
                    f.Close();
                }
            }
            frm.MdiParent = this;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }
    }
}