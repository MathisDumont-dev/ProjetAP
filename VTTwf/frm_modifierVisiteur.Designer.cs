namespace VisiTTracking
{
    partial class frm_modifierVisiteur
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
            btnModifier = new Button();
            txtEmail = new TextBox();
            txtTelephone = new TextBox();
            txtPrenom = new TextBox();
            txtNom = new TextBox();
            txtId = new TextBox();
            lblTelephone = new Label();
            lblEmail = new Label();
            lblPrenom = new Label();
            lblNom = new Label();
            lblId = new Label();
            cmbVisiteur = new ComboBox();
            SuspendLayout();
            // 
            // btnModifier
            // 
            btnModifier.Anchor = AnchorStyles.None;
            btnModifier.Location = new Point(335, 295);
            btnModifier.Margin = new Padding(3, 4, 3, 4);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(115, 69);
            btnModifier.TabIndex = 21;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(368, 233);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(114, 27);
            txtEmail.TabIndex = 20;
            // 
            // txtTelephone
            // 
            txtTelephone.Anchor = AnchorStyles.None;
            txtTelephone.Location = new Point(368, 195);
            txtTelephone.Margin = new Padding(3, 4, 3, 4);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(114, 27);
            txtTelephone.TabIndex = 19;
            // 
            // txtPrenom
            // 
            txtPrenom.Anchor = AnchorStyles.None;
            txtPrenom.Location = new Point(368, 156);
            txtPrenom.Margin = new Padding(3, 4, 3, 4);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(114, 27);
            txtPrenom.TabIndex = 18;
            // 
            // txtNom
            // 
            txtNom.Anchor = AnchorStyles.None;
            txtNom.Location = new Point(368, 117);
            txtNom.Margin = new Padding(3, 4, 3, 4);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(114, 27);
            txtNom.TabIndex = 17;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.Location = new Point(368, 79);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(114, 27);
            txtId.TabIndex = 16;
            // 
            // lblTelephone
            // 
            lblTelephone.Anchor = AnchorStyles.None;
            lblTelephone.AutoSize = true;
            lblTelephone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelephone.Location = new Point(280, 200);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(89, 20);
            lblTelephone.TabIndex = 15;
            lblTelephone.Text = "Telephone :";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(313, 237);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 20);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email :";
            // 
            // lblPrenom
            // 
            lblPrenom.Anchor = AnchorStyles.None;
            lblPrenom.AutoSize = true;
            lblPrenom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrenom.Location = new Point(290, 161);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(72, 20);
            lblPrenom.TabIndex = 13;
            lblPrenom.Text = "Prenom :";
            // 
            // lblNom
            // 
            lblNom.Anchor = AnchorStyles.None;
            lblNom.AutoSize = true;
            lblNom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNom.Location = new Point(310, 123);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(52, 20);
            lblNom.TabIndex = 12;
            lblNom.Text = "Nom :";
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(279, 84);
            lblId.Name = "lblId";
            lblId.Size = new Size(91, 20);
            lblId.TabIndex = 11;
            lblId.Text = "Identifiant :";
            // 
            // cmbVisiteur
            // 
            cmbVisiteur.Anchor = AnchorStyles.None;
            cmbVisiteur.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVisiteur.FormattingEnabled = true;
            cmbVisiteur.Location = new Point(86, 44);
            cmbVisiteur.Name = "cmbVisiteur";
            cmbVisiteur.Size = new Size(619, 28);
            cmbVisiteur.TabIndex = 22;
            // 
            // frm_modifierVisiteur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbVisiteur);
            Controls.Add(btnModifier);
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
            Name = "frm_modifierVisiteur";
            Text = "frm_modifierVisiteur";
            Load += frm_modifierVisiteur_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModifier;
        private TextBox txtEmail;
        private TextBox txtTelephone;
        private TextBox txtPrenom;
        private TextBox txtNom;
        private TextBox txtId;
        private Label lblTelephone;
        private Label lblEmail;
        private Label lblPrenom;
        private Label lblNom;
        private Label lblId;
        private ComboBox cmbVisiteur;
    }
}