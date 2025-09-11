namespace VisiTTracking
{
    partial class frm_creerMedecin
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
            BtnCreer = new Button();
            txtId = new TextBox();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            txtTelephone = new TextBox();
            txtEmail = new TextBox();
            txtRue = new TextBox();
            txtVille = new TextBox();
            numRue = new NumericUpDown();
            lblId = new Label();
            lblNom = new Label();
            lblPrenom = new Label();
            lblTelephone = new Label();
            lblEmail = new Label();
            lblRue = new Label();
            lblNumRue = new Label();
            lblCp = new Label();
            lblVille = new Label();
            numCp = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numRue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCp).BeginInit();
            SuspendLayout();
            // 
            // BtnCreer
            // 
            BtnCreer.Anchor = AnchorStyles.None;
            BtnCreer.Location = new Point(308, 356);
            BtnCreer.Name = "BtnCreer";
            BtnCreer.Size = new Size(197, 52);
            BtnCreer.TabIndex = 0;
            BtnCreer.Text = "Créer";
            BtnCreer.UseVisualStyleBackColor = true;
            BtnCreer.Click += BtnCreer_Click;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.Location = new Point(262, 41);
            txtId.Name = "txtId";
            txtId.Size = new Size(291, 27);
            txtId.TabIndex = 1;
            // 
            // txtNom
            // 
            txtNom.Anchor = AnchorStyles.None;
            txtNom.Location = new Point(262, 74);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(291, 27);
            txtNom.TabIndex = 2;
            // 
            // txtPrenom
            // 
            txtPrenom.Anchor = AnchorStyles.None;
            txtPrenom.Location = new Point(262, 107);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(291, 27);
            txtPrenom.TabIndex = 3;
            // 
            // txtTelephone
            // 
            txtTelephone.Anchor = AnchorStyles.None;
            txtTelephone.Location = new Point(262, 140);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(291, 27);
            txtTelephone.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(262, 173);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(291, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtRue
            // 
            txtRue.Anchor = AnchorStyles.None;
            txtRue.Location = new Point(262, 206);
            txtRue.Name = "txtRue";
            txtRue.Size = new Size(291, 27);
            txtRue.TabIndex = 6;
            // 
            // txtVille
            // 
            txtVille.Anchor = AnchorStyles.None;
            txtVille.Location = new Point(262, 305);
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(291, 27);
            txtVille.TabIndex = 9;
            // 
            // numRue
            // 
            numRue.Anchor = AnchorStyles.None;
            numRue.Location = new Point(262, 239);
            numRue.Name = "numRue";
            numRue.Size = new Size(291, 27);
            numRue.TabIndex = 10;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.Location = new Point(234, 44);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 11;
            lblId.Text = "id";
            // 
            // lblNom
            // 
            lblNom.Anchor = AnchorStyles.None;
            lblNom.AutoSize = true;
            lblNom.Location = new Point(214, 77);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(42, 20);
            lblNom.TabIndex = 12;
            lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            lblPrenom.Anchor = AnchorStyles.None;
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(196, 110);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(60, 20);
            lblPrenom.TabIndex = 13;
            lblPrenom.Text = "Prenom";
            // 
            // lblTelephone
            // 
            lblTelephone.Anchor = AnchorStyles.None;
            lblTelephone.AutoSize = true;
            lblTelephone.Location = new Point(178, 143);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(78, 20);
            lblTelephone.TabIndex = 14;
            lblTelephone.Text = "Téléphone";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(204, 176);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(52, 20);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "E-mail";
            // 
            // lblRue
            // 
            lblRue.Anchor = AnchorStyles.None;
            lblRue.AutoSize = true;
            lblRue.Location = new Point(222, 209);
            lblRue.Name = "lblRue";
            lblRue.Size = new Size(34, 20);
            lblRue.TabIndex = 16;
            lblRue.Text = "Rue";
            // 
            // lblNumRue
            // 
            lblNumRue.Anchor = AnchorStyles.None;
            lblNumRue.AutoSize = true;
            lblNumRue.Location = new Point(147, 241);
            lblNumRue.Name = "lblNumRue";
            lblNumRue.Size = new Size(109, 20);
            lblNumRue.TabIndex = 17;
            lblNumRue.Text = "Numéro de rue";
            // 
            // lblCp
            // 
            lblCp.Anchor = AnchorStyles.None;
            lblCp.AutoSize = true;
            lblCp.Location = new Point(167, 275);
            lblCp.Name = "lblCp";
            lblCp.Size = new Size(89, 20);
            lblCp.TabIndex = 18;
            lblCp.Text = "Code postal";
            // 
            // lblVille
            // 
            lblVille.Anchor = AnchorStyles.None;
            lblVille.AutoSize = true;
            lblVille.Location = new Point(218, 308);
            lblVille.Name = "lblVille";
            lblVille.Size = new Size(38, 20);
            lblVille.TabIndex = 19;
            lblVille.Text = "Ville";
            // 
            // numCp
            // 
            numCp.Anchor = AnchorStyles.None;
            numCp.Location = new Point(262, 273);
            numCp.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numCp.Minimum = new decimal(new int[] { 10000, 0, 0, 0 });
            numCp.Name = "numCp";
            numCp.Size = new Size(291, 27);
            numCp.TabIndex = 20;
            numCp.Value = new decimal(new int[] { 62000, 0, 0, 0 });
            // 
            // frm_creerMedecin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numCp);
            Controls.Add(lblVille);
            Controls.Add(lblCp);
            Controls.Add(lblNumRue);
            Controls.Add(lblRue);
            Controls.Add(lblEmail);
            Controls.Add(lblTelephone);
            Controls.Add(lblPrenom);
            Controls.Add(lblNom);
            Controls.Add(lblId);
            Controls.Add(numRue);
            Controls.Add(txtVille);
            Controls.Add(txtRue);
            Controls.Add(txtEmail);
            Controls.Add(txtTelephone);
            Controls.Add(txtPrenom);
            Controls.Add(txtNom);
            Controls.Add(txtId);
            Controls.Add(BtnCreer);
            Name = "frm_creerMedecin";
            Text = "Créer un médecin";
            ((System.ComponentModel.ISupportInitialize)numRue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCreer;
        private TextBox txtId;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private TextBox txtTelephone;
        private TextBox txtEmail;
        private TextBox txtRue;
        private TextBox txtVille;
        private NumericUpDown numRue;
        private Label lblId;
        private Label lblNom;
        private Label lblPrenom;
        private Label lblTelephone;
        private Label lblEmail;
        private Label lblRue;
        private Label lblNumRue;
        private Label lblCp;
        private Label lblVille;
        private NumericUpDown numCp;
    }
}