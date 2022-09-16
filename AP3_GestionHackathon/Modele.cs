using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP3_GestionHackathon
{
    public static class Modele
    {
        private static AP3_BD_HACKATHON_INITIALEntities maConnexion;

        /// <summary>
        /// initialise la connexion à la BD
        /// </summary>
        public static void init()
        {
            maConnexion = new AP3_BD_HACKATHON_INITIALEntities();
        }

        /// <summary>
        /// Retourne toute la liste des hackathons
        /// </summary>
        /// <returns></returns>
        public static List<HACKATHON> listeHackathons()
        {
            return maConnexion.HACKATHON.ToList();
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
        public static bool AjoutHackathon(string lieu, string ville, string thematique, string objectifs, string conditions, string affiche, DateTime dateD, DateTime dateF,int idOrganisateur)
        {
            HACKATHON unHackathon;
            bool vretour = true;
            try
            {
                // ajout dans la table commande
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
        public static bool ModificationHackathon(int idH, string lieu, string ville, string thematique, string objectifs, string conditions, string affiche, DateTime dateD, DateTime dateF, int idOrganisateur)
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
    }
}
