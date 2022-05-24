using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
