﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersMediaTek86.Controleur;
using PersMediaTek86.Dal;
using PersMediaTek86.Modele;

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
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModif = false;
        /// <summary>
        /// Objet pour gérer la liste des personnels
        /// </summary>
        BindingSource bdgPersonnels = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des services
        /// </summary>
        BindingSource bdgServices = new BindingSource();

        /// <summary>
        /// Initialisation des composants graphiques
        /// Récupération du controleur
        /// </summary>
        /// <param name="controle"></param>
        public FrmGestion(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }

        /// <summary>
        /// Initialisation de la frame : remplissage des listes
        /// </summary>
        public void Init()
        {
            RemplirListePersonnels();
            RemplirListeServices();
            grbLePersonnel.Enabled = false;
            grbLesAbsences.Enabled = false;
            grbLAbsence.Enabled = false;
        }

        /// <summary>
        /// Affiche les personnels dans dgvPersonnels
        /// </summary>
        public void RemplirListePersonnels()
        {
            List<Personnel> lesPersonnels = controle.GetLesPersonnels();
            bdgPersonnels.DataSource = lesPersonnels;
            dgvPersonnels.DataSource = bdgPersonnels;
            dgvPersonnels.Columns["idpersonnel"].Visible = false;
            dgvPersonnels.Columns["idservice"].Visible = false;
            dgvPersonnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les services dans cboService
        /// </summary>
        public void RemplirListeServices()
        {
            List<Service> lesServices = controle.GetLesServices();
            bdgServices.DataSource = lesServices;
            cboService.DataSource = bdgServices;
            if (cboService.Items.Count > 0)
            {
                cboService.SelectedIndex = -1;
            }
        }

        /// <summary>
        ///  Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjoutPersonnel_Click(object sender, EventArgs e)
        {
            grbLePersonnel.Enabled = true;
        }

        /// <summary>
        ///  Demande de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnModifPersonnel_Click(object sender, EventArgs e)
        {
            grbLePersonnel.Enabled = true;
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                enCoursDeModif = true;
                grbLesPersonnels.Enabled = false;
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cboService.SelectedIndex = cboService.FindStringExact(personnel.Service);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }

        }
    }
}
