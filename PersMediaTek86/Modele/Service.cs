using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersMediaTek86.Modele
{
    /// <summary>
    /// Classe Service
    /// </summary>
    public class Service
    {
        private int idservice;
        private string nom;

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }

        /// <summary>
        /// Récupération de l'id du service
        /// </summary>
        public int Idservice { get => idservice; }
        /// <summary>
        /// Récupération du nom du service
        /// </summary>
        public string Nom { get => nom; }

        /// <summary>
        /// Définit l'information à afficher (juste le nom du service)
        /// </summary>
        /// <returns>Nom du service</returns>
        public override string ToString()
        {
            return this.nom;
        }

    }
}
