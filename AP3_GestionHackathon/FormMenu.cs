using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP3_GestionHackathon
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void DECONNEXIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConnexion FM = new FormConnexion();
            FM.Show();
            this.Close();
        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        public Form activeForm = null;
        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formEnfant);
            panelPrincipal.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        #region hackathon
        private void ListeDesHackathonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormHackathon());
        }

        private void GestionDesHackathonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionHackathon(EtatGestion.Create)); // Form de Gestion en ajout (create)
        }

        private void modificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionHackathon(EtatGestion.Update)); // Form de Gestion en modification (update)
        }

        private void suppressionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormGestionHackathon(EtatGestion.Delete)); // Form de gestion en suppression (delete)
        }

        private void archivageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormGestionHackathon(EtatGestion.Archive)); // Form de gestion en archivage (archive)
        }
        #endregion hackathon


        #region equipe
        private void ListeDesÉquipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEquipes());
        }

        private void AjouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionEquipes(GestionEquipes.Create)); // Création d'une équipe
        }
        private void modifierUneÉquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionEquipes(GestionEquipes.Update)); // Modification d'une équipe
        }

        private void supprimerUneÉquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionEquipes(GestionEquipes.Delete)); // Suppression d'une équipe
        }

        private void archiverUneÉquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionEquipes(GestionEquipes.Archive)); // Archivage d'une équipe
        }

        #endregion equipe

        #region membre
        private void ajouterUnMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionMembre(EtatMembre.Create)); // Ajout d'un membre
        }
        private void modifierUnMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionMembre(EtatMembre.Update)); // Modification d'un membre
        }

        private void effacerUnMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionMembre(EtatMembre.Delete)); //Suppression d'un membre
        }
        #endregion membre


    }
}
