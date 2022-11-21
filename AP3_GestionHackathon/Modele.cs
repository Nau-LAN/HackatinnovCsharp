using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace AP3_GestionHackathon
{
    public static class Modele
    {
        private static HackatonEntities maConnexion;

        /// <summary>
        /// initialise la connexion à la BD
        /// </summary>
        public static void init()
        {
            maConnexion = new HackatonEntities();
        }

        /// <summary>
        /// Retourne toute la liste des hackathons
        /// </summary>
        /// <returns></returns>
        public static List<HACKATHON> listeHackathons()
        {
            return maConnexion.HACKATHON.ToList();
        }

        public static List<EQUIPE> listeEquipes()
        {
            return maConnexion.EQUIPE.ToList();
        }

        public static List<INSCRIRE> listeInscriptions()
        {
            return maConnexion.INSCRIRE.ToList();
        }

        public static List<MEMBRE> listeMembres()
        {
            return maConnexion.MEMBRE.ToList();
        }


        /// <summary>
        /// Retourne toute la liste des organisateurs
        /// </summary>
        /// <returns></returns>
        public static List<ORGANISATEUR> listeOrganisateurs()
        {
            return maConnexion.ORGANISATEUR.ToList();
        }

        /// <summary>
        /// Retourne la liste des équipes inscrites à l'hackathon dont l'identifiant est passé en paramètre
        /// </summary>
        /// <param name="idH"></param>
        /// <returns></returns>
        public static List<EQUIPE> listeEquipesParHackathon(int idH)
        {
            // parcourir les équipes et récupérer celle de l'hackathon
            HACKATHON h = maConnexion.HACKATHON.Find(idH);
            List<INSCRIRE> lesI = h.INSCRIRE.ToList();
            List<EQUIPE> lesE = new List<EQUIPE>();
            foreach (INSCRIRE I in lesI)
            {
                lesE.Add(I.EQUIPE);
            }
            return lesE;
        }

        /// <summary>
        /// Retourne l'identifiant du dernier hackathon saisi dans la BD
        /// </summary>
        /// <returns></returns>
        public static int RetourneDernierHackathonSaisi()
        {
            return maConnexion.HACKATHON.Max(x => x.idhackathon);
        }

        /// <summary>
        /// Retourne vrai si l'ajout d'un hackathon a pu avoir lieu en BD
        /// Faux sinon
        /// </summary>
        /// <param name="lieu"></param>
        /// <param name="ville"></param>
        /// <param name="thematique"></param>
        /// <param name="objectifs"></param>
        /// <param name="conditions"></param>
        /// <param name="affiche"></param>
        /// <param name="dateD"></param>
        /// <param name="dateF"></param>
        /// <param name="idOrganisateur"></param>
        /// <returns></returns>
        /// 

        #region Ajout
        public static bool AjoutHackathon(string lieu, string ville, string thematique, string objectifs, string conditions, string affiche, DateTime dateD, DateTime dateF,int idOrganisateur, int equipMax, DateTime dateBut)
        {
            HACKATHON unHackathon;
            bool vretour = true;
            try
            {
                // ajout dans la table HACKATHON
                unHackathon = new HACKATHON();
                unHackathon.lieu = lieu;
                unHackathon.ville = ville;
                unHackathon.thematique = thematique;
                unHackathon.conditions = conditions;
                unHackathon.objectifs = objectifs;
                unHackathon.affiche = affiche;
                unHackathon.dateheuredebuth = dateD;
                unHackathon.dateheurefinh = dateF;
                unHackathon.idorganisateur = idOrganisateur;
                unHackathon.nbEquipMax = equipMax;
                unHackathon.dateFinInscription = dateBut;
       
                maConnexion.HACKATHON.Add(unHackathon);
                maConnexion.SaveChanges();
                               
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        /// <summary>
        /// Fonction qui retourne l'objet hackathon qui correspond à l'identifiant passé en paramètre 
        /// </summary>
        /// <param name="idH">identifiant de l'hackathon</param>
        /// <returns></returns>
        /// 

        public static bool AjoutEquipe(string nom, string prototype, string login, string mdp, int hackathon, int nbJoueurs, DateTime dateInscri)
        {
            EQUIPE uneEquipe;
            INSCRIRE uneInscription;
            bool vretour = true;
            try
            {
                uneEquipe = new EQUIPE();
                uneEquipe.nomequipe = nom;
                uneEquipe.lienprototype = prototype;
                uneEquipe.nbparticipants = nbJoueurs;
                uneEquipe.login = login;
                uneEquipe.password = mdp;

                maConnexion.EQUIPE.Add(uneEquipe);

                uneInscription = new INSCRIRE();
                uneInscription.idhackathon = hackathon;
                uneInscription.idequipe = uneEquipe.idequipe;
                uneInscription.dateinscription = dateInscri;

                maConnexion.INSCRIRE.Add(uneInscription);

                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool AjoutMembre(string nom, string prenom, string email, DateTime dnaiss, string telephone, string portfolio, int equipe)
        {
            MEMBRE unMembre;
            bool vretour = true;
            try
            {
                unMembre = new MEMBRE();
                unMembre.nom = nom;
                unMembre.prenom = prenom;
                unMembre.email = email;
                unMembre.datenaissance = dnaiss;
                unMembre.telephone = telephone;
                unMembre.lienportfolio = portfolio;
                unMembre.idequipe = equipe;
                unMembre.avatar = "test";

                maConnexion.MEMBRE.Add(unMembre);

                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
        #endregion Ajout

        #region Modification

        /// <summary>
        /// Retourne vrai si la modification de l'hackathon dont l'identifiant est passé en paramètre a pu avoir lieu
        /// </summary>
        /// <param name="idH"></param>
        /// <param name="lieu"></param>
        /// <param name="ville"></param>
        /// <param name="thematique"></param>
        /// <param name="objectifs"></param>
        /// <param name="conditions"></param>
        /// <param name="affiche"></param>
        /// <param name="dateD"></param>
        /// <param name="dateF"></param>
        /// <param name="idOrganisateur"></param>
        /// <returns></returns>
        public static bool ModificationHackathon(int idH, string lieu, string ville, string thematique, string objectifs, string conditions, string affiche, DateTime dateD, DateTime dateF, int idOrganisateur, int equipMax, DateTime dateBut)
        {
            HACKATHON unHackathon;
            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                unHackathon = RecupererHackathon(idH);

                // mise à jour des champs de l'hackathon
                unHackathon.lieu = lieu;
                unHackathon.ville = ville;
                unHackathon.thematique = thematique;
                unHackathon.conditions = conditions;
                unHackathon.objectifs = objectifs;
                unHackathon.affiche = affiche;
                unHackathon.dateheuredebuth = dateD;
                unHackathon.dateheurefinh = dateF;
                unHackathon.idorganisateur = idOrganisateur;
                unHackathon.nbEquipMax = equipMax;
                unHackathon.dateFinInscription = dateBut;

                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
        public static bool ModifierEquipe(int idE, string nom, string proto, string login, string mdp, int nbJoueurs)
        {
            EQUIPE uneEquipe;
            bool vretour = true;

            try
            {
                // Récupération de l'équipe à modifier
                uneEquipe = RecupererEquipe(idE);

                // Modification des données de l'équipe
                uneEquipe.nomequipe = nom;
                uneEquipe.lienprototype = proto;
                uneEquipe.login = login;
                uneEquipe.password = mdp;
                uneEquipe.nbparticipants = nbJoueurs;

                maConnexion.SaveChanges();
            }

            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool ModifierMembre(int idM, string nom, string prenom, string email, DateTime dnaiss, string telephone, string portfolio, int idEquipe)
        {
            MEMBRE unMembre;
            bool vretour = true;

            try
            {
                // Récupération du membre à modifier
                unMembre = RecupererMembre(idM);

                // Modification des données du membre
                unMembre.nom = nom;
                unMembre.prenom = prenom;
                unMembre.email = email;
                unMembre.datenaissance = dnaiss;
                unMembre.telephone = telephone;
                unMembre.lienportfolio = portfolio;
                unMembre.idequipe = idEquipe;

                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
        #endregion Modification

        #region Suppression
        public static bool SupprimerHackathon(int idH)
        {
            bool vretour = true;
            try
            {
                HACKATHON unHackathon = RecupererHackathon(idH);
                maConnexion.HACKATHON.Remove(unHackathon);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " " +
               ex.InnerException.InnerException.Message);
                vretour = false;
            }
            return vretour;
        }

        public static bool supprimerEquipe(int idE)
        {
            bool vretour = true;

            try
            {
                EQUIPE uneEquipe = RecupererEquipe(idE);
                maConnexion.EQUIPE.Remove(uneEquipe);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " +
                ex.InnerException.InnerException.Message);
                vretour = false;
            }
            return vretour;
        }

        public static bool supprimerMembre(int idM)
        {
            bool vretour = true;

            try
            {
                MEMBRE unMembre = RecupererMembre(idM);
                maConnexion.MEMBRE.Remove(unMembre);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " +
                ex.InnerException.InnerException.Message);
                vretour = false;
            }
            return vretour;
        }
        #endregion Suppression

        #region Archivage
        public static bool ArchiverHackathon(int idH)
        {
            HACKATHON unHackathon;
            bool vretour = true;
            try
            {
                unHackathon = RecupererHackathon(idH);

                unHackathon.estArchive = true;

                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
        public static bool ArchiverEquipe(int idE)
        {
            EQUIPE uneEquipe;
            bool vretour = true;
            try
            {
                uneEquipe = RecupererEquipe(idE);

                uneEquipe.estArchive = true;

                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
        #endregion Archivage

        #region Recuperation
        public static HACKATHON RecupererHackathon(int idH)
        {
            HACKATHON unHackathon = new HACKATHON();
            try
            {
                unHackathon = maConnexion.HACKATHON.First(x => x.idhackathon == idH);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unHackathon;
        }

        public static EQUIPE RecupererEquipe(int idE)
        {
            EQUIPE uneEquipe = new EQUIPE();
            try
            {
                uneEquipe = maConnexion.EQUIPE.First(x => x.idequipe == idE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneEquipe;
        }

        public static MEMBRE RecupererMembre(int idM)
        {
            MEMBRE unMembre = new MEMBRE();
            try
            {
                unMembre = maConnexion.MEMBRE.First(x => x.idmembre == idM);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unMembre;
        }
        #endregion Recuperation


        /// <summary>
        /// Retourne vrai si l'ajout d'un organisateur a pu avoir lieu
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool AjoutOrganisateur(string nom, string prenom, string email)
        {
            ORGANISATEUR unOrga;
            bool vretour = true;
            try
            {
                // ajout dans la table commande
                unOrga = new ORGANISATEUR();
                unOrga.nom = nom;
                unOrga.prenom = prenom;
                unOrga.email = email;

                maConnexion.ORGANISATEUR.Add(unOrga);
                maConnexion.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool VerifAdmin(string mail, string mdp)
        {
            bool connecter = false;
            ADMINISTRATEUR admin = new ADMINISTRATEUR();

            try
            {
                admin = maConnexion.ADMINISTRATEUR.First(x => x.email == mail);
                if(BC.Verify(mdp , admin.motpasse))
                {
                    connecter = true;
                }
            }
            catch
            {

            }
            return connecter;
        }


    }
}
