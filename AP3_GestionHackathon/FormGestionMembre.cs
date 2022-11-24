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
    public enum EtatMembre
    {
        Create,
        Update,
        Delete,
    }

    public partial class FormGestionMembre : Form
    {
        private EtatMembre etat;

        public FormGestionMembre(EtatMembre etat)
        {
            InitializeComponent();
            this.etat = etat;
        }

        public void RemplirListeMembres()
        {
            cbMembres.ValueMember = "idmembre";
            cbMembres.DisplayMember = "prenom";
            bsMembre.DataSource = Modele.listeMembres();
            cbMembres.DataSource = bsMembre;
            cbMembres.SelectedIndex = -1;
        }

        public void RemplirListeEquipes()
        {
            cbEquipe.ValueMember = "idequipe";
            cbEquipe.DisplayMember = "nomequipe";
            bsEquipe.DataSource = Modele.listeEquipes();
            cbEquipe.DataSource = bsEquipe;
            cbEquipe.SelectedIndex = -1;
        }


        private void FormGestionMembre_Load(object sender, EventArgs e)
        {
            RemplirListeMembres();
            RemplirListeEquipes();

            if (etat == EtatMembre.Create)
            {
                lblTitre.Text = "Ajouter un membre";
                cbMembres.Visible = false;
                BtnAction.Text = "AJOUTER";
            }
            if (etat == EtatMembre.Update)
            {
                lblTitre.Text = "Modifier un membre";
                cbMembres.Visible = true;
                BtnAction.Text = "MODIFIER";
            }
            if (etat == EtatMembre.Delete)
            {
                lblTitre.Text = "Effacer un membre";
                cbMembres.Visible = true;
                BtnAction.Text = "EFFACER";
                Desactiver();
            }

        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            string nom, prenom, email, telephone, portfolio;
            int equipe = -1;
            DateTime dnaiss;

            nom = tbNom.Text;
            prenom = tbPrenom.Text;
            email = tbEmail.Text;
            dnaiss = dtpDnaiss.Value;
            telephone = tbTelephone.Text;
            portfolio = tbPortfolio.Text;
            if(cbEquipe.SelectedIndex != 1)
            {
                equipe = Convert.ToInt32(cbEquipe.SelectedValue.ToString());
            }

            if(etat == EtatMembre.Create)
            {
                if(Modele.AjoutMembre(nom, prenom, email, dnaiss, telephone, portfolio, equipe))
                {
                    MessageBox.Show("Membre ajouté");
                    Annuler();
                }
            }

            if(etat == EtatMembre.Update)
            {
                MEMBRE M = (MEMBRE)bsMembre.Current;
                if(Modele.ModifierMembre(M.idmembre, nom, prenom, email, dnaiss, telephone, portfolio, equipe))
                {
                    MessageBox.Show("Membre modifié");
                }
            }
        }

        private void Annuler()
        {
            tbNom.Clear();
            tbPrenom.Clear();
            tbEmail.Clear();
            tbPortfolio.Clear();
            tbTelephone.Clear();
            dtpDnaiss.Value = DateTime.Now;
            cbEquipe.SelectedIndex = -1;
        }

        private void Desactiver()
        {
            tbNom.Enabled = false;
            tbPrenom.Enabled = false;
            tbEmail.Enabled = false;
            tbPortfolio.Enabled = false;
            tbTelephone.Enabled = false;
            dtpDnaiss.Enabled = false;
            cbEquipe.Enabled = false;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bsMembre_CurrentChanged(object sender, EventArgs e)
        {
            if(cbMembres.SelectedIndex != -1)
            {
                MEMBRE M = (MEMBRE)bsMembre.Current;

                tbNom.Text = M.nom;
                tbPrenom.Text = M.prenom;
                tbEmail.Text = M.email;
                tbTelephone.Text = M.telephone;
                tbPortfolio.Text = M.lienportfolio;
                dtpDnaiss.Value = Convert.ToDateTime(M.datenaissance);
                if (M.idequipe != null)
                {
                    cbEquipe.Text = M.EQUIPE.nomequipe;
                }
            }
        }
    }
}
