namespace Interface
{
    partial class FrmVisiteImpression
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteImpression));
            panelCentral = new Panel();
            lblErreurConnexion = new Label();
            imgGsb = new PictureBox();
            panel2 = new Panel();
            dtpFin = new DateTimePicker();
            dtpDebut = new DateTimePicker();
            label1 = new Label();
            imgImprimer = new PictureBox();
            imgApercu = new PictureBox();
            panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgGsb).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgImprimer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgApercu).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(800, 74);
            // 
            // panelCentral
            // 
            panelCentral.Controls.Add(lblErreurConnexion);
            panelCentral.Controls.Add(imgGsb);
            panelCentral.Controls.Add(panel2);
            panelCentral.Location = new Point(0, 101);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(800, 312);
            panelCentral.TabIndex = 13;
            // 
            // lblErreurConnexion
            // 
            lblErreurConnexion.Dock = DockStyle.Top;
            lblErreurConnexion.Font = new Font("Georgia", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblErreurConnexion.ForeColor = Color.Red;
            lblErreurConnexion.Location = new Point(0, 0);
            lblErreurConnexion.Name = "lblErreurConnexion";
            lblErreurConnexion.Size = new Size(800, 29);
            lblErreurConnexion.TabIndex = 19;
            lblErreurConnexion.Text = "msg";
            lblErreurConnexion.Visible = false;
            // 
            // imgGsb
            // 
            imgGsb.Image = Properties.Resources.logoGSB;
            imgGsb.Location = new Point(80, 98);
            imgGsb.Name = "imgGsb";
            imgGsb.Size = new Size(276, 185);
            imgGsb.SizeMode = PictureBoxSizeMode.StretchImage;
            imgGsb.TabIndex = 1;
            imgGsb.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtpFin);
            panel2.Controls.Add(dtpDebut);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(imgImprimer);
            panel2.Controls.Add(imgApercu);
            panel2.Location = new Point(442, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(314, 295);
            panel2.TabIndex = 0;
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(66, 100);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(200, 23);
            dtpFin.TabIndex = 4;
            dtpFin.TabStop = false;
            // 
            // dtpDebut
            // 
            dtpDebut.Location = new Point(66, 53);
            dtpDebut.Name = "dtpDebut";
            dtpDebut.Size = new Size(200, 23);
            dtpDebut.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(3, 138);
            label1.Name = "label1";
            label1.Size = new Size(39, 17);
            label1.TabIndex = 2;
            label1.Text = "msg";
            // 
            // imgImprimer
            // 
            imgImprimer.Image = Properties.Resources.imprimer;
            imgImprimer.Location = new Point(187, 181);
            imgImprimer.Name = "imgImprimer";
            imgImprimer.Size = new Size(98, 89);
            imgImprimer.SizeMode = PictureBoxSizeMode.StretchImage;
            imgImprimer.TabIndex = 1;
            imgImprimer.TabStop = false;
            // 
            // imgApercu
            // 
            imgApercu.Image = Properties.Resources.apercu;
            imgApercu.Location = new Point(31, 181);
            imgApercu.Name = "imgApercu";
            imgApercu.Size = new Size(107, 89);
            imgApercu.SizeMode = PictureBoxSizeMode.StretchImage;
            imgApercu.TabIndex = 0;
            imgApercu.TabStop = false;
            // 
            // FrmVisiteImpression
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmVisiteImpression";
            Text = "FrmVisiteImpression";
            Controls.SetChildIndex(panelCentral, 0);
            Controls.SetChildIndex(lblTitre, 0);
            panelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgGsb).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgImprimer).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgApercu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCentral;
        private PictureBox imgGsb;
        private Panel panel2;
        private PictureBox imgImprimer;
        private PictureBox imgApercu;
        private Label label1;
        private Label lblErreurConnexion;
        private DateTimePicker dtpFin;
        private DateTimePicker dtpDebut;
    }
}