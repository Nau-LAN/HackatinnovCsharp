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
    public enum EtatGestion
    {
        Create, 
        Update,
        Archive,
        Delete
    }
    public partial class FormGestionHackathon : Form
    {
        private EtatGestion etat;
        public FormGestionHackathon(EtatGestion etat)
        {
            InitializeComponent();
            this.etat = etat;
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RemplirListeHackathons()
        {
            cbListe.ValueMember = "idhackathon";//permet de stocker l'identifiant
            cbListe.DisplayMember = "thematique";
            BSListeH.DataSource = Modele.listeHackathons();
            cbListe.DataSource = BSListeH;
            cbListe.SelectedIndex = -1;
        }
        public void RemplirListeOrganisateurs()
        {
            cbOrganisateur.ValueMember = "idorganisateur";//permet de stocker l'identifiant
            cbOrganisateur.DisplayMember = "nom";
            BSOrganisateur.DataSource = Modele.listeOrganisateurs();
            cbOrganisateur.DataSource = BSOrganisateur;
            cbOrganisateur.SelectedIndex = -1;
        }
        private void FormGestionHackathon_Load(object sender, EventArgs e)
        {
            RemplirListeOrganisateurs();
            if (etat == EtatGestion.Create) // cas etat create
            {
                label1.Text = "Ajout d'un Hackathon";
                BtnAction.Text = "AJOUTER";
                gbInfo.Visible = true;
                cbListe.Visible = false;

            }
            if (etat == EtatGestion.Update) // cas etat update
            {
                label1.Text = "Modification d'un Hackathon";
                BtnAction.Text = "MODIFIER";
                gbInfo.Visible = false;
                cbListe.Visible = true;
                RemplirListeHackathons();
            }
            if (etat == EtatGestion.Archive) // cas etat archive
            {
                label1.Text = "Archiver un Hackathon";
                BtnAction.Text = "ARCHIVER";
                gbInfo.Visible = false;
                cbListe.Visible = true;
                RemplirListeHackathons();
                Desactiver();

            }
            if (etat == EtatGestion.Delete) // cas etat delete
            {
                label1.Text = "Supprimer un Hackathon";
                BtnAction.Text = "EFFACER";
                gbInfo.Visible = false;
                cbListe.Visible = true;
                RemplirListeHackathons();
                Desactiver();

            }
        }

        private void Annuler()
        {
            dateButoirePicker.Value = DateTime.Now;
            dtDebut.Value = DateTime.Now;
            dtFin.Value = DateTime.Now;
            equipesMaxBox.Value = 0;
            tbAffiche.Clear();
            tbLieu.Clear();
            tbVille.Clear();
            tbObjectifs.Clear();
            tbConditions.Clear();
            tbThematique.Clear();
            cbOrganisateur.SelectedIndex = -1;
            tbLieu.Focus();
        }

        private void Desactiver()
        {
            dtDebut.Enabled = false;
            dtFin.Enabled = false;
            dateButoirePicker.Enabled = false;
            tbLieu.Enabled = false;
            tbVille.Enabled = false;
            tbThematique.Enabled = false;
            tbObjectifs.Enabled = false;
            tbConditions.Enabled = false;
            cbOrganisateur.Enabled = false;
            tbAffiche.Enabled = false;
            equipesMaxBox.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int idOrga = -1, equipMax;
            string lieu, ville, thematique, objectifs, conditions, affiche;
            DateTime dateDeb, dateFin, dateBut;

            if (etat == EtatGestion.Create || etat == EtatGestion.Update)
            {
                if (tbLieu.Text !="" && tbVille.Text !="" && tbThematique.Text !="")
                {
                    // ajout possible si les champs lieu, ville et thématique au moins remplis
                    if (dtDebut.Value < dtFin.Value && dateButoirePicker.Value < dtDebut.Value)
                    {
                        // ajout possible si la date de début en avant la date de fin et si la date de début est bien supérieure ou égale à la date du jour
                        lieu = tbLieu.Text;
                        ville = tbVille.Text;
                        thematique = tbThematique.Text;
                        objectifs = tbObjectifs.Text;
                        conditions = tbConditions.Text;
                        affiche = tbAffiche.Text;
                        dateDeb = dtDebut.Value;
                        dateFin = dtFin.Value;
                        equipMax = Convert.ToInt32(equipesMaxBox.Text);
                        dateBut = dateButoirePicker.Value;
                        if (cbOrganisateur.SelectedIndex != -1)
                        {
                            idOrga = Convert.ToInt32(cbOrganisateur.SelectedValue.ToString());
                        }

                        if (etat == EtatGestion.Create) // cas de l'ajout
                        {
                            if (Modele.AjoutHackathon(lieu, ville, thematique, objectifs, conditions, affiche, dateDeb, dateFin, idOrga, equipMax, dateBut))
                            {
                                MessageBox.Show("Hackathon ajouté " + Modele.RetourneDernierHackathonSaisi());
                                Annuler();
                            }
                        }
                        if (etat == EtatGestion.Update) // cas de la mise à jour
                        {
                            HACKATHON H = (HACKATHON)BSListeH.Current;
                            if (Modele.ModificationHackathon(H.idhackathon, lieu, ville, thematique, objectifs, conditions, affiche, dateDeb, dateFin, idOrga, equipMax, dateBut))
                            {
                                MessageBox.Show("Hackathon modifié");
                                gbInfo.Visible = false;
                                cbListe.SelectedIndex = -1;
                               // Annuler();
                            }
                        }


                    }
                    else
                    {
                        MessageBox.Show("Ajout impossible : problème sur les dates et heures", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Ajout impossible : Il faut saisir au moins le lieu, la ville et la thématique", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (etat == EtatGestion.Delete) // cas de la suppression
            {
                HACKATHON H = (HACKATHON)BSListeH.Current;

                DialogResult dialogResult = MessageBox.Show("Toute suppression est définitive. Confirmer ?", "Confirmer suppression", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    if (Modele.SupprimerHackathon(H.idhackathon))
                    {
                        MessageBox.Show("Hackathon supprimé");
                        gbInfo.Visible = false;
                        cbListe.SelectedIndex = -1;
                        RemplirListeHackathons();
                    }
                }

            }
            if (etat == EtatGestion.Archive) // cas de l'archivage
            {
                HACKATHON H = (HACKATHON)BSListeH.Current;
                if (Modele.ArchiverHackathon(H.idhackathon))
                {
                    MessageBox.Show("Hackathon archivé");
                    gbInfo.Visible = false;
                    cbListe.SelectedIndex = -1;
                    RemplirListeHackathons();
                }
            }
        }

        private void BtnAjoutOrganisateur_Click(object sender, EventArgs e)
        {
            FormAjoutOrganisateur FAO = new FormAjoutOrganisateur();
            FAO.Show();

           // (System.Windows.Forms.Application.OpenForms["FormMenu"] as FormMenu).openChildForm(new FormAjoutOrganisateur());
           
        }

        private void BSListeH_CurrentChanged(object sender, EventArgs e)
        {
            // si un hackathon est sélectionné dans la liste des hackathons
            if (cbListe.SelectedIndex != -1)
            {
                // récupération de l'hackathon sélectionné
                HACKATHON H = (HACKATHON)BSListeH.Current;

                // mise à jour des champs de l'hackathon sélectionné
                tbThematique.Text = H.thematique;
                tbLieu.Text = H.lieu;
                tbVille.Text = H.ville;
                tbObjectifs.Text = H.objectifs;
                tbConditions.Text = H.conditions;
                tbAffiche.Text = H.affiche;
                dtDebut.Value = H.dateheuredebuth;
                dtFin.Value = H.dateheurefinh;
                equipesMaxBox.Value = H.nbEquipMax;
                dateButoirePicker.Value = H.dateFinInscription;
                if (H.idorganisateur != null)
                {
                    cbOrganisateur.Text = H.ORGANISATEUR.nom;
                }
                gbInfo.Visible = true;
            }
            else
                gbInfo.Visible = false;
        }

        private void CbListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            BSListeH_CurrentChanged(sender, e);
        }
    }
}
