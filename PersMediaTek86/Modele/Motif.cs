using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersMediaTek86.Modele
{
    
    /// <summary>
    /// Classe Motif d'absence
    /// </summary>
    public class Motif
    {
        private int idmotif;
        private string libelle;

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.idmotif = idmotif;
            this.libelle = libelle;
        }

        /// <summary>
        /// Récupération du motif de l'absence
        /// </summary>
        public int Idmotif { get => idmotif; }
        /// <summary>
        /// Récupération du libellé de l'absence
        /// </summary>
        public string Libelle { get => libelle; }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>libellé du motif d'absence</returns>
        public override string ToString()
        {
            return this.libelle;
        }
    }
}
