using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersMediaTek86.Dal;
using PersMediaTek86.Modele;

namespace PersMediaTek86.Controleur
{
    /// <summary>
    /// Gère les interactions entre la vue et le modèle
    /// </summary>
    public class Controle
    {
        // OUVERTURE DE L'APPLICATION ET CONTROLE DE LA CONNEXION

        /// <summary>
        /// Fenêtre d'authentification
        /// </summary>
        private FrmAuthentification frmAuthentification;

        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public Controle()
        {
            frmAuthentification = new FrmAuthentification(this);
            frmAuthentification.ShowDialog();
        }

        // PARTIE PERSONNEL

        /// <summary>
        /// Demande la vérification de l'authentification
        /// Si l'authentification est correcte, ouvre la fenêtre principale
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public Boolean ControleAuthentification(string login, string pwd)
        {
            if (AccesDonnees.ControleAuthentification(login, pwd))
            {
                frmAuthentification.Hide();
                (new FrmGestion(this)).ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
        }


        // PARTIE PERSONNEL

        /// <summary>
        /// Récupère et retourne les infos des personnels provenant de la BDD
        /// </summary>
        /// <returns>Liste des personnels</returns>
        public List<Personnel> GetLesPersonnels()
        {
            return AccesDonnees.GetLesPersonnels();
        }

        /// <summary>
        /// Récupère et retourne les infos des services provenant de la BDD
        /// </summary>
        /// <returns>Liste des services</returns>
        public List<Service> GetLesServices()
        {
            return AccesDonnees.GetLesServices();
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">Objet personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            AccesDonnees.DelPersonnel(personnel);
        }

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel">Objet personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            AccesDonnees.AddPersonnel(personnel);
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel">Objet personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            AccesDonnees.UpdatePersonnel(personnel);
        }

        // PARTIE ABSENCE
        
        /// <summary>
        /// Récupère et retourne les infos des absences provenant de la BDD
        /// </summary>
        /// <returns>Liste des absences</returns>
        public List<Absence> GetLesAbsences(int monId)
        {
            return AccesDonnees.GetLesAbsences(monId);
        }

        /// <summary>
        /// Récupère et retourne les infos des motifs provenant de la BDD
        /// </summary>
        /// <returns>Liste des motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            return AccesDonnees.GetLesMotifs();
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">Objet absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            AccesDonnees.DelAbsence(absence);
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">Objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            AccesDonnees.AddAbsence(absence);
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">Objet absence à modifier</param>
        public void UpdateAbsence(Absence absence)
        {
            AccesDonnees.UpdateAbsence(absence);
        }
    }
}
