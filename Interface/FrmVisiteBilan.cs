using Donnee;
using Interface.Properties;
using Metier;
using System.Data;

namespace Interface
{
    public partial class FrmVisiteBilan : FrmBase
    {
        public FrmVisiteBilan(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
        }



        #region procédures événementielles

        private void FrmVisiteBilan_Load(object sender, EventArgs e)
        {
            parametrerComposant();
        }

        #endregion




        #region procédures 
        private void parametrerComposant()
        {
           lblTitre.Text = "Enregistrer le bilan d'une visite";

        }



        #endregion
    }
}
