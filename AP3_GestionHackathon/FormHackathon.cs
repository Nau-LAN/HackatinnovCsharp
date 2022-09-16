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
    public partial class FormHackathon : Form
    {
        public FormHackathon()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BSHackathon.DataSource = Modele.listeHackathons().Select(x => new { x.idhackathon, x.thematique, x.lieu, x.ville, x.dateheuredebuth, x.dateheurefinh, x.objectifs, x.ORGANISATEUR.nom, x.ORGANISATEUR.prenom })
                           .OrderBy(x => x.dateheuredebuth); 

            dgvHackathon.DataSource = BSHackathon;
            dgvHackathon.Columns[0].HeaderText = "Identifiant";
            dgvHackathon.Columns[1].HeaderText = "Thématique";
            dgvHackathon.Columns[2].HeaderText = "Lieu";
            dgvHackathon.Columns[3].HeaderText = "Ville";
            dgvHackathon.Columns[4].HeaderText = "Date de début";
            dgvHackathon.Columns[5].HeaderText = "Date de fin";
            dgvHackathon.Columns[6].HeaderText = "Objectifs";
            dgvHackathon.Columns[7].HeaderText = "Nom Organisateur";
            dgvHackathon.Columns[8].HeaderText = "Prénom Organisateur";
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VoirLesÉquipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Type type = BSHackathon.Current.GetType();
            int idH = (int)type.GetProperty("idhackathon").GetValue(BSHackathon.Current, null);
            List<EQUIPE> lesEquipes = Modele.listeEquipesParHackathon(idH);
            if (lesEquipes.Count != 0)
            {
                BSEquipe.DataSource = (lesEquipes).Select(x => new
                {
                    x.idequipe,
                    x.nomequipe,
                    x.nbparticipants
                });

                dgvEquipes.DataSource = BSEquipe;
                dgvEquipes.Visible = true;
            }
            else
            {
                dgvEquipes.Visible = false;
                MessageBox.Show("Pas d'équipe pour cet hackathon");
            }
        }

        private void DgvHackathon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEquipes.Visible = false;
        }

        private void DgvHackathon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvEquipes.Visible = false;
        }

        private void DgvHackathon_Click(object sender, EventArgs e)
        {
            dgvEquipes.Visible = false;
        }
    }
}
