namespace VisiTTracking
{
    partial class frm_accueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            accueilToolStripMenuItem = new ToolStripMenuItem();
            visiteurToolStripMenuItem = new ToolStripMenuItem();
            consulterToolStripMenuItem = new ToolStripMenuItem();
            créerToolStripMenuItem = new ToolStripMenuItem();
            modifierToolStripMenuItem = new ToolStripMenuItem();
            supprimerToolStripMenuItem = new ToolStripMenuItem();
            medecinToolStripMenuItem = new ToolStripMenuItem();
            consulterToolStripMenuItem2 = new ToolStripMenuItem();
            créerToolStripMenuItem2 = new ToolStripMenuItem();
            modifierToolStripMenuItem1 = new ToolStripMenuItem();
            supprimerToolStripMenuItem1 = new ToolStripMenuItem();
            visiteToolStripMenuItem = new ToolStripMenuItem();
            consulterToolStripMenuItem1 = new ToolStripMenuItem();
            créerToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { accueilToolStripMenuItem, visiteurToolStripMenuItem, medecinToolStripMenuItem, visiteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(815, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // accueilToolStripMenuItem
            // 
            accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            accueilToolStripMenuItem.Size = new Size(71, 24);
            accueilToolStripMenuItem.Text = "Accueil";
            // 
            // visiteurToolStripMenuItem
            // 
            visiteurToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consulterToolStripMenuItem, créerToolStripMenuItem, modifierToolStripMenuItem, supprimerToolStripMenuItem });
            visiteurToolStripMenuItem.Name = "visiteurToolStripMenuItem";
            visiteurToolStripMenuItem.Size = new Size(72, 24);
            visiteurToolStripMenuItem.Text = "Visiteur";
            // 
            // consulterToolStripMenuItem
            // 
            consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            consulterToolStripMenuItem.Size = new Size(161, 26);
            consulterToolStripMenuItem.Text = "Consulter";
            consulterToolStripMenuItem.Click += consulterToolStripMenuItem_Click;
            // 
            // créerToolStripMenuItem
            // 
            créerToolStripMenuItem.Name = "créerToolStripMenuItem";
            créerToolStripMenuItem.Size = new Size(161, 26);
            créerToolStripMenuItem.Text = "Créer";
            créerToolStripMenuItem.Click += créerToolStripMenuItem_Click;
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new Size(161, 26);
            modifierToolStripMenuItem.Text = "Modifier";
            modifierToolStripMenuItem.Click += modifierToolStripMenuItem_Click;
            // 
            // supprimerToolStripMenuItem
            // 
            supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            supprimerToolStripMenuItem.Size = new Size(161, 26);
            supprimerToolStripMenuItem.Text = "Supprimer";
            supprimerToolStripMenuItem.Click += supprimerToolStripMenuItem_Click;
            // 
            // medecinToolStripMenuItem
            // 
            medecinToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consulterToolStripMenuItem2, créerToolStripMenuItem2, modifierToolStripMenuItem1, supprimerToolStripMenuItem1 });
            medecinToolStripMenuItem.Name = "medecinToolStripMenuItem";
            medecinToolStripMenuItem.Size = new Size(80, 24);
            medecinToolStripMenuItem.Text = "Medecin";
            // 
            // consulterToolStripMenuItem2
            // 
            consulterToolStripMenuItem2.Name = "consulterToolStripMenuItem2";
            consulterToolStripMenuItem2.Size = new Size(161, 26);
            consulterToolStripMenuItem2.Text = "Consulter";
            consulterToolStripMenuItem2.Click += consulterToolStripMenuItem2_Click;
            // 
            // créerToolStripMenuItem2
            // 
            créerToolStripMenuItem2.Name = "créerToolStripMenuItem2";
            créerToolStripMenuItem2.Size = new Size(161, 26);
            créerToolStripMenuItem2.Text = "Créer";
            créerToolStripMenuItem2.Click += créerToolStripMenuItem2_Click;
            // 
            // modifierToolStripMenuItem1
            // 
            modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            modifierToolStripMenuItem1.Size = new Size(161, 26);
            modifierToolStripMenuItem1.Text = "Modifier";
            modifierToolStripMenuItem1.Click += modifierToolStripMenuItem1_Click;
            // 
            // supprimerToolStripMenuItem1
            // 
            supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            supprimerToolStripMenuItem1.Size = new Size(161, 26);
            supprimerToolStripMenuItem1.Text = "Supprimer";
            supprimerToolStripMenuItem1.Click += supprimerToolStripMenuItem1_Click;
            // 
            // visiteToolStripMenuItem
            // 
            visiteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consulterToolStripMenuItem1, créerToolStripMenuItem1 });
            visiteToolStripMenuItem.Name = "visiteToolStripMenuItem";
            visiteToolStripMenuItem.Size = new Size(59, 24);
            visiteToolStripMenuItem.Text = "Visite";
            // 
            // consulterToolStripMenuItem1
            // 
            consulterToolStripMenuItem1.Name = "consulterToolStripMenuItem1";
            consulterToolStripMenuItem1.Size = new Size(154, 26);
            consulterToolStripMenuItem1.Text = "Consulter";
            consulterToolStripMenuItem1.Click += consulterToolStripMenuItem1_Click;
            // 
            // créerToolStripMenuItem1
            // 
            créerToolStripMenuItem1.Name = "créerToolStripMenuItem1";
            créerToolStripMenuItem1.Size = new Size(154, 26);
            créerToolStripMenuItem1.Text = "Créer";
            créerToolStripMenuItem1.Click += créerToolStripMenuItem1_Click;
            // 
            // frm_accueil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 448);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_accueil";
            Text = "Accueil";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem accueilToolStripMenuItem;
        private ToolStripMenuItem visiteurToolStripMenuItem;
        private ToolStripMenuItem consulterToolStripMenuItem;
        private ToolStripMenuItem créerToolStripMenuItem;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ToolStripMenuItem supprimerToolStripMenuItem;
        private ToolStripMenuItem visiteToolStripMenuItem;
        private ToolStripMenuItem consulterToolStripMenuItem1;
        private ToolStripMenuItem créerToolStripMenuItem1;
        private ToolStripMenuItem medecinToolStripMenuItem;
        private ToolStripMenuItem consulterToolStripMenuItem2;
        private ToolStripMenuItem créerToolStripMenuItem2;
        private ToolStripMenuItem modifierToolStripMenuItem1;
        private ToolStripMenuItem supprimerToolStripMenuItem1;
    }
}