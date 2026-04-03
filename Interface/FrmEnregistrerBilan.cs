using Donnee;
using Metier;
using System.Data;

namespace Interface
{
    public partial class FrmEnregistrerBilan : FrmBase
    {
        private List<Visite> lesVisitesNonCompletees = new();
        private int indexVisiteCourante = 0;

        public FrmEnregistrerBilan(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
            centrerFormulaire();
        }

        # region procédures événementielles

        private void FrmEnregistrerBilan_Load(object sender, EventArgs e)
        {
            parametrerComposant();
            chargerLesVisites();
        }

        private void FrmEnregistrerBilan_Resize(object sender, EventArgs e)
        {
            centrerFormulaire();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            changerVisite(-1);
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            changerVisite(1);
        }

        #endregion

        #region procédures

        private void parametrerComposant()
        {
            this.lblTitre.Text = "Enregistrement du bilan d'une visite";

            msgPremierMedicament.ForeColor = Color.Red;
            msgPremierMedicament.Visible = false;
            msgPremierMedicament.AutoSize = true;
            msgPremierMedicament.Location = new Point(cbxPremierMedicament.Left, cbxPremierMedicament.Bottom + 2);
            panelGauche.Controls.Add(msgPremierMedicament);

            msgSecondMedicament.ForeColor = Color.Red;
            msgSecondMedicament.Visible = false;
            msgSecondMedicament.AutoSize = true;
            msgSecondMedicament.Location = new Point(cbxSecondMedicament.Left, cbxSecondMedicament.Bottom + 2);
            panelGauche.Controls.Add(msgSecondMedicament);

            msgBilan.ForeColor = Color.Red;
            msgBilan.Visible = false;
            msgBilan.AutoSize = true;
            msgBilan.Location = new Point(txtBilan.Left, txtBilan.Bottom + 2);
            panelGauche.Controls.Add(msgBilan);

            btnPrecedent.Text = "Précédent";
            btnPrecedent.AutoSize = true;
            btnPrecedent.Location = new Point(10, 20);
            btnPrecedent.Click += btnPrecedent_Click;
            panelHaut.Controls.Add(btnPrecedent);

            btnSuivant.Text = "Suivant";
            btnSuivant.AutoSize = true;
            btnSuivant.Location = new Point(btnPrecedent.Right + 10, 20);
            btnSuivant.Click += btnSuivant_Click;
            panelHaut.Controls.Add(btnSuivant);

            message.AutoSize = true;
            message.Location = new Point(btnSuivant.Right + 20, 25);
            panelHaut.Controls.Add(message);

            dgvEchantillon.Columns.Add("Objet", "Objet");
            dgvEchantillon.Columns[0].Visible = false;
            dgvEchantillon.Columns.Add("Medicament", "Médicament");
            dgvEchantillon.Columns.Add("Quantite", "Quantité");
            
            DataGridViewImageColumn btnSupprimer = new DataGridViewImageColumn();
            btnSupprimer.Name = "Supprimer";
            btnSupprimer.HeaderText = "";
            // Use an icon or leave empty. As instructed "Colonne 3 à 5 : de type Image" 
            dgvEchantillon.Columns.Add(btnSupprimer);
            dgvEchantillon.CellClick += dgvEchantillon_CellClick;
            
            cbxPremierMedicament.DataSource = new List<Medicament>(session!.LesMedicaments);
            cbxPremierMedicament.SelectedIndex = -1;
            
            cbxSecondMedicament.DataSource = new List<Medicament>(session.LesMedicaments);
            cbxSecondMedicament.SelectedIndex = -1;

            cbxPremierMedicament.DisplayMember = "Nom";
            cbxSecondMedicament.DisplayMember = "Nom";

            cbxEchantillon.DataSource = new List<Medicament>(session.LesMedicaments);
            cbxEchantillon.DisplayMember = "Nom";
            cbxEchantillon.SelectedIndex = -1;

            btnAjouter.Click += btnAjouter_Click;
            btnEnregistrer.Click += btnEnregistrer_Click;
        }

        private void centrerFormulaire()
        {
            panelCentral.Left = (this.ClientSize.Width - panelCentral.Width) / 2;
            panelCentral.Top = (this.ClientSize.Height - panelCentral.Height) / 2;
        }

        private void chargerLesVisites()
        {
            lesVisitesNonCompletees = session!.MesVisites
                .FindAll(x => x.DateEtHeure <= DateTime.Now && x.Bilan == null);
            if (lesVisitesNonCompletees.Count == 0)
            {
                // message.Text = "Toutes vos fiches sont complétées";
                 panelCentral.Visible = false;
                 return;
            }
            panelCentral.Visible = true;
            indexVisiteCourante = 0;
            afficherVisite();
            mettreAJourNavigation();
        }

