using Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmVisiteImpression : FrmBase
    {
        public FrmVisiteImpression(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
            Resize();

        }


        #region Procédures événementielles
        // private void Load()
        // {

        // }

        private void centrerFormulaire()
        {
            panelCentral.Left = (this.ClientSize.Width - panelCentral.Width) / 2;
        }

        private void Resize()
        {
            this.Load += (s, e) => centrerFormulaire();

        }


        #endregion

    }
}
