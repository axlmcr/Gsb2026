using Metier;
using System.Data;

namespace Interface
{
    public partial class FrmVisiteConsultation : FrmBase
    {
        public FrmVisiteConsultation(Session uneSession) : base(uneSession)
        {
            InitializeComponent();

        }

        private void FrmVisiteConsultation_Load(object sender, EventArgs e)
        {
            parametrerComposant();
            remplirDgv();

            // On s'abonne à l'événement de changement de sélection
            // dgvVisites.SelectionChanged += DgvVisites_SelectionChanged;
            // this.Resize += FrmVisiteConsultation_Resize;

            centrerFormulaire();

            // Afficher la première ligne si existante
            if (dgvVisites.Rows.Count > 0)
                afficherVisite((Visite)dgvVisites.Rows[0].Cells[0].Value);
        }


        /**
         * Lors du redimensionnement de la fenêtre, on recentre le panel central
         */
        private void FrmVisiteConsultation_Resize(object? sender, EventArgs e)
        {
            centrerFormulaire();
        }

        private void dgvVisites_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVisites.SelectedRows.Count > 0)
            {
                Visite visiteSelectionnee = (Visite)dgvVisites.SelectedRows[0].Cells[0].Value;
                afficherVisite(visiteSelectionnee);
            }
        }



        private void centrerFormulaire()
        {
            panelCentral.Left = (this.ClientSize.Width - panelCentral.Width) / 2;
        }

        private void afficherVisite(Visite v)
        {
            // Praticien
            lblPraticien.Text = v.LePraticien.NomPrenom;
            lblRue.Text = v.LePraticien.Rue;
            lblTelephone.Text = v.LePraticien.Telephone;
            lblEmail.Text = v.LePraticien.Email;
            lblType.Text = v.LePraticien.Type?.Libelle ?? "Aucun";
            lblSpecialite.Text = v.LePraticien.Specialite?.Libelle ?? "Aucune";

            // Motif et Bilan
            lblMotif.Text = v.LeMotif.Libelle;
            lblBilan.Text = v.Bilan;

            // Médicaments (Listbox)
            lstMedicament.Items.Clear();
            if (v.PremierMedicament != null) lstMedicament.Items.Add(v.PremierMedicament.Nom);
            if (v.SecondMedicament != null) lstMedicament.Items.Add(v.SecondMedicament.Nom);

            // Echantillons (DataGrid)
            dgvEchantillon.Rows.Clear();
            foreach (var echantillon in v)
            {
                dgvEchantillon.Rows.Add(echantillon.Key.Nom, echantillon.Value);
            }
        }

        private void parametrerComposant()
        {
            this.lblTitre.Text = "Consulter les visites";
            parametrerDgv(dgvVisites);
            parametrerDgvEchantillons();
        }

        private void parametrerDgvEchantillons()
        {
            dgvEchantillon.Columns.Clear();
            dgvEchantillon.Rows.Clear();

            dgvEchantillon.Enabled = true;
            dgvEchantillon.BorderStyle = BorderStyle.FixedSingle;
            dgvEchantillon.BackgroundColor = Color.White;
            dgvEchantillon.ForeColor = Color.Black;
            dgvEchantillon.DefaultCellStyle.Font = new Font("Georgia", 10);
            dgvEchantillon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEchantillon.MultiSelect = false;
            dgvEchantillon.AllowUserToAddRows = false;
            dgvEchantillon.AllowUserToDeleteRows = false;
            dgvEchantillon.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvEchantillon.AllowUserToResizeColumns = false;
            dgvEchantillon.AllowUserToResizeRows = false;
            dgvEchantillon.AllowUserToOrderColumns = false;

            dgvEchantillon.ColumnHeadersVisible = true;
            dgvEchantillon.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEchantillon.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle style = dgvEchantillon.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.LightGray;
            style.ForeColor = Color.Black;
            style.SelectionBackColor = Color.LightGray;
            style.SelectionForeColor = Color.Black;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.Font = new Font("Georgia", 9, FontStyle.Bold);
            dgvEchantillon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvEchantillon.ColumnHeadersHeight = 35;
            dgvEchantillon.RowHeadersVisible = false;
            dgvEchantillon.RowTemplate.Height = 25;
            dgvEchantillon.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvEchantillon.GridColor = Color.LightGray;
            dgvEchantillon.RowsDefaultCellStyle.BackColor = Color.White;


            dgvEchantillon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewColumn col;

            // Colonne Echantillon
            col = new DataGridViewTextBoxColumn();
            col.Name = "Nom";
            col.HeaderText = "Médicament";
            col.FillWeight = 70;
            dgvEchantillon.Columns.Add(col);

            // Colonne Quantite
            col = new DataGridViewTextBoxColumn();
            col.Name = "Qte";
            col.HeaderText = "Quantité";
            col.FillWeight = 30;
            dgvEchantillon.Columns.Add(col);
        }

        private void parametrerDgv(DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            #region paramètrage concernant le datagridview dans son ensemble

            dgv.Enabled = true;
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.BackgroundColor = Color.White;
            dgv.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Georgia", 11);
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowDrop = false;

            #endregion

            #region paramètrage concernant la ligne d'entête

            dgv.ColumnHeadersVisible = true;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle style = dgv.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.WhiteSmoke;
            style.ForeColor = Color.Black;
            style.SelectionBackColor = Color.WhiteSmoke;
            style.SelectionForeColor = Color.Black;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.Font = new Font("Georgia", 12, FontStyle.Bold);
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersHeight = 40;

            #endregion

            #region paramètrage concernant l'entête de ligne

            dgv.RowHeadersVisible = false;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            #endregion

            #region paramètrage au niveau des lignes

            dgv.RowTemplate.Height = 30;

            #endregion

            #region paramètrage au niveau des cellules

            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.RowsDefaultCellStyle.BackColor = Color.White;

            #endregion

            #region paramètrage au niveau de la zone sélectionnée

            dgv.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dgv.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            #endregion

            #region paramètrage des colonnes

            DataGridViewColumn col;

            // Colonne 0 : objet Visite (cachée)
            col = new DataGridViewTextBoxColumn();
            col.Name = "Visite";
            col.HeaderText = "";
            col.Width = 0;
            col.Visible = false;
            dgv.Columns.Add(col);

            // Colonne 1 : La date de la visite
            col = new DataGridViewTextBoxColumn();
            col.Name = "Date";
            col.HeaderText = "Programmée le";
            col.Width = 200;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns.Add(col);

            // Colonne 2 : heure du rendez-vous
            col = new DataGridViewTextBoxColumn();
            col.Name = "Heure";
            col.HeaderText = "à";
            col.Width = 50;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns.Add(col);

            // Colonne 3 : lieu du rendez-vous
            col = new DataGridViewTextBoxColumn();
            col.Name = "Lieu";
            col.HeaderText = "sur";
            col.Width = 200;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns.Add(col);

            for (int i = 0; i < dgv.ColumnCount; i++)
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;

           

            #endregion
        }


        private int getLargeur(DataGridView dgv)
        {
            int largeur = 0;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Visible)
                {
                    largeur += col.Width;
                }
            }

            if (dgv.RowHeadersVisible)
            {
                largeur += dgv.RowHeadersWidth;
            }

            // Ajout scrollbar verticale si présente
            if (dgv.Controls.OfType<VScrollBar>().FirstOrDefault()?.Visible == true)
            {
                largeur += SystemInformation.VerticalScrollBarWidth;
            }

            return largeur + 2; // marge bordure
        }

        private int getLargeur2(DataGridView dgv)
        {
            int largeur = dgv.Columns
                .Cast<DataGridViewColumn>()
                .Where(c => c.Visible)
                .Sum(c => c.Width);

            if (dgv.RowHeadersVisible)
            {
                largeur += dgv.RowHeadersWidth;
            }

            // Détection fiable
            bool besoinScroll = dgv.DisplayedRowCount(false) < dgv.RowCount;

            if (besoinScroll)
            {
                largeur += SystemInformation.VerticalScrollBarWidth;
            }

            return largeur + 2;
        }


        private void remplirDgv()
        {
            dgvVisites.Rows.Clear();

            foreach (Visite v in session.MesVisites.OrderBy(v => v.DateEtHeure))
            {
                int rowIndex = dgvVisites.Rows.Add(
                    v,
                    v.DateEtHeure.ToLongDateString(),
                    v.DateEtHeure.ToShortTimeString(),
                    v.LePraticien.Ville);

                if (v.Bilan != null)
                {
                    dgvVisites.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Green;
                }
            }

            dgvVisites.Width = getLargeur(dgvVisites);
        }


    }
}