        private void changerVisite(int deplacement)
        {
            int count = lesVisitesNonCompletees.Count;
            if (count == 0)
            {
                return;
            }
            indexVisiteCourante = (indexVisiteCourante + deplacement + count) % count;
            afficherVisite();
            mettreAJourNavigation();
        }

        private void mettreAJourNavigation()
        {
            int count = lesVisitesNonCompletees.Count;
            btnSuivant.Enabled = count > 1;
            btnPrecedent.Enabled = count > 1;
            message.Visible = count > 0;
            if (count > 0)
            {
                message.Text = $"{indexVisiteCourante + 1} / {count}";
            }
            else
            {
                message.Text = "Toutes vos fiches sont complétées";
            }
        }

        private void afficherVisite()
        {
            msgPremierMedicament.Visible = false;
            msgSecondMedicament.Visible = false;
            msgBilan.Visible = false;

            if (lesVisitesNonCompletees.Count > 0)
            {
                Visite visite = lesVisitesNonCompletees[indexVisiteCourante];
                txtBilan.Text = string.Empty;
                cbxPremierMedicament.SelectedIndex = -1;
                cbxSecondMedicament.SelectedIndex = -1;
                cbxEchantillon.SelectedIndex = -1;
                cptQuantite.Value = 1;

                rafraichirEchantillons(visite);
            }
        }

        private void rafraichirEchantillons(Visite visite)
        {
            dgvEchantillon.Rows.Clear();
            foreach (var kvp in visite)
            {
                dgvEchantillon.Rows.Add(kvp.Key, kvp.Key.Nom, kvp.Value);
            }
        }

        private void btnAjouter_Click(object? sender, EventArgs e)
        {
            if (lesVisitesNonCompletees.Count > 0 && cbxEchantillon.SelectedItem != null)
            {
                Medicament medicament = (Medicament)cbxEchantillon.SelectedItem;
                int quantite = (int)cptQuantite.Value;
                Visite visite = lesVisitesNonCompletees[indexVisiteCourante];
                visite.ajouterEchantillon(medicament, quantite);
                rafraichirEchantillons(visite);
            }
        }

        private void dgvEchantillon_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3 && lesVisitesNonCompletees.Count > 0)
            {
                Medicament medicament = (Medicament)dgvEchantillon.Rows[e.RowIndex].Cells[0].Value;
                Visite visite = lesVisitesNonCompletees[indexVisiteCourante];
                visite.supprimerEchantillon(medicament);
                rafraichirEchantillons(visite);
            }
        }

        private void btnEnregistrer_Click(object? sender, EventArgs e)
        {
            enregistrer();
        }

        private bool controlerPremierMedicament()
        {
            if (cbxPremierMedicament.SelectedIndex == -1)
            {
                msgPremierMedicament.Text = "Le premier médicament est obligatoire.";
                msgPremierMedicament.Visible = true;
                return false;
            }
            msgPremierMedicament.Visible = false;
            return true;
        }

        private bool controlerSecondMedicament()
        {
            if (cbxSecondMedicament.SelectedIndex != -1 && cbxPremierMedicament.SelectedItem == cbxSecondMedicament.SelectedItem)
            {
                msgSecondMedicament.Text = "Le second médicament doit être différent du premier.";
                msgSecondMedicament.Visible = true;
                return false;
            }
            msgSecondMedicament.Visible = false;
            return true;
        }

        private bool controlerBilan()
        {
            if (string.IsNullOrWhiteSpace(txtBilan.Text))
            {
                msgBilan.Text = "Le bilan est obligatoire.";
                msgBilan.Visible = true;
                return false;
            }
            msgBilan.Visible = false;
            return true;
        }

        private void enregistrer()
        {
            bool premierMedicamentOk = controlerPremierMedicament();
            bool secondMedicamentOk = controlerSecondMedicament();
            bool bilanOk = controlerBilan();
            if (premierMedicamentOk && secondMedicamentOk && bilanOk)
            {
                Medicament premierMedicament = (Medicament)cbxPremierMedicament.SelectedItem!;
                Medicament? secondMedicament = (cbxSecondMedicament.SelectedIndex >= 0) ?
                    (Medicament)cbxSecondMedicament.SelectedItem! : null;
                Visite visite = lesVisitesNonCompletees[indexVisiteCourante];
                try
                {
                    visite.enregistrerBilan(txtBilan.Text, premierMedicament, secondMedicament);
                    Passerelle.enregistrerBilan(visite);
                    MessageBox.Show("Votre fiche visite est maintenant archivée", "Bilan enregistré",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lesVisitesNonCompletees.RemoveAt(indexVisiteCourante);
                    if (lesVisitesNonCompletees.Count > 0)
                    {
                        changerVisite(0);
                    }
                    else
                    {
                        message.Text = "Toutes vos fiches sont complétées";
                        panelCentral.Visible = false;
                        mettreAJourNavigation();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de l'enregistrement du bilan : " + ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
    }
}
