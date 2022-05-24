using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersMediaTek86.Modele
{
    /// <summary>
    /// Classe Responsable
    /// </summary>
    public class Responsable
    {
        private string login;
        private string pwd;

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }

        /// <summary>
        /// Récupération du login du responsable
        /// </summary>
        public string Login { get => login; }
        /// <summary>
        /// Récupération du pwd du responsable
        /// </summary>
        public string Pwd { get => pwd; }

    }
}
