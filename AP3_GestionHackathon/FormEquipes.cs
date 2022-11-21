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
    public partial class FormEquipes : Form
    {
        public FormEquipes()
        {
            InitializeComponent();
        }

        private void RemplirListeHackathon()
        {
            cbHackathon.ValueMember = "idhackathon";
            cbHackathon.DisplayMember = "thematique";
            bsHackathons.DataSource = Modele.listeHackathons();
            cbHackathon.DataSource = bsHackathons;
            cbHackathon.SelectedIndex = -1;
        }

        private void FormEquipes_Load(object sender, EventArgs e)
        {
            RemplirListeHackathon();

            bsEquipes.DataSource = Modele.listeInscriptions().Select(x => new { x.idequipe, x.EQUIPE.nomequipe, x.HACKATHON.thematique, x.EQUIPE.nbparticipants, x.EQUIPE.login, x.EQUIPE.password, x.EQUIPE.lienprototype, x.dateinscription, x.EQUIPE.estArchive })
                .Where(x => x.estArchive == false);
            dgvEquipes.DataSource = bsEquipes;

            dgvEquipes.Columns[0].HeaderText = "Identifiant";
            dgvEquipes.Columns[1].HeaderText = "Nom de l'équipe";
            dgvEquipes.Columns[2].HeaderText = "Hackathon inscrit";
            dgvEquipes.Columns[3].HeaderText = "Nombre de participants";
            dgvEquipes.Columns[4].HeaderText = "Login";
            dgvEquipes.Columns[5].HeaderText = "Mot de passe";
            dgvEquipes.Columns[6].HeaderText = "Prototype";
            dgvEquipes.Columns[7].HeaderText = "Date d'inscription";

            // Masquer colonne estArchive
            dgvEquipes.Columns[8].Visible = false;

        }

        private void bsHackathons_CurrentChanged(object sender, EventArgs e)
        {
            if(cbHackathon.SelectedIndex != -1)
            {
                bsEquipes.DataSource = Modele.listeEquipesParHackathon(cbHackathon.SelectedIndex);
                dgvEquipes.DataSource = bsEquipes;
            }
        }
    }
}
