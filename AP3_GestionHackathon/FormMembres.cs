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
    public partial class FormMembres : Form
    {
        public FormMembres()
        {
            InitializeComponent();
        }

        private void FormMembres_Load(object sender, EventArgs e)
        {
            bsMembres.DataSource = Modele.listeMembres().Select(x => new { x.idmembre, x.nom, x.prenom, x.EQUIPE.nomequipe, x.email, x.telephone, x.datenaissance, x.lienportfolio });
            dgvMembres.DataSource = bsMembres;

            dgvMembres.Columns[0].HeaderText = "Identifiant";
            dgvMembres.Columns[1].HeaderText = "Nom";
            dgvMembres.Columns[2].HeaderText = "Prénom";
            dgvMembres.Columns[3].HeaderText = "Equipe";
            dgvMembres.Columns[4].HeaderText = "Email";
            dgvMembres.Columns[5].HeaderText = "Téléphone";
            dgvMembres.Columns[6].HeaderText = "Date de naissance";
            dgvMembres.Columns[7].HeaderText = "Portfolio";
        }
    }
}
