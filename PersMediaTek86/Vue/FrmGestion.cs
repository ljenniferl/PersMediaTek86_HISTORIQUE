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
        /// Paramètre récupérant l'id du personnel sélectionné
        /// </summary>
        public static int monId;
        /// <summary>
        /// Paramètre récupérant la date de début de l'absence sélectionnée
        /// </summary>
        public static DateTime maDateDebut;
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
        /// Objet pour gérer la liste des absences
        /// </summary>
        BindingSource bdgAbsences = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des motifs d'absence
        /// </summary>
        BindingSource bdgMotifs = new BindingSource();


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
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnels.List[bdgPersonnels.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.DelPersonnel(personnel);
                    RemplirListePersonnels();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
            grbLePersonnel.Enabled = false;
        }

        /// <summary>
        ///  Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjoutPersonnel_Click(object sender, EventArgs e)
        {
            grbLePersonnel.Enabled = true;
            grbLesAbsences.Enabled = false;
            grbLAbsence.Enabled = false;
        }

        /// <summary>
        ///  Demande de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnModifPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                enCoursDeModif = true;
                grbLesPersonnels.Enabled = false;
                grbLePersonnel.Enabled = true;
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

        /// <summary>
        /// Vide les zones de saisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulPersonnel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ViderPersonnel();
                grbLesPersonnels.Enabled = true;
                enCoursDeModif = false;
                grbLePersonnel.Enabled = false;
            }
        }

        /// <summary>
        /// Vider les zones de saisie d'un personnel
        /// </summary>
        private void ViderPersonnel()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";
            cboService.SelectedIndex = -1;
        }

        /// <summary>
        /// Demande d'ajout ou de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregPersonnel_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cboService.SelectedIndex != -1)
            {
                Service service = (Service)bdgServices.List[bdgServices.Position];
                int idpersonnel = 0;
                if (enCoursDeModif)
                {
                    idpersonnel = (int)dgvPersonnels.SelectedRows[0].Cells["idpersonnel"].Value;
                }
                Personnel personnel = new Personnel(idpersonnel, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service.Idservice, service.Nom);
                if (enCoursDeModif)
                {
                    controle.UpdatePersonnel(personnel);
                    enCoursDeModif = false;
                    grbLesPersonnels.Enabled = true;
                    grbLePersonnel.Enabled = false;
                }
                else
                {
                    controle.AddPersonnel(personnel);
                }
                RemplirListePersonnels();
                ViderPersonnel();
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        // PARTIE ABSENCE

        /// <summary>
        /// Affiche la liste des absences du personnel séléectionné dans dgvLesPersonnels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAffichAbsences_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                monId = (int)dgvPersonnels.CurrentRow.Cells["idpersonnel"].Value;
                RemplirListeAbsences(monId);
                RemplirListeMotifs();
                grbLePersonnel.Enabled = false;
                grbLesAbsences.Enabled = true;
                grbLAbsence.Enabled = true;
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Affiche les absences dans dgvAbsences
        /// </summary>
        public void RemplirListeAbsences(int monId)
        {
            List<Absence> lesAbsences = controle.GetLesAbsences(monId);
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["idpersonnel"].Visible = false;
            dgvAbsences.Columns["idmotif"].Visible = false;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les motifs dans cboMotif
        /// </summary>
        public void RemplirListeMotifs()
        {
            List<Motif> lesMotifs = controle.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cboMotif.DataSource = bdgMotifs;
            if (cboMotif.Items.Count > 0)
            {
                cboMotif.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjoutAbsence_Click(object sender, EventArgs e)
        {
            grbLePersonnel.Enabled = false;
            grbLesAbsences.Enabled = false;
            grbLAbsence.Enabled = true;
        }

        /// <summary>
        ///  Demande de modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnModifAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                enCoursDeModif = true;
                grbLesPersonnels.Enabled = false;
                grbLePersonnel.Enabled = true;
                grbLAbsence.Enabled = true;
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                dtpDateDebut.Value = absence.DateDebut;
                dtpDateFin.Value = absence.DateFin;
                cboMotif.SelectedIndex = cboMotif.FindStringExact(absence.Libelle);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprAbsence_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer l'absence démarrant le " + absence.DateDebut + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.DelAbsence(absence);
                    RemplirListeAbsences(monId);
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
            grbLePersonnel.Enabled = false;
        }


        /// <summary>
        /// Vide les zones de saisie d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulAbsence_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ViderAbsence();
                grbLesPersonnels.Enabled = true;
                enCoursDeModif = false;
                grbLePersonnel.Enabled = false;
            }
        }

        /// <summary>
        /// Vider les zones de saisie d'une absence
        /// </summary>
        private void ViderAbsence()
        {
            dtpDateDebut.CustomFormat = "";
            dtpDateFin.CustomFormat = "";
            cboMotif.SelectedIndex = -1;
        }

        /// <summary>
        /// Demande d'ajout ou de modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregAbsence_Click(object sender, EventArgs e)
        {
            if (!dtpDateDebut.Value.Equals("") && !dtpDateFin.Value.Equals("") && cboMotif.SelectedIndex != -1)
            {
                Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
                if (enCoursDeModif)
                {
                    monId = (int)dgvAbsences.CurrentRow.Cells["idpersonnel"].Value;
                    maDateDebut = dtpDateDebut.Value;
                }
                Absence absence = new Absence(monId, dtpDateDebut.Value, dtpDateFin.Value, motif.Idmotif, motif.Libelle);
                if (enCoursDeModif)
                {
                    controle.UpdateAbsence(absence);
                    enCoursDeModif = false;
                    grbLesPersonnels.Enabled = true;
                    grbLePersonnel.Enabled = false;
                }
                else
                {
                    controle.AddAbsence(absence);
                }
                RemplirListeAbsences(monId);
                ViderAbsence();
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }



        }
    }
}
