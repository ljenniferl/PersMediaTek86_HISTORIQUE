using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersMediaTek86.Controleur;

namespace PersMediaTek86
{
    /// <summary>
    /// Interface Gestion
    /// </summary>
    public partial class FrmGestion : Form
    {
        /// <summary>
        /// Instance du controleur
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Initialisation des composants graphiques
        /// Récupération du controleur
        /// </summary>
        /// <param name="controle"></param>
        public FrmGestion(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }
    }
}
