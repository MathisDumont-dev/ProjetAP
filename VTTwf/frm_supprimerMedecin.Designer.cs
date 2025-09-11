namespace VisiTTracking
{
    partial class frm_supprimerMedecin
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
            cmbMedecin = new ComboBox();
            btnSupprimer = new Button();
            SuspendLayout();
            // 
            // cmbMedecin
            // 
            cmbMedecin.Anchor = AnchorStyles.None;
            cmbMedecin.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedecin.FormattingEnabled = true;
            cmbMedecin.Location = new Point(87, 142);
            cmbMedecin.Name = "cmbMedecin";
            cmbMedecin.Size = new Size(619, 28);
            cmbMedecin.TabIndex = 1;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Anchor = AnchorStyles.None;
            btnSupprimer.Location = new Point(329, 293);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(122, 44);
            btnSupprimer.TabIndex = 2;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // frm_supprimerMedecin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSupprimer);
            Controls.Add(cmbMedecin);
            Name = "frm_supprimerMedecin";
            Text = "frm_supprimerMedecin";
            Load += frm_supprimerMedecin_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbMedecin;
        private Button btnSupprimer;
    }
}