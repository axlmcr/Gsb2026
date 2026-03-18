namespace Interface
{
    partial class FrmBase
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
            this.lblTitre = new Label();
            this.menuStrip1 = new MenuStrip();
            this.fichierToolStripMenuItem = new ToolStripMenuItem();
            this.programmerRendezVous = new ToolStripMenuItem();
            this.modifierRendezVous = new ToolStripMenuItem();
            this.imprimerRendezvous = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.enregistrerBilan = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.consulterVisite = new ToolStripMenuItem();
            this.medicamentToolStripMenuItem = new ToolStripMenuItem();
            this.ficheMédicament = new ToolStripMenuItem();
            this.visiteurToolStripMenuItem = new ToolStripMenuItem();
            this.listePraticien = new ToolStripMenuItem();
            this.nouveauPraticien = new ToolStripMenuItem();
            this.modifierPraticien = new ToolStripMenuItem();
            this.panel1 = new Panel();
            this.lblVisiteur = new Label();
            this.labelGsb = new Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Dock = DockStyle.Top;
            this.lblTitre.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblTitre.Location = new Point(0, 28);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new Size(715, 99);
            this.lblTitre.TabIndex = 9;
            this.lblTitre.Text = "Titre";
            this.lblTitre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new Size(20, 20);
            this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.fichierToolStripMenuItem, this.medicamentToolStripMenuItem, this.visiteurToolStripMenuItem });
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new Size(715, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.programmerRendezVous, this.modifierRendezVous, this.imprimerRendezvous, this.toolStripSeparator1, this.enregistrerBilan, this.toolStripSeparator2, this.consulterVisite });
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new Size(59, 24);
            this.fichierToolStripMenuItem.Text = "Visite";
            // 
            // programmerRendezVous
            // 
            this.programmerRendezVous.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.programmerRendezVous.Name = "programmerRendezVous";
            this.programmerRendezVous.ShortcutKeys = Keys.Alt | Keys.R;
            this.programmerRendezVous.ShowShortcutKeys = false;
            this.programmerRendezVous.Size = new Size(322, 26);
            this.programmerRendezVous.Text = "Nouveau &Rendez-vous";
            this.programmerRendezVous.Click += this.programmerRendezVous_Click;
            // 
            // modifierRendezVous
            // 
            this.modifierRendezVous.AccessibleRole = AccessibleRole.TitleBar;
            this.modifierRendezVous.Name = "modifierRendezVous";
            this.modifierRendezVous.ShortcutKeys = Keys.Alt | Keys.D;
            this.modifierRendezVous.ShowShortcutKeys = false;
            this.modifierRendezVous.Size = new Size(322, 26);
            this.modifierRendezVous.Text = "&Déplacer ou annuler un rendez-vous";
            this.modifierRendezVous.Click += this.modifierRendezVous_Click;
            // 
            // imprimerRendezvous
            // 
            this.imprimerRendezvous.Name = "imprimerRendezvous";
            this.imprimerRendezvous.ShortcutKeys = Keys.Alt | Keys.I;
            this.imprimerRendezvous.ShowShortcutKeys = false;
            this.imprimerRendezvous.Size = new Size(322, 26);
            this.imprimerRendezvous.Text = "&Imprimer les rendez-vous";
            this.imprimerRendezvous.Click += this.imprimerRendezvous_Click;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(319, 6);
            // 
            // enregistrerBilan
            // 
            this.enregistrerBilan.Name = "enregistrerBilan";
            this.enregistrerBilan.ShortcutKeys = Keys.Alt | Keys.B;
            this.enregistrerBilan.ShowShortcutKeys = false;
            this.enregistrerBilan.Size = new Size(322, 26);
            this.enregistrerBilan.Text = "&Enregistrer un bilan";
            this.enregistrerBilan.Click += this.enregistrerBilan_Click;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(319, 6);
            // 
            // consulterVisite
            // 
            this.consulterVisite.Name = "consulterVisite";
            this.consulterVisite.ShortcutKeys = Keys.Alt | Keys.V;
            this.consulterVisite.ShowShortcutKeys = false;
            this.consulterVisite.Size = new Size(322, 26);
            this.consulterVisite.Text = "&Liste des Visites";
            this.consulterVisite.Click += this.consulterVisite_Click;
            // 
            // medicamentToolStripMenuItem
            // 
            this.medicamentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.ficheMédicament });
            this.medicamentToolStripMenuItem.Name = "medicamentToolStripMenuItem";
            this.medicamentToolStripMenuItem.Size = new Size(106, 24);
            this.medicamentToolStripMenuItem.Text = "Médicament";
            // 
            // ficheMédicament
            // 
            this.ficheMédicament.Name = "ficheMédicament";
            this.ficheMédicament.ShortcutKeys = Keys.Alt | Keys.M;
            this.ficheMédicament.ShowShortcutKeys = false;
            this.ficheMédicament.Size = new Size(204, 26);
            this.ficheMédicament.Text = "&Fiche médicament";
            this.ficheMédicament.Click += this.ficheMédicamentToolStripMenuItem_Click;
            // 
            // visiteurToolStripMenuItem
            // 
            this.visiteurToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.listePraticien, this.nouveauPraticien, this.modifierPraticien });
            this.visiteurToolStripMenuItem.Name = "visiteurToolStripMenuItem";
            this.visiteurToolStripMenuItem.Size = new Size(80, 24);
            this.visiteurToolStripMenuItem.Text = "Praticien";
            // 
            // listePraticien
            // 
            this.listePraticien.Name = "listePraticien";
            this.listePraticien.ShortcutKeys = Keys.Alt | Keys.P;
            this.listePraticien.ShowShortcutKeys = false;
            this.listePraticien.Size = new Size(169, 26);
            this.listePraticien.Text = "&Liste";
            this.listePraticien.Click += this.listePraticien_Click;
            // 
            // nouveauPraticien
            // 
            this.nouveauPraticien.Name = "nouveauPraticien";
            this.nouveauPraticien.ShortcutKeys = Keys.Alt | Keys.A;
            this.nouveauPraticien.ShowShortcutKeys = false;
            this.nouveauPraticien.Size = new Size(169, 26);
            this.nouveauPraticien.Text = "&Ajouter";
            this.nouveauPraticien.Click += this.nouveauPraticien_Click;
            // 
            // modifierPraticien
            // 
            this.modifierPraticien.Name = "modifierPraticien";
            this.modifierPraticien.ShortcutKeys = Keys.Alt | Keys.U;
            this.modifierPraticien.ShowShortcutKeys = false;
            this.modifierPraticien.Size = new Size(169, 26);
            this.modifierPraticien.Text = "&Mettre à jour";
            this.modifierPraticien.Click += this.modifierPraticien_Click;
            // 
            // panel1
            // 
            this.panel1.BackColor = SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblVisiteur);
            this.panel1.Controls.Add(this.labelGsb);
            this.panel1.Dock = DockStyle.Bottom;
            this.panel1.Location = new Point(0, 418);
            this.panel1.Margin = new Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(715, 60);
            this.panel1.TabIndex = 12;
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.BackColor = Color.Transparent;
            this.lblVisiteur.Dock = DockStyle.Left;
            this.lblVisiteur.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblVisiteur.Location = new Point(420, 0);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new Size(292, 60);
            this.lblVisiteur.TabIndex = 12;
            this.lblVisiteur.Text = "Visiteur";
            this.lblVisiteur.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelGsb
            // 
            this.labelGsb.BackColor = Color.Transparent;
            this.labelGsb.Dock = DockStyle.Left;
            this.labelGsb.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.labelGsb.Location = new Point(0, 0);
            this.labelGsb.Name = "labelGsb";
            this.labelGsb.Size = new Size(420, 60);
            this.labelGsb.TabIndex = 9;
            this.labelGsb.Text = "GSB - Galaxy Swiss Bourdin - Visiteur connecté :";
            this.labelGsb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.ButtonHighlight;
            this.ClientSize = new Size(715, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new Padding(3, 2, 3, 2);
            this.Name = "FrmBase";
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.WindowState = FormWindowState.Maximized;
            FormClosed += this.FrmBase_FormClosed;
            Load += this.FrmBase_Load;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterVisite;
        private System.Windows.Forms.ToolStripMenuItem programmerRendezVous;
        protected System.Windows.Forms.ToolStripMenuItem modifierRendezVous;
        private System.Windows.Forms.ToolStripMenuItem enregistrerBilan;
        private System.Windows.Forms.ToolStripMenuItem imprimerRendezvous;
        private System.Windows.Forms.ToolStripMenuItem medicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheMédicament;
        private System.Windows.Forms.ToolStripMenuItem visiteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauPraticien;
        private System.Windows.Forms.ToolStripMenuItem modifierPraticien;
        private System.Windows.Forms.ToolStripMenuItem listePraticien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.Label labelGsb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}