
namespace PersMediaTek86
{
    partial class FrmGestion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbLesPersonnels = new System.Windows.Forms.GroupBox();
            this.btnSupprPersonnel = new System.Windows.Forms.Button();
            this.btnModifPersonnel = new System.Windows.Forms.Button();
            this.btnAjoutPersonnel = new System.Windows.Forms.Button();
            this.btnAffichAbsences = new System.Windows.Forms.Button();
            this.dgvPersonnels = new System.Windows.Forms.DataGridView();
            this.grbLesAbsences = new System.Windows.Forms.GroupBox();
            this.btnSupprAbsence = new System.Windows.Forms.Button();
            this.btnModifAbsence = new System.Windows.Forms.Button();
            this.btnAjoutAbsence = new System.Windows.Forms.Button();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.grbLePersonnel = new System.Windows.Forms.GroupBox();
            this.btnEnregPersonnel = new System.Windows.Forms.Button();
            this.btnAnnulPersonnel = new System.Windows.Forms.Button();
            this.lblService = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.grbLAbsence = new System.Windows.Forms.GroupBox();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.btnEnregAbsence = new System.Windows.Forms.Button();
            this.btnAnnulAbsence = new System.Windows.Forms.Button();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.cboMotif = new System.Windows.Forms.ComboBox();
            this.grbLesPersonnels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).BeginInit();
            this.grbLesAbsences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.grbLePersonnel.SuspendLayout();
            this.grbLAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLesPersonnels
            // 
            this.grbLesPersonnels.Controls.Add(this.btnSupprPersonnel);
            this.grbLesPersonnels.Controls.Add(this.btnModifPersonnel);
            this.grbLesPersonnels.Controls.Add(this.btnAjoutPersonnel);
            this.grbLesPersonnels.Controls.Add(this.btnAffichAbsences);
            this.grbLesPersonnels.Controls.Add(this.dgvPersonnels);
            this.grbLesPersonnels.Location = new System.Drawing.Point(12, 12);
            this.grbLesPersonnels.Name = "grbLesPersonnels";
            this.grbLesPersonnels.Size = new System.Drawing.Size(530, 250);
            this.grbLesPersonnels.TabIndex = 0;
            this.grbLesPersonnels.TabStop = false;
            this.grbLesPersonnels.Text = "Liste des personnels";
            // 
            // btnSupprPersonnel
            // 
            this.btnSupprPersonnel.Location = new System.Drawing.Point(206, 207);
            this.btnSupprPersonnel.Name = "btnSupprPersonnel";
            this.btnSupprPersonnel.Size = new System.Drawing.Size(90, 30);
            this.btnSupprPersonnel.TabIndex = 4;
            this.btnSupprPersonnel.Text = "Supprimer";
            this.btnSupprPersonnel.UseVisualStyleBackColor = true;
            this.btnSupprPersonnel.Click += new System.EventHandler(this.btnSupprPersonnel_Click);
            // 
            // btnModifPersonnel
            // 
            this.btnModifPersonnel.Location = new System.Drawing.Point(110, 207);
            this.btnModifPersonnel.Name = "btnModifPersonnel";
            this.btnModifPersonnel.Size = new System.Drawing.Size(90, 30);
            this.btnModifPersonnel.TabIndex = 3;
            this.btnModifPersonnel.Text = "Modifier";
            this.btnModifPersonnel.UseVisualStyleBackColor = true;
            this.btnModifPersonnel.Click += new System.EventHandler(this.btnModifPersonnel_Click);
            // 
            // btnAjoutPersonnel
            // 
            this.btnAjoutPersonnel.Location = new System.Drawing.Point(14, 207);
            this.btnAjoutPersonnel.Name = "btnAjoutPersonnel";
            this.btnAjoutPersonnel.Size = new System.Drawing.Size(90, 30);
            this.btnAjoutPersonnel.TabIndex = 2;
            this.btnAjoutPersonnel.Text = "Ajouter";
            this.btnAjoutPersonnel.UseVisualStyleBackColor = true;
            this.btnAjoutPersonnel.Click += new System.EventHandler(this.btnAjoutPersonnel_Click);
            // 
            // btnAffichAbsences
            // 
            this.btnAffichAbsences.Location = new System.Drawing.Point(354, 207);
            this.btnAffichAbsences.Name = "btnAffichAbsences";
            this.btnAffichAbsences.Size = new System.Drawing.Size(160, 30);
            this.btnAffichAbsences.TabIndex = 1;
            this.btnAffichAbsences.Text = "Afficher les absences";
            this.btnAffichAbsences.UseVisualStyleBackColor = true;
            this.btnAffichAbsences.Click += new System.EventHandler(this.btnAffichAbsences_Click);
            // 
            // dgvPersonnels
            // 
            this.dgvPersonnels.AllowUserToAddRows = false;
            this.dgvPersonnels.AllowUserToDeleteRows = false;
            this.dgvPersonnels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnels.Location = new System.Drawing.Point(14, 31);
            this.dgvPersonnels.Name = "dgvPersonnels";
            this.dgvPersonnels.ReadOnly = true;
            this.dgvPersonnels.RowHeadersWidth = 51;
            this.dgvPersonnels.RowTemplate.Height = 24;
            this.dgvPersonnels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnels.Size = new System.Drawing.Size(500, 166);
            this.dgvPersonnels.TabIndex = 0;
            this.dgvPersonnels.SelectionChanged += new System.EventHandler(this.dgvPersonnels_SelectionChanged);
            // 
            // grbLesAbsences
            // 
            this.grbLesAbsences.Controls.Add(this.btnSupprAbsence);
            this.grbLesAbsences.Controls.Add(this.btnModifAbsence);
            this.grbLesAbsences.Controls.Add(this.btnAjoutAbsence);
            this.grbLesAbsences.Controls.Add(this.dgvAbsences);
            this.grbLesAbsences.Location = new System.Drawing.Point(570, 12);
            this.grbLesAbsences.Name = "grbLesAbsences";
            this.grbLesAbsences.Size = new System.Drawing.Size(530, 250);
            this.grbLesAbsences.TabIndex = 5;
            this.grbLesAbsences.TabStop = false;
            this.grbLesAbsences.Text = "Liste des absences";
            // 
            // btnSupprAbsence
            // 
            this.btnSupprAbsence.Location = new System.Drawing.Point(328, 207);
            this.btnSupprAbsence.Name = "btnSupprAbsence";
            this.btnSupprAbsence.Size = new System.Drawing.Size(90, 30);
            this.btnSupprAbsence.TabIndex = 4;
            this.btnSupprAbsence.Text = "Supprimer";
            this.btnSupprAbsence.UseVisualStyleBackColor = true;
            this.btnSupprAbsence.Click += new System.EventHandler(this.btnSupprAbsence_Click);
            // 
            // btnModifAbsence
            // 
            this.btnModifAbsence.Location = new System.Drawing.Point(232, 207);
            this.btnModifAbsence.Name = "btnModifAbsence";
            this.btnModifAbsence.Size = new System.Drawing.Size(90, 30);
            this.btnModifAbsence.TabIndex = 3;
            this.btnModifAbsence.Text = "Modifier";
            this.btnModifAbsence.UseVisualStyleBackColor = true;
            this.btnModifAbsence.Click += new System.EventHandler(this.btnModifAbsence_Click);
            // 
            // btnAjoutAbsence
            // 
            this.btnAjoutAbsence.Location = new System.Drawing.Point(136, 207);
            this.btnAjoutAbsence.Name = "btnAjoutAbsence";
            this.btnAjoutAbsence.Size = new System.Drawing.Size(90, 30);
            this.btnAjoutAbsence.TabIndex = 2;
            this.btnAjoutAbsence.Text = "Ajouter";
            this.btnAjoutAbsence.UseVisualStyleBackColor = true;
            this.btnAjoutAbsence.Click += new System.EventHandler(this.btnAjoutAbsence_Click);
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.AllowUserToAddRows = false;
            this.dgvAbsences.AllowUserToDeleteRows = false;
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(14, 31);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.ReadOnly = true;
            this.dgvAbsences.RowHeadersWidth = 51;
            this.dgvAbsences.RowTemplate.Height = 24;
            this.dgvAbsences.Size = new System.Drawing.Size(500, 166);
            this.dgvAbsences.TabIndex = 0;
            // 
            // grbLePersonnel
            // 
            this.grbLePersonnel.Controls.Add(this.btnEnregPersonnel);
            this.grbLePersonnel.Controls.Add(this.btnAnnulPersonnel);
            this.grbLePersonnel.Controls.Add(this.lblService);
            this.grbLePersonnel.Controls.Add(this.lblMail);
            this.grbLePersonnel.Controls.Add(this.lblTel);
            this.grbLePersonnel.Controls.Add(this.lblPrenom);
            this.grbLePersonnel.Controls.Add(this.lblNom);
            this.grbLePersonnel.Controls.Add(this.cboService);
            this.grbLePersonnel.Controls.Add(this.txtMail);
            this.grbLePersonnel.Controls.Add(this.txtTel);
            this.grbLePersonnel.Controls.Add(this.txtPrenom);
            this.grbLePersonnel.Controls.Add(this.txtNom);
            this.grbLePersonnel.Location = new System.Drawing.Point(12, 279);
            this.grbLePersonnel.Name = "grbLePersonnel";
            this.grbLePersonnel.Size = new System.Drawing.Size(530, 200);
            this.grbLePersonnel.TabIndex = 6;
            this.grbLePersonnel.TabStop = false;
            this.grbLePersonnel.Text = "Données personnel";
            // 
            // btnEnregPersonnel
            // 
            this.btnEnregPersonnel.Location = new System.Drawing.Point(424, 158);
            this.btnEnregPersonnel.Name = "btnEnregPersonnel";
            this.btnEnregPersonnel.Size = new System.Drawing.Size(90, 30);
            this.btnEnregPersonnel.TabIndex = 11;
            this.btnEnregPersonnel.Text = "Enregistrer";
            this.btnEnregPersonnel.UseVisualStyleBackColor = true;
            this.btnEnregPersonnel.Click += new System.EventHandler(this.btnEnregPersonnel_Click);
            // 
            // btnAnnulPersonnel
            // 
            this.btnAnnulPersonnel.Location = new System.Drawing.Point(328, 158);
            this.btnAnnulPersonnel.Name = "btnAnnulPersonnel";
            this.btnAnnulPersonnel.Size = new System.Drawing.Size(90, 30);
            this.btnAnnulPersonnel.TabIndex = 10;
            this.btnAnnulPersonnel.Text = "Annuler";
            this.btnAnnulPersonnel.UseVisualStyleBackColor = true;
            this.btnAnnulPersonnel.Click += new System.EventHandler(this.btnAnnulPersonnel_Click);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(31, 122);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(55, 17);
            this.lblService.TabIndex = 9;
            this.lblService.Text = "Service";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(287, 81);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(33, 17);
            this.lblMail.TabIndex = 8;
            this.lblMail.Text = "Mail";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(31, 81);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(76, 17);
            this.lblTel.TabIndex = 7;
            this.lblTel.Text = "Téléphone";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(287, 38);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(57, 17);
            this.lblPrenom.TabIndex = 6;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(31, 38);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 17);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Nom";
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(113, 119);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(130, 24);
            this.cboService.TabIndex = 4;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(354, 78);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(130, 22);
            this.txtMail.TabIndex = 3;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(113, 78);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(130, 22);
            this.txtTel.TabIndex = 2;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(354, 35);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(130, 22);
            this.txtPrenom.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(113, 35);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(130, 22);
            this.txtNom.TabIndex = 0;
            // 
            // grbLAbsence
            // 
            this.grbLAbsence.Controls.Add(this.dtpDateFin);
            this.grbLAbsence.Controls.Add(this.dtpDateDebut);
            this.grbLAbsence.Controls.Add(this.btnEnregAbsence);
            this.grbLAbsence.Controls.Add(this.btnAnnulAbsence);
            this.grbLAbsence.Controls.Add(this.lblMotif);
            this.grbLAbsence.Controls.Add(this.lblDateFin);
            this.grbLAbsence.Controls.Add(this.lblDateDebut);
            this.grbLAbsence.Controls.Add(this.cboMotif);
            this.grbLAbsence.Location = new System.Drawing.Point(570, 279);
            this.grbLAbsence.Name = "grbLAbsence";
            this.grbLAbsence.Size = new System.Drawing.Size(530, 200);
            this.grbLAbsence.TabIndex = 12;
            this.grbLAbsence.TabStop = false;
            this.grbLAbsence.Text = "Données absence";
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(203, 73);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(233, 22);
            this.dtpDateFin.TabIndex = 13;
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Location = new System.Drawing.Point(203, 33);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(233, 22);
            this.dtpDateDebut.TabIndex = 12;
            // 
            // btnEnregAbsence
            // 
            this.btnEnregAbsence.Location = new System.Drawing.Point(424, 158);
            this.btnEnregAbsence.Name = "btnEnregAbsence";
            this.btnEnregAbsence.Size = new System.Drawing.Size(90, 30);
            this.btnEnregAbsence.TabIndex = 11;
            this.btnEnregAbsence.Text = "Enregistrer";
            this.btnEnregAbsence.UseVisualStyleBackColor = true;
            this.btnEnregAbsence.Click += new System.EventHandler(this.btnEnregAbsence_Click);
            // 
            // btnAnnulAbsence
            // 
            this.btnAnnulAbsence.Location = new System.Drawing.Point(328, 158);
            this.btnAnnulAbsence.Name = "btnAnnulAbsence";
            this.btnAnnulAbsence.Size = new System.Drawing.Size(90, 30);
            this.btnAnnulAbsence.TabIndex = 10;
            this.btnAnnulAbsence.Text = "Annuler";
            this.btnAnnulAbsence.UseVisualStyleBackColor = true;
            this.btnAnnulAbsence.Click += new System.EventHandler(this.btnAnnulAbsence_Click);
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(97, 120);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(38, 17);
            this.lblMotif.TabIndex = 9;
            this.lblMotif.Text = "Motif";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(97, 79);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(77, 17);
            this.lblDateFin.TabIndex = 7;
            this.lblDateFin.Text = "Date de fin";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(97, 36);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(98, 17);
            this.lblDateDebut.TabIndex = 5;
            this.lblDateDebut.Text = "Date de début";
            // 
            // cboMotif
            // 
            this.cboMotif.FormattingEnabled = true;
            this.cboMotif.Location = new System.Drawing.Point(203, 117);
            this.cboMotif.Name = "cboMotif";
            this.cboMotif.Size = new System.Drawing.Size(233, 24);
            this.cboMotif.TabIndex = 4;
            // 
            // FrmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 493);
            this.Controls.Add(this.grbLAbsence);
            this.Controls.Add(this.grbLePersonnel);
            this.Controls.Add(this.grbLesAbsences);
            this.Controls.Add(this.grbLesPersonnels);
            this.Name = "FrmGestion";
            this.Text = "Personnel MediaTek86";
            this.grbLesPersonnels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).EndInit();
            this.grbLesAbsences.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.grbLePersonnel.ResumeLayout(false);
            this.grbLePersonnel.PerformLayout();
            this.grbLAbsence.ResumeLayout(false);
            this.grbLAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLesPersonnels;
        private System.Windows.Forms.DataGridView dgvPersonnels;
        private System.Windows.Forms.Button btnSupprPersonnel;
        private System.Windows.Forms.Button btnModifPersonnel;
        private System.Windows.Forms.Button btnAjoutPersonnel;
        private System.Windows.Forms.Button btnAffichAbsences;
        private System.Windows.Forms.GroupBox grbLesAbsences;
        private System.Windows.Forms.Button btnSupprAbsence;
        private System.Windows.Forms.Button btnModifAbsence;
        private System.Windows.Forms.Button btnAjoutAbsence;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.GroupBox grbLePersonnel;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnEnregPersonnel;
        private System.Windows.Forms.Button btnAnnulPersonnel;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.GroupBox grbLAbsence;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Button btnEnregAbsence;
        private System.Windows.Forms.Button btnAnnulAbsence;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.ComboBox cboMotif;
    }
}

