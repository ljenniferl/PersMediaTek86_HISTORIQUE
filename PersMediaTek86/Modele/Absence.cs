using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersMediaTek86.Modele
{
    /// <summary>
    /// Classe Absence
    /// </summary>
    public class Absence
    {
        private int idpersonnel;
        private DateTime dateDebut;
        private int idmotif;
        private string libelle;
        private DateTime dateFin;

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="dateDebut"></param>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        /// <param name="dateFin"></param>
        public Absence(int idpersonnel, DateTime dateDebut, int idmotif, string libelle, DateTime dateFin)
        {
            this.idpersonnel = idpersonnel;
            this.dateDebut = dateDebut;
            this.idmotif = idmotif;
            this.libelle = libelle;
            this.dateFin = dateFin;
        }

        /// <summary>
        /// Récupération de l'id du personnel
        /// </summary>
        public int Idpersonnel { get => idpersonnel; }
        /// <summary>
        /// Récupération de la date de début de l'absence
        /// </summary>
        public DateTime DateDebut { get => dateDebut; }
        /// <summary>
        /// Récupération de l'id du motif d'absence
        /// </summary>
        public int Idmotif { get => idmotif; }
        /// <summary>
        /// Récupération du libellé du motif d'absence
        /// </summary>
        public string Libelle { get => libelle; }
        /// <summary>
        ///  Récupération de la date de fin de l'absence
        /// </summary>
        public DateTime DateFin { get => dateFin; }

    }
}
