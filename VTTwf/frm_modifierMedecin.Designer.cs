namespace VisiTTracking
{
    partial class frm_modifierMedecin
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
            btmModifier = new Button();
            numRue = new NumericUpDown();
            txtVille = new TextBox();
            txtRue = new TextBox();
            txtEmail = new TextBox();
            txtTelephone = new TextBox();
            txtPrenom = new TextBox();
            txtNom = new TextBox();
            txtId = new TextBox();
            numCp = new NumericUpDown();
            lblVille = new Label();
            lblCp = new Label();
            lblNumRue = new Label();
            lblRue = new Label();
            lblEmail = new Label();
            lblTelephone = new Label();
            lblPrenom = new Label();
            lblNom = new Label();
            lblId = new Label();
            ((System.ComponentModel.ISupportInitialize)numRue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCp).BeginInit();
            SuspendLayout();
            // 
            // btmModifier
            // 
            btmModifier.Anchor = AnchorStyles.None;
            btmModifier.Location = new Point(301, 335);
            btmModifier.Name = "btmModifier";
            btmModifier.Size = new Size(180, 68);
            btmModifier.TabIndex = 0;
            btmModifier.Text = "Modifier";
            btmModifier.UseVisualStyleBackColor = true;
            btmModifier.Click += btmModifier_Click;
            // 
            // numRue
            // 
            numRue.Anchor = AnchorStyles.None;
            numRue.Location = new Point(250, 226);
            numRue.Name = "numRue";
            numRue.Size = new Size(291, 27);
            numRue.TabIndex = 19;
            // 
            // txtVille
            // 
            txtVille.Anchor = AnchorStyles.None;
            txtVille.Location = new Point(250, 292);
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(291, 27);
            txtVille.TabIndex = 18;
            // 
            // txtRue
            // 
            txtRue.Anchor = AnchorStyles.None;
            txtRue.Location = new Point(250, 193);
            txtRue.Name = "txtRue";
            txtRue.Size = new Size(291, 27);
            txtRue.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(250, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(291, 27);
            txtEmail.TabIndex = 15;
            // 
            // txtTelephone
            // 
            txtTelephone.Anchor = AnchorStyles.None;
            txtTelephone.Location = new Point(250, 127);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(291, 27);
            txtTelephone.TabIndex = 14;
            // 
            // txtPrenom
            // 
            txtPrenom.Anchor = AnchorStyles.None;
            txtPrenom.Location = new Point(250, 94);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(291, 27);
            txtPrenom.TabIndex = 13;
            // 
            // txtNom
            // 
            txtNom.Anchor = AnchorStyles.None;
            txtNom.Location = new Point(250, 61);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(291, 27);
            txtNom.TabIndex = 12;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.Location = new Point(250, 28);
            txtId.Name = "txtId";
            txtId.Size = new Size(291, 27);
            txtId.TabIndex = 11;
            // 
            // numCp
            // 
            numCp.Anchor = AnchorStyles.None;
            numCp.Location = new Point(250, 259);
            numCp.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numCp.Minimum = new decimal(new int[] { 10000, 0, 0, 0 });
            numCp.Name = "numCp";
            numCp.Size = new Size(291, 27);
            numCp.TabIndex = 20;
            numCp.Value = new decimal(new int[] { 62000, 0, 0, 0 });
            // 
            // lblVille
            // 
            lblVille.Anchor = AnchorStyles.None;
            lblVille.AutoSize = true;
            lblVille.Location = new Point(206, 295);
            lblVille.Name = "lblVille";
            lblVille.Size = new Size(38, 20);
            lblVille.TabIndex = 29;
            lblVille.Text = "Ville";
            // 
            // lblCp
            // 
            lblCp.Anchor = AnchorStyles.None;
            lblCp.AutoSize = true;
            lblCp.Location = new Point(155, 262);
            lblCp.Name = "lblCp";
            lblCp.Size = new Size(89, 20);
            lblCp.TabIndex = 28;
            lblCp.Text = "Code postal";
            // 
            // lblNumRue
            // 
            lblNumRue.Anchor = AnchorStyles.None;
            lblNumRue.AutoSize = true;
            lblNumRue.Location = new Point(135, 228);
            lblNumRue.Name = "lblNumRue";
            lblNumRue.Size = new Size(109, 20);
            lblNumRue.TabIndex = 27;
            lblNumRue.Text = "Numéro de rue";
            // 
            // lblRue
            // 
            lblRue.Anchor = AnchorStyles.None;
            lblRue.AutoSize = true;
            lblRue.Location = new Point(210, 196);
            lblRue.Name = "lblRue";
            lblRue.Size = new Size(34, 20);
            lblRue.TabIndex = 26;
            lblRue.Text = "Rue";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(192, 163);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(52, 20);
            lblEmail.TabIndex = 25;
            lblEmail.Text = "E-mail";
            // 
            // lblTelephone
            // 
            lblTelephone.Anchor = AnchorStyles.None;
            lblTelephone.AutoSize = true;
            lblTelephone.Location = new Point(166, 130);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(78, 20);
            lblTelephone.TabIndex = 24;
            lblTelephone.Text = "Téléphone";
            // 
            // lblPrenom
            // 
            lblPrenom.Anchor = AnchorStyles.None;
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(184, 97);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(60, 20);
            lblPrenom.TabIndex = 23;
            lblPrenom.Text = "Prenom";
            // 
            // lblNom
            // 
            lblNom.Anchor = AnchorStyles.None;
            lblNom.AutoSize = true;
            lblNom.Location = new Point(202, 64);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(42, 20);
            lblNom.TabIndex = 22;
            lblNom.Text = "Nom";
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.Location = new Point(222, 31);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 21;
            lblId.Text = "id";
            // 
            // frm_modifierMedecin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblVille);
            Controls.Add(lblCp);
            Controls.Add(lblNumRue);
            Controls.Add(lblRue);
            Controls.Add(lblEmail);
            Controls.Add(lblTelephone);
            Controls.Add(lblPrenom);
            Controls.Add(lblNom);
            Controls.Add(lblId);
            Controls.Add(numCp);
            Controls.Add(numRue);
            Controls.Add(txtVille);
            Controls.Add(txtRue);
            Controls.Add(txtEmail);
            Controls.Add(txtTelephone);
            Controls.Add(txtPrenom);
            Controls.Add(txtNom);
            Controls.Add(txtId);
            Controls.Add(btmModifier);
            Name = "frm_modifierMedecin";
            Text = "frm_modifierMedecin";
            Load += frm_modifierMedecin_Load;
            ((System.ComponentModel.ISupportInitialize)numRue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btmModifier;
        private NumericUpDown numRue;
        private TextBox txtVille;
        private TextBox txtRue;
        private TextBox txtEmail;
        private TextBox txtTelephone;
        private TextBox txtPrenom;
        private TextBox txtNom;
        private TextBox txtId;
        private NumericUpDown numCp;
        private Label lblVille;
        private Label lblCp;
        private Label lblNumRue;
        private Label lblRue;
        private Label lblEmail;
        private Label lblTelephone;
        private Label lblPrenom;
        private Label lblNom;
        private Label lblId;
    }
}