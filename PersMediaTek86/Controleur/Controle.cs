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
        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public Controle()
        {
            (new FrmGestion(this)).ShowDialog();
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




    }
}
