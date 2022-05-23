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

namespace PersMediaTek86.Vue
{
    /// <summary>
    /// Interface Authentification
    /// </summary>
    public partial class FrmAuthentification : Form
    {
        /// <summary>
        /// Instance du contrôleur
        /// </summary>
        private Controle controle;

        /// <summary>
        /// FrmAuthentification
        /// </summary>
        /// <param name="controle"></param>
        public FrmAuthentification(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

        /// <summary>
        /// Demande au contrôleur de contrôler l'authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (!txtLogin.Text.Equals("") && !txtPwd.Text.Equals(""))
            {
                if (!controle.ControleAuthentification(txtLogin.Text, txtPwd.Text))
                {
                    MessageBox.Show("Authentification incorrecte", "Alerte");
                    txtLogin.Text = "";
                    txtPwd.Text = "";
                    txtLogin.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
                txtLogin.Text = "";
                txtPwd.Text = "";
                txtLogin.Focus();
            }
        }
    }
}
