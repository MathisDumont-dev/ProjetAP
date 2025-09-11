namespace VisiTTracking
{
    partial class frm_creerVisiteur
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
            lblId = new Label();
            lblNom = new Label();
            lblPrenom = new Label();
            lblEmail = new Label();
            lblTelephone = new Label();
            txtId = new TextBox();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            txtTelephone = new TextBox();
            txtEmail = new TextBox();
            btnCreer = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(337, 113);
            lblId.Name = "lblId";
            lblId.Size = new Size(91, 20);
            lblId.TabIndex = 0;
            lblId.Text = "Identifiant :";
            // 
            // lblNom
            // 
            lblNom.Anchor = AnchorStyles.None;
            lblNom.AutoSize = true;
            lblNom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNom.Location = new Point(368, 152);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(52, 20);
            lblNom.TabIndex = 1;
            lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            lblPrenom.Anchor = AnchorStyles.None;
            lblPrenom.AutoSize = true;
            lblPrenom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrenom.Location = new Point(348, 190);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(72, 20);
            lblPrenom.TabIndex = 2;
            lblPrenom.Text = "Prenom :";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(371, 266);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email :";
            // 
            // lblTelephone
            // 
            lblTelephone.Anchor = AnchorStyles.None;
            lblTelephone.AutoSize = true;
            lblTelephone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelephone.Location = new Point(338, 229);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(89, 20);
            lblTelephone.TabIndex = 4;
            lblTelephone.Text = "Telephone :";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.Location = new Point(426, 108);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(114, 27);
            txtId.TabIndex = 5;
            // 
            // txtNom
            // 
            txtNom.Anchor = AnchorStyles.None;
            txtNom.Location = new Point(426, 146);
            txtNom.Margin = new Padding(3, 4, 3, 4);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(114, 27);
            txtNom.TabIndex = 6;
            // 
            // txtPrenom
            // 
            txtPrenom.Anchor = AnchorStyles.None;
            txtPrenom.Location = new Point(426, 185);
            txtPrenom.Margin = new Padding(3, 4, 3, 4);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(114, 27);
            txtPrenom.TabIndex = 7;
            // 
            // txtTelephone
            // 
            txtTelephone.Anchor = AnchorStyles.None;
            txtTelephone.Location = new Point(426, 224);
            txtTelephone.Margin = new Padding(3, 4, 3, 4);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(114, 27);
            txtTelephone.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(426, 262);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(114, 27);
            txtEmail.TabIndex = 9;
            // 
            // btnCreer
            // 
            btnCreer.Anchor = AnchorStyles.None;
            btnCreer.Location = new Point(425, 336);
            btnCreer.Margin = new Padding(3, 4, 3, 4);
            btnCreer.Name = "btnCreer";
            btnCreer.Size = new Size(115, 69);
            btnCreer.TabIndex = 10;
            btnCreer.Text = "Créer";
            btnCreer.UseVisualStyleBackColor = true;
            btnCreer.Click += btnCreer_Click;
            // 
            // frm_creerVisiteur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnCreer);
            Controls.Add(txtEmail);
            Controls.Add(txtTelephone);
            Controls.Add(txtPrenom);
            Controls.Add(txtNom);
            Controls.Add(txtId);
            Controls.Add(lblTelephone);
            Controls.Add(lblEmail);
            Controls.Add(lblPrenom);
            Controls.Add(lblNom);
            Controls.Add(lblId);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_creerVisiteur";
            Text = "Création d'un Visiteur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNom;
        private Label lblPrenom;
        private Label lblEmail;
        private Label lblTelephone;
        private TextBox txtId;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private TextBox txtTelephone;
        private TextBox txtEmail;
        private Button btnCreer;
    }
}