namespace AP3_GestionHackathon
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.hACKATHONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesHackathonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesHackathonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eQUIPEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesÉquipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUneÉquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUneÉquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiverUneÉquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEMBREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesMembresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnMembreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnMembreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effacerUnMembreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUIVIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DECONNEXIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStripPrincipal.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hACKATHONToolStripMenuItem,
            this.eQUIPEToolStripMenuItem,
            this.mEMBREToolStripMenuItem,
            this.sUIVIToolStripMenuItem,
            this.DECONNEXIONToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(1067, 28);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // hACKATHONToolStripMenuItem
            // 
            this.hACKATHONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesHackathonsToolStripMenuItem,
            this.gestionDesHackathonsToolStripMenuItem,
            this.modificationToolStripMenuItem,
            this.suppressionToolStripMenuItem,
            this.archivageToolStripMenuItem});
            this.hACKATHONToolStripMenuItem.Name = "hACKATHONToolStripMenuItem";
            this.hACKATHONToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.hACKATHONToolStripMenuItem.Text = "HACKATHON";
            // 
            // listeDesHackathonsToolStripMenuItem
            // 
            this.listeDesHackathonsToolStripMenuItem.Name = "listeDesHackathonsToolStripMenuItem";
            this.listeDesHackathonsToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.listeDesHackathonsToolStripMenuItem.Text = "Liste des hackathons";
            this.listeDesHackathonsToolStripMenuItem.Click += new System.EventHandler(this.ListeDesHackathonsToolStripMenuItem_Click);
            // 
            // gestionDesHackathonsToolStripMenuItem
            // 
            this.gestionDesHackathonsToolStripMenuItem.Name = "gestionDesHackathonsToolStripMenuItem";
            this.gestionDesHackathonsToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.gestionDesHackathonsToolStripMenuItem.Text = "Ajouter un hackathon";
            this.gestionDesHackathonsToolStripMenuItem.Click += new System.EventHandler(this.GestionDesHackathonsToolStripMenuItem_Click);
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.modificationToolStripMenuItem.Text = "Modifier un hackathon";
            this.modificationToolStripMenuItem.Click += new System.EventHandler(this.modificationToolStripMenuItem_Click);
            // 
            // suppressionToolStripMenuItem
            // 
            this.suppressionToolStripMenuItem.Name = "suppressionToolStripMenuItem";
            this.suppressionToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.suppressionToolStripMenuItem.Text = "Supprimer un hackathon";
            this.suppressionToolStripMenuItem.Click += new System.EventHandler(this.suppressionToolStripMenuItem_Click_1);
            // 
            // archivageToolStripMenuItem
            // 
            this.archivageToolStripMenuItem.Name = "archivageToolStripMenuItem";
            this.archivageToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.archivageToolStripMenuItem.Text = "Archiver un hackathon";
            this.archivageToolStripMenuItem.Click += new System.EventHandler(this.archivageToolStripMenuItem_Click_1);
            // 
            // eQUIPEToolStripMenuItem
            // 
            this.eQUIPEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesÉquipesToolStripMenuItem,
            this.ajouterToolStripMenuItem,
            this.modifierUneÉquipeToolStripMenuItem,
            this.supprimerUneÉquipeToolStripMenuItem,
            this.archiverUneÉquipeToolStripMenuItem});
            this.eQUIPEToolStripMenuItem.Name = "eQUIPEToolStripMenuItem";
            this.eQUIPEToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.eQUIPEToolStripMenuItem.Text = "EQUIPE";
            // 
            // listeDesÉquipesToolStripMenuItem
            // 
            this.listeDesÉquipesToolStripMenuItem.Name = "listeDesÉquipesToolStripMenuItem";
            this.listeDesÉquipesToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.listeDesÉquipesToolStripMenuItem.Text = "Liste des équipes";
            this.listeDesÉquipesToolStripMenuItem.Click += new System.EventHandler(this.ListeDesÉquipesToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.ajouterToolStripMenuItem.Text = "Ajout d\'une équipe";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.AjouterToolStripMenuItem_Click);
            // 
            // modifierUneÉquipeToolStripMenuItem
            // 
            this.modifierUneÉquipeToolStripMenuItem.Name = "modifierUneÉquipeToolStripMenuItem";
            this.modifierUneÉquipeToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.modifierUneÉquipeToolStripMenuItem.Text = "Modifier une équipe";
            this.modifierUneÉquipeToolStripMenuItem.Click += new System.EventHandler(this.modifierUneÉquipeToolStripMenuItem_Click);
            // 
            // supprimerUneÉquipeToolStripMenuItem
            // 
            this.supprimerUneÉquipeToolStripMenuItem.Name = "supprimerUneÉquipeToolStripMenuItem";
            this.supprimerUneÉquipeToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.supprimerUneÉquipeToolStripMenuItem.Text = "Supprimer une équipe";
            this.supprimerUneÉquipeToolStripMenuItem.Click += new System.EventHandler(this.supprimerUneÉquipeToolStripMenuItem_Click);
            // 
            // archiverUneÉquipeToolStripMenuItem
            // 
            this.archiverUneÉquipeToolStripMenuItem.Name = "archiverUneÉquipeToolStripMenuItem";
            this.archiverUneÉquipeToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.archiverUneÉquipeToolStripMenuItem.Text = "Désinscrire une équipe";
            this.archiverUneÉquipeToolStripMenuItem.Click += new System.EventHandler(this.archiverUneÉquipeToolStripMenuItem_Click);
            // 
            // mEMBREToolStripMenuItem
            // 
            this.mEMBREToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesMembresToolStripMenuItem,
            this.ajouterUnMembreToolStripMenuItem,
            this.modifierUnMembreToolStripMenuItem,
            this.effacerUnMembreToolStripMenuItem});
            this.mEMBREToolStripMenuItem.Name = "mEMBREToolStripMenuItem";
            this.mEMBREToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.mEMBREToolStripMenuItem.Text = "MEMBRE";
            // 
            // listeDesMembresToolStripMenuItem
            // 
            this.listeDesMembresToolStripMenuItem.Name = "listeDesMembresToolStripMenuItem";
            this.listeDesMembresToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.listeDesMembresToolStripMenuItem.Text = "Liste des membres";
            this.listeDesMembresToolStripMenuItem.Click += new System.EventHandler(this.listeDesMembresToolStripMenuItem_Click);
            // 
            // ajouterUnMembreToolStripMenuItem
            // 
            this.ajouterUnMembreToolStripMenuItem.Name = "ajouterUnMembreToolStripMenuItem";
            this.ajouterUnMembreToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.ajouterUnMembreToolStripMenuItem.Text = "Ajouter un membre";
            this.ajouterUnMembreToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnMembreToolStripMenuItem_Click);
            // 
            // modifierUnMembreToolStripMenuItem
            // 
            this.modifierUnMembreToolStripMenuItem.Name = "modifierUnMembreToolStripMenuItem";
            this.modifierUnMembreToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.modifierUnMembreToolStripMenuItem.Text = "Modifier un membre";
            this.modifierUnMembreToolStripMenuItem.Click += new System.EventHandler(this.modifierUnMembreToolStripMenuItem_Click);
            // 
            // effacerUnMembreToolStripMenuItem
            // 
            this.effacerUnMembreToolStripMenuItem.Name = "effacerUnMembreToolStripMenuItem";
            this.effacerUnMembreToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.effacerUnMembreToolStripMenuItem.Text = "Effacer un membre";
            this.effacerUnMembreToolStripMenuItem.Click += new System.EventHandler(this.effacerUnMembreToolStripMenuItem_Click);
            // 
            // sUIVIToolStripMenuItem
            // 
            this.sUIVIToolStripMenuItem.Name = "sUIVIToolStripMenuItem";
            this.sUIVIToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.sUIVIToolStripMenuItem.Text = "SUIVI";
            this.sUIVIToolStripMenuItem.Click += new System.EventHandler(this.sUIVIToolStripMenuItem_Click);
            // 
            // DECONNEXIONToolStripMenuItem
            // 
            this.DECONNEXIONToolStripMenuItem.Name = "DECONNEXIONToolStripMenuItem";
            this.DECONNEXIONToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.DECONNEXIONToolStripMenuItem.Text = "DECONNEXION";
            this.DECONNEXIONToolStripMenuItem.Click += new System.EventHandler(this.DECONNEXIONToolStripMenuItem_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FloralWhite;
            this.panelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelPrincipal.Controls.Add(this.pictureBox1);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 34);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1067, 521);
            this.panelPrincipal.TabIndex = 1;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPrincipal_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1047, 517);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.menuStripPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenu";
            this.Text = "HACKAT\'INNOV";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem hACKATHONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesHackathonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesHackathonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eQUIPEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DECONNEXIONToolStripMenuItem;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem listeDesÉquipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEMBREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUneÉquipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUneÉquipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiverUneÉquipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesMembresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnMembreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnMembreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effacerUnMembreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUIVIToolStripMenuItem;
    }
}