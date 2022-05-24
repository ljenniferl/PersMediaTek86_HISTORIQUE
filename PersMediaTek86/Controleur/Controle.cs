using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersMediaTek86.Dal;
using PersMediaTek86.Modele;
using PersMediaTek86.Vue;

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

        /// <summary>
        /// Récupère et retourne les infos des personnels provenant de la BDD
        /// </summary>
        /// <returns>liste des personnels</returns>
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
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void AddPersonnel(Personnel personnel)
        {
            AccesDonnees.AddPersonnel(personnel);
        }


    }
}
