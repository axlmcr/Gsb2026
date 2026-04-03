namespace Interface
{
    partial class FrmVisiteConsultation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteConsultation));
            panelCentral = new Panel();
            labelBilan = new Label();
            labelMotif = new Label();
            lblMedicament = new Label();
            lblTitrePraticien = new Label();
            dgvEchantillon = new DataGridView();
            lstMedicament = new ListBox();
            lblBilan = new Label();
            lblMotif = new Label();
            panelPraticien = new Panel();
            lblSpecialite = new Label();
            lblType = new Label();
            lblEmail = new Label();
            lblTelephone = new Label();
            lblRue = new Label();
            lblPraticien = new Label();
            dgvVisites = new DataGridView();
            panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEchantillon).BeginInit();
            panelPraticien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisites).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(1156, 74);
            // 
            // panelCentral
            // 
            panelCentral.Controls.Add(labelBilan);
            panelCentral.Controls.Add(labelMotif);
            panelCentral.Controls.Add(lblMedicament);
            panelCentral.Controls.Add(lblTitrePraticien);
            panelCentral.Controls.Add(dgvEchantillon);
            panelCentral.Controls.Add(lstMedicament);
            panelCentral.Controls.Add(lblBilan);
            panelCentral.Controls.Add(lblMotif);
            panelCentral.Controls.Add(panelPraticien);
            panelCentral.Controls.Add(dgvVisites);
            panelCentral.Location = new Point(0, 76);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1114, 510);
            panelCentral.TabIndex = 13;
            // 
            // labelBilan
            // 
            labelBilan.AutoSize = true;
            labelBilan.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBilan.Location = new Point(494, 240);
            labelBilan.Name = "labelBilan";
            labelBilan.Size = new Size(48, 18);
            labelBilan.TabIndex = 9;
            labelBilan.Text = "Bilan";
            // 
            // labelMotif
            // 
            labelMotif.AutoSize = true;
            labelMotif.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMotif.Location = new Point(493, 184);
            labelMotif.Name = "labelMotif";
            labelMotif.Size = new Size(49, 18);
            labelMotif.TabIndex = 8;
            labelMotif.Text = "Motif";
            // 
            // lblMedicament
            // 
            lblMedicament.AutoSize = true;
            lblMedicament.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMedicament.Location = new Point(504, 403);
            lblMedicament.Name = "lblMedicament";
            lblMedicament.Size = new Size(186, 18);
            lblMedicament.TabIndex = 7;
            lblMedicament.Text = "Médicaments Présentés";
            // 
            // lblTitrePraticien
            // 
            lblTitrePraticien.AutoSize = true;
            lblTitrePraticien.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitrePraticien.Location = new Point(504, 12);
            lblTitrePraticien.Name = "lblTitrePraticien";
            lblTitrePraticien.Size = new Size(78, 18);
            lblTitrePraticien.TabIndex = 6;
            lblTitrePraticien.Text = "Praticien";
            // 
            // dgvEchantillon
            // 
            dgvEchantillon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEchantillon.Location = new Point(788, 208);
            dgvEchantillon.Name = "dgvEchantillon";
            dgvEchantillon.Size = new Size(277, 280);
            dgvEchantillon.TabIndex = 5;
            // 
            // lstMedicament
            // 
            lstMedicament.FormattingEnabled = true;
            lstMedicament.Location = new Point(516, 439);
            lstMedicament.Name = "lstMedicament";
            lstMedicament.Size = new Size(190, 49);
            lstMedicament.TabIndex = 4;
            // 
            // lblBilan
            // 
            lblBilan.BorderStyle = BorderStyle.FixedSingle;
            lblBilan.Location = new Point(504, 269);
            lblBilan.Name = "lblBilan";
            lblBilan.Size = new Size(254, 108);
            lblBilan.TabIndex = 3;
            // 
            // lblMotif
            // 
            lblMotif.Location = new Point(564, 184);
            lblMotif.Name = "lblMotif";
            lblMotif.Size = new Size(194, 18);
            lblMotif.TabIndex = 2;
            lblMotif.Text = "Motif";
            // 
            // panelPraticien
            // 
            panelPraticien.BorderStyle = BorderStyle.FixedSingle;
            panelPraticien.Controls.Add(lblSpecialite);
            panelPraticien.Controls.Add(lblType);
            panelPraticien.Controls.Add(lblEmail);
            panelPraticien.Controls.Add(lblTelephone);
            panelPraticien.Controls.Add(lblRue);
            panelPraticien.Controls.Add(lblPraticien);
            panelPraticien.Location = new Point(493, 35);
            panelPraticien.Name = "panelPraticien";
            panelPraticien.Size = new Size(588, 123);
            panelPraticien.TabIndex = 1;
            // 
            // lblSpecialite
            // 
            lblSpecialite.Location = new Point(364, 40);
            lblSpecialite.Name = "lblSpecialite";
            lblSpecialite.Size = new Size(190, 20);
            lblSpecialite.TabIndex = 5;
            // 
            // lblType
            // 
            lblType.Location = new Point(364, 10);
            lblType.Name = "lblType";
            lblType.Size = new Size(180, 20);
            lblType.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(10, 85);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(380, 20);
            lblEmail.TabIndex = 3;
            // 
            // lblTelephone
            // 
            lblTelephone.Location = new Point(10, 60);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(370, 20);
            lblTelephone.TabIndex = 2;
            // 
            // lblRue
            // 
            lblRue.Location = new Point(10, 35);
            lblRue.Name = "lblRue";
            lblRue.Size = new Size(348, 20);
            lblRue.TabIndex = 1;
            // 
            // lblPraticien
            // 
            lblPraticien.Location = new Point(10, 10);
            lblPraticien.Name = "lblPraticien";
            lblPraticien.Size = new Size(348, 20);
            lblPraticien.TabIndex = 0;
            lblPraticien.Text = "Nom";
            // 
            // dgvVisites
            // 
            dgvVisites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisites.Location = new Point(12, 12);
            dgvVisites.Name = "dgvVisites";
            dgvVisites.Size = new Size(475, 476);
            dgvVisites.TabIndex = 0;
            dgvVisites.SelectionChanged += dgvVisites_SelectionChanged;
            // 
            // FrmVisiteConsultation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 634);
            Controls.Add(panelCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmVisiteConsultation";
            Text = "FrmVisiteConsultation";
            Load += FrmVisiteConsultation_Load;
            Resize += FrmVisiteConsultation_Resize;
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panelCentral, 0);
            panelCentral.ResumeLayout(false);
            panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEchantillon).EndInit();
            panelPraticien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVisites).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCentral;
        private DataGridView dgvVisites;
        private Panel panelPraticien;
        private Label lblPraticien;
        private Label lblRue;
        private Label lblTelephone;
        private Label lblEmail;
        private Label lblType;
        private Label lblSpecialite;
        private Label lblMotif;
        private Label lblBilan;
        private DataGridView dgvEchantillon;
        private ListBox lstMedicament;
        private Label lblTitrePraticien;
        private Label lblMedicament;
        private Label labelBilan;
        private Label labelMotif;
    }
}