using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersMediaTek86.Modele
{
    /// <summary>
    ///  Classe Personnel
    /// </summary>
    public class Personnel
    {
        private int idpersonnel;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;
        private int idservice;
        private string service;
        
        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idservice"></param>
        /// <param name="service"></param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, int idservice, string service)
        {
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.idservice = idservice;
            this.service = service;
        }

        /// <summary>
        /// Récupération de l'id du personnel
        /// </summary>
        public int Idpersonnel { get => idpersonnel; }
        /// <summary>
        /// Récupération du nom
        /// </summary>
        public string Nom { get => nom; }
        /// <summary>
        /// Récupération du prénom
        /// </summary>
        public string Prenom { get => prenom; }
        /// <summary>
        /// Récupération du téléphone
        /// </summary>
        public string Tel { get => tel; }
       /// <summary>
       /// Récupération du mail
       /// </summary>
        public string Mail { get => mail; }
        /// <summary>
        /// Récupération de l'id du service
        /// </summary>
        public int Idservice { get => idservice; }
        /// <summary>
        /// Récupération du nom du service
        /// </summary>
        public string Service { get => service; }
    }
}
