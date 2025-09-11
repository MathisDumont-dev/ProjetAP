namespace VisiTTracking
{
    partial class frm_creerVisite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCreer = new Button();
            txtId = new TextBox();
            txtHeureArrive = new TextBox();
            txtHeureDepart = new TextBox();
            boxMedecin = new ComboBox();
            dateVisite = new DateTimePicker();
            boxVisiteur = new ComboBox();
            checkRdv = new CheckBox();
            numAttente = new NumericUpDown();
            lblId = new Label();
            lblMed = new Label();
            lblVis = new Label();
            lblDate = new Label();
            lblHeureArrivee = new Label();
            lblAttente = new Label();
            lblHeureDepart = new Label();
            ((System.ComponentModel.ISupportInitialize)numAttente).BeginInit();
            SuspendLayout();
            // 
            // btnCreer
            // 
            btnCreer.Anchor = AnchorStyles.None;
            btnCreer.Location = new Point(328, 358);
            btnCreer.Name = "btnCreer";
            btnCreer.Size = new Size(100, 42);
            btnCreer.TabIndex = 0;
            btnCreer.Text = "Créer";
            btnCreer.UseVisualStyleBackColor = true;
            btnCreer.Click += btnCreer_Click;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.Location = new Point(254, 45);
            txtId.Name = "txtId";
            txtId.Size = new Size(276, 27);
            txtId.TabIndex = 1;
            // 
            // txtHeureArrive
            // 
            txtHeureArrive.Anchor = AnchorStyles.None;
            txtHeureArrive.Location = new Point(255, 177);
            txtHeureArrive.Name = "txtHeureArrive";
            txtHeureArrive.Size = new Size(276, 27);
            txtHeureArrive.TabIndex = 5;
            // 
            // txtHeureDepart
            // 
            txtHeureDepart.Anchor = AnchorStyles.None;
            txtHeureDepart.Location = new Point(254, 243);
            txtHeureDepart.Name = "txtHeureDepart";
            txtHeureDepart.Size = new Size(276, 27);
            txtHeureDepart.TabIndex = 7;
            // 
            // boxMedecin
            // 
            boxMedecin.Anchor = AnchorStyles.None;
            boxMedecin.DropDownStyle = ComboBoxStyle.DropDownList;
            boxMedecin.FormattingEnabled = true;
            boxMedecin.Location = new Point(254, 78);
            boxMedecin.Name = "boxMedecin";
            boxMedecin.Size = new Size(276, 28);
            boxMedecin.TabIndex = 9;
            // 
            // dateVisite
            // 
            dateVisite.Anchor = AnchorStyles.None;
            dateVisite.Location = new Point(254, 146);
            dateVisite.Name = "dateVisite";
            dateVisite.Size = new Size(277, 27);
            dateVisite.TabIndex = 10;
            // 
            // boxVisiteur
            // 
            boxVisiteur.Anchor = AnchorStyles.None;
            boxVisiteur.DropDownStyle = ComboBoxStyle.DropDownList;
            boxVisiteur.FormattingEnabled = true;
            boxVisiteur.Location = new Point(254, 112);
            boxVisiteur.Name = "boxVisiteur";
            boxVisiteur.Size = new Size(276, 28);
            boxVisiteur.TabIndex = 11;
            // 
            // checkRdv
            // 
            checkRdv.Anchor = AnchorStyles.None;
            checkRdv.AutoSize = true;
            checkRdv.Location = new Point(332, 298);
            checkRdv.Name = "checkRdv";
            checkRdv.Size = new Size(96, 24);
            checkRdv.TabIndex = 12;
            checkRdv.Text = "Avec RDV";
            checkRdv.UseVisualStyleBackColor = true;
            // 
            // numAttente
            // 
            numAttente.Anchor = AnchorStyles.None;
            numAttente.Location = new Point(255, 210);
            numAttente.Name = "numAttente";
            numAttente.Size = new Size(276, 27);
            numAttente.TabIndex = 13;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.Location = new Point(226, 48);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 14;
            lblId.Text = "id";
            // 
            // lblMed
            // 
            lblMed.Anchor = AnchorStyles.None;
            lblMed.AutoSize = true;
            lblMed.Location = new Point(182, 81);
            lblMed.Name = "lblMed";
            lblMed.Size = new Size(66, 20);
            lblMed.TabIndex = 15;
            lblMed.Text = "Medecin";
            // 
            // lblVis
            // 
            lblVis.Anchor = AnchorStyles.None;
            lblVis.AutoSize = true;
            lblVis.Location = new Point(190, 120);
            lblVis.Name = "lblVis";
            lblVis.Size = new Size(58, 20);
            lblVis.TabIndex = 16;
            lblVis.Text = "Visiteur";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.None;
            lblDate.AutoSize = true;
            lblDate.Location = new Point(207, 151);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(41, 20);
            lblDate.TabIndex = 17;
            lblDate.Text = "Date";
            // 
            // lblHeureArrivee
            // 
            lblHeureArrivee.Anchor = AnchorStyles.None;
            lblHeureArrivee.AutoSize = true;
            lblHeureArrivee.Location = new Point(138, 180);
            lblHeureArrivee.Name = "lblHeureArrivee";
            lblHeureArrivee.Size = new Size(110, 20);
            lblHeureArrivee.TabIndex = 18;
            lblHeureArrivee.Text = "Heure d'arrivée";
            // 
            // lblAttente
            // 
            lblAttente.Anchor = AnchorStyles.None;
            lblAttente.AutoSize = true;
            lblAttente.Location = new Point(133, 212);
            lblAttente.Name = "lblAttente";
            lblAttente.Size = new Size(115, 20);
            lblAttente.TabIndex = 19;
            lblAttente.Text = "Temps d'attente";
            // 
            // lblHeureDepart
            // 
            lblHeureDepart.Anchor = AnchorStyles.None;
            lblHeureDepart.AutoSize = true;
            lblHeureDepart.Location = new Point(130, 246);
            lblHeureDepart.Name = "lblHeureDepart";
            lblHeureDepart.Size = new Size(118, 20);
            lblHeureDepart.TabIndex = 20;
            lblHeureDepart.Text = "Heure de depart";
            // 
            // frm_creerVisite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHeureDepart);
            Controls.Add(lblAttente);
            Controls.Add(lblHeureArrivee);
            Controls.Add(lblDate);
            Controls.Add(lblVis);
            Controls.Add(lblMed);
            Controls.Add(lblId);
            Controls.Add(numAttente);
            Controls.Add(checkRdv);
            Controls.Add(boxVisiteur);
            Controls.Add(dateVisite);
            Controls.Add(boxMedecin);
            Controls.Add(txtHeureDepart);
            Controls.Add(txtHeureArrive);
            Controls.Add(txtId);
            Controls.Add(btnCreer);
            Name = "frm_creerVisite";
            Text = "frm_creerVisite";
            Load += frm_creerVisite_Load;
            ((System.ComponentModel.ISupportInitialize)numAttente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreer;
        private TextBox txtId;
        private TextBox txtHeureArrive;
        private TextBox txtHeureDepart;
        private ComboBox boxMedecin;
        private DateTimePicker dateVisite;
        private ComboBox boxVisiteur;
        private CheckBox checkRdv;
        private NumericUpDown numAttente;
        private Label lblId;
        private Label lblMed;
        private Label lblVis;
        private Label lblDate;
        private Label lblHeureArrivee;
        private Label lblAttente;
        private Label lblHeureDepart;
    }
}