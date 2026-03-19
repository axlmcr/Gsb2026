using Donnee;
using Metier;
using System.Data;

namespace Interface
{
    public partial class FrmEnregistrerBilan : FrmBase
    {
        public FrmEnregistrerBilan(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
            centrerFormulaire();
        }

        # region procédures événementielles

        private void FrmEnregistrerBilan_Load(object sender, EventArgs e)
        {
            parametrerComposant();
        }

        private void FrmEnregistrerBilan_Resize(object sender, EventArgs e)
        {
            centrerFormulaire();
        }

        #endregion

        #region procédures

        private void parametrerComposant()
        {
            this.lblTitre.Text = "Enregistrement du bilan d'une visite";

        }

        private void centrerFormulaire()
        {
            panel.Left = (this.ClientSize.Width - panel.Width) / 2;
            panel.Top = (this.ClientSize.Height - panel.Height) / 2;
        }

        #endregion
    }
}
