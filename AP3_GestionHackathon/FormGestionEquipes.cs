using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace AP3_GestionHackathon
{
    public enum GestionEquipes
    {
        Create,
        Update,
        Archive,
        Delete
    }

    public partial class FormGestionEquipes : Form
    {

        private GestionEquipes etat;

        public FormGestionEquipes(GestionEquipes etat)
        {
            InitializeComponent();
            this.etat = etat;
        }

        public void RemplirListeEquipes() // Récupère et affiche les équipes dans cbEquipes
        {
            cbEquipes.ValueMember = "idequipe";
            cbEquipes.DisplayMember = "nomequipe";
            BSequipes.DataSource = Modele.listeEquipes();
            cbEquipes.DataSource = BSequipes;
            cbEquipes.SelectedIndex = -1;
        }

        public void RemplirListeHackathon() // Récupère et affiche les hackathons dans cbInscription
        {
            cbInscription.ValueMember = "idhackathon";
            cbInscription.DisplayMember = "thematique";
            BShackathons.DataSource = Modele.listeHackathons();
            cbInscription.DataSource = BShackathons;
            cbInscription.SelectedIndex = -1;
        }

        private void FormGestionEquipes_Load(object sender, EventArgs e)
        {
            RemplirListeEquipes();
            RemplirListeHackathon();

            if (etat == GestionEquipes.Create)
            {
                label2.Text = "Ajouter une équipe";
                cbEquipes.Visible = false;
                BtnAction.Text = "AJOUTER";
            }
            if (etat == GestionEquipes.Update)
            {
                label2.Text = "Modifier une équipe";
                cbEquipes.Visible = true;
                BtnAction.Text = "MODIFIER";
                Desactiver();
            }
            if (etat == GestionEquipes.Archive)
            {
                label2.Text = "Archiver une équipe";
                cbEquipes.Visible = true;
                BtnAction.Text = "ARCHIVER";
                Desactiver();
            }
            if (etat == GestionEquipes.Delete)
            {
                label2.Text = "Effacer une équipe";
                cbEquipes.Visible = true;
                BtnAction.Text = "EFFACER";
                Desactiver();
            }
        }

        private void Desactiver()
        {
            cbInscription.Enabled = false;
            dtpInscription.Enabled = false;

            if(etat != GestionEquipes.Update)
            {
                tbNom.Enabled = false;
                tbProto.Enabled = false;
                tbLogin.Enabled = false;
                tbMdp.Enabled = false;
                nudJoueursMax.Enabled = false;
            }
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            string nom, prototype, login, mdp;
            int hackathon, nbJoueurs;
            DateTime dateInscri;

            if(tbNom.Text!="" && tbLogin.Text!="" && tbMdp.Text != "")
            {
                nom = tbNom.Text;
                prototype = tbProto.Text;
                login = tbLogin.Text;
                mdp = BC.HashPassword(tbMdp.Text);
                nbJoueurs = Convert.ToInt32(nudJoueursMax.Value);
                hackathon = cbInscription.SelectedIndex;
                dateInscri = dtpInscription.Value;



                if (etat == GestionEquipes.Create) // ajout équipe
                {
                    if(cbInscription.SelectedIndex != -1)
                    {

                        if (Modele.AjoutEquipe(nom, prototype, login, mdp, hackathon, nbJoueurs, dateInscri))
                        {
                            MessageBox.Show("Equipe ajoutée");
                            Annuler();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veuillez inscrire votre équipe à un hackathon avant insertion.");
                    }

                }

                if(etat == GestionEquipes.Update) // cas de la modification
                {
                    EQUIPE E = (EQUIPE)BSequipes.Current;
                    if (Modele.ModifierEquipe(E.idequipe, nom, prototype, login, mdp, nbJoueurs))
                    {
                        MessageBox.Show("Equipe modifiée");
                        gbInfo.Visible = false;
                        cbEquipes.SelectedIndex = -1;
                    }
                }

                if (etat == GestionEquipes.Delete) // cas de la suppression
                {
                    EQUIPE E = (EQUIPE)BSequipes.Current;

                    DialogResult dialogResult = MessageBox.Show("Toute suppression est définitive. Confirmer ?", "Confirmer suppression", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        if (Modele.supprimerEquipe(E.idequipe))
                        {
                            MessageBox.Show("Equipe supprimée");
                            gbInfo.Visible = false;
                            cbEquipes.SelectedIndex = -1;
                            RemplirListeEquipes();
                        }
                    }
                }

                if (etat == GestionEquipes.Archive) // cas de l'archivage
                {
                    EQUIPE E = (EQUIPE)BSequipes.Current;

                    DialogResult dialogResult = MessageBox.Show("Vous allez désinscrire cette équipe. Confirmer ?" , "Attention", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        if (Modele.ArchiverEquipe(E.idequipe, hackathon))
                        {
                            MessageBox.Show("Equipe archivée");
                            gbInfo.Visible = false;
                            cbEquipes.SelectedIndex = -1;
                            RemplirListeEquipes();
                        }
                    }
                }
            }
        }

        private void Annuler()
        {
            tbNom.Clear();
            tbProto.Clear();
            tbLogin.Clear();
            tbMdp.Clear();
            cbInscription.SelectedIndex = -1;
            dtpInscription.Value = DateTime.Now;
            nudJoueursMax.Value = 0;
        }

        private void BSequipes_CurrentChanged(object sender, EventArgs e)
        {
            if (cbEquipes.SelectedIndex != -1)
            {
                EQUIPE E = (EQUIPE)BSequipes.Current;

                tbNom.Text = E.nomequipe;
                tbProto.Text = E.lienprototype;
                tbLogin.Text = E.login;
                tbMdp.Text = E.password;
                nudJoueursMax.Value = Convert.ToDecimal(E.nbparticipants);
            }
        }
    }
}
