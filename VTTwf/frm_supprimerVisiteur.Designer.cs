namespace VisiTTracking
{
    partial class frm_supprimerVisiteur
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
            cmbVisiteur = new ComboBox();
            btnSupp = new Button();
            SuspendLayout();
            // 
            // cmbVisiteur
            // 
            cmbVisiteur.Anchor = AnchorStyles.None;
            cmbVisiteur.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVisiteur.FormattingEnabled = true;
            cmbVisiteur.Location = new Point(88, 149);
            cmbVisiteur.Name = "cmbVisiteur";
            cmbVisiteur.Size = new Size(619, 28);
            cmbVisiteur.TabIndex = 0;
            // 
            // btnSupp
            // 
            btnSupp.Anchor = AnchorStyles.None;
            btnSupp.Location = new Point(345, 248);
            btnSupp.Name = "btnSupp";
            btnSupp.Size = new Size(94, 29);
            btnSupp.TabIndex = 1;
            btnSupp.Text = "Supprimer";
            btnSupp.UseVisualStyleBackColor = true;
            btnSupp.Click += btnSupp_Click;
            // 
            // frm_supprimerVisiteur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSupp);
            Controls.Add(cmbVisiteur);
            Name = "frm_supprimerVisiteur";
            Text = "Supprimer un visiteur";
            Load += frm_supprimerVisiteur_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbVisiteur;
        private Button btnSupp;
    }
}