namespace Interface {
    partial class FrmConnexion {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConnexion));
            this.txtMdp = new TextBox();
            this.txtLogin = new TextBox();
            this.imgGsb = new PictureBox();
            this.btnConnecter = new Button();
            this.lblErreurConnexion = new Label();
            this.bulleLogin = new ToolTip(this.components);
            this.bulleMdp = new ToolTip(this.components);
            this.panel1 = new Panel();
            this.imgLogin = new PictureBox();
            this.panel2 = new Panel();
            this.impPassword = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)this.imgGsb).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.imgLogin).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.impPassword).BeginInit();
            this.SuspendLayout();
            // 
            // txtMdp
            // 
            this.txtMdp.BorderStyle = BorderStyle.None;
            this.txtMdp.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtMdp.Location = new Point(58, 16);
            this.txtMdp.Margin = new Padding(4, 5, 4, 5);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new Size(158, 23);
            this.txtMdp.TabIndex = 7;
            this.txtMdp.UseSystemPasswordChar = true;
            this.txtMdp.Enter += this.txtMdp_Enter;
            this.txtMdp.KeyDown += this.txtMdp_KeyDown;
            // 
            // txtLogin
            // 
            this.txtLogin.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txtLogin.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.txtLogin.BorderStyle = BorderStyle.None;
            this.txtLogin.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtLogin.Location = new Point(55, 17);
            this.txtLogin.Margin = new Padding(4, 5, 4, 5);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new Size(144, 23);
            this.txtLogin.TabIndex = 6;
            this.txtLogin.Enter += this.txtLogin_Enter;
            this.txtLogin.KeyDown += this.txtLogin_KeyDown;
            // 
            // imgGsb
            // 
            this.imgGsb.BackgroundImage = (Image)resources.GetObject("imgGsb.BackgroundImage");
            this.imgGsb.BackgroundImageLayout = ImageLayout.Stretch;
            this.imgGsb.Location = new Point(12, 41);
            this.imgGsb.Margin = new Padding(3, 2, 3, 2);
            this.imgGsb.Name = "imgGsb";
            this.imgGsb.Size = new Size(302, 199);
            this.imgGsb.TabIndex = 11;
            this.imgGsb.TabStop = false;
            // 
            // btnConnecter
            // 
            this.btnConnecter.AutoSize = true;
            this.btnConnecter.BackColor = Color.SlateGray;
            this.btnConnecter.BackgroundImageLayout = ImageLayout.Stretch;
            this.btnConnecter.Font = new Font("Georgia", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            this.btnConnecter.ForeColor = Color.White;
            this.btnConnecter.Location = new Point(330, 174);
            this.btnConnecter.Margin = new Padding(4, 5, 4, 5);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new Size(222, 66);
            this.btnConnecter.TabIndex = 17;
            this.btnConnecter.Text = "Se connecter";
            this.btnConnecter.UseVisualStyleBackColor = false;
            this.btnConnecter.Click += this.btnConnecter_Click;
            // 
            // lblErreurConnexion
            // 
            this.lblErreurConnexion.Dock = DockStyle.Top;
            this.lblErreurConnexion.Font = new Font("Georgia", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            this.lblErreurConnexion.ForeColor = Color.Red;
            this.lblErreurConnexion.Location = new Point(0, 0);
            this.lblErreurConnexion.Name = "lblErreurConnexion";
            this.lblErreurConnexion.Size = new Size(564, 39);
            this.lblErreurConnexion.TabIndex = 18;
            this.lblErreurConnexion.Text = "msg";
            this.lblErreurConnexion.Visible = false;
            // 
            // bulleLogin
            // 
            this.bulleLogin.BackColor = Color.Red;
            this.bulleLogin.ForeColor = Color.LightGray;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.imgLogin);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Location = new Point(333, 38);
            this.panel1.Margin = new Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(219, 54);
            this.panel1.TabIndex = 31;
            // 
            // imgLogin
            // 
            this.imgLogin.Dock = DockStyle.Left;
            this.imgLogin.Image = Properties.Resources.user_on;
            this.imgLogin.Location = new Point(0, 0);
            this.imgLogin.Margin = new Padding(4, 5, 4, 5);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.Size = new Size(44, 52);
            this.imgLogin.SizeMode = PictureBoxSizeMode.AutoSize;
            this.imgLogin.TabIndex = 28;
            this.imgLogin.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.impPassword);
            this.panel2.Controls.Add(this.txtMdp);
            this.panel2.Location = new Point(330, 108);
            this.panel2.Margin = new Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(222, 56);
            this.panel2.TabIndex = 32;
            // 
            // impPassword
            // 
            this.impPassword.Dock = DockStyle.Left;
            this.impPassword.Image = Properties.Resources.mdp_on;
            this.impPassword.Location = new Point(0, 0);
            this.impPassword.Margin = new Padding(4, 5, 4, 5);
            this.impPassword.Name = "impPassword";
            this.impPassword.Size = new Size(44, 54);
            this.impPassword.SizeMode = PictureBoxSizeMode.AutoSize;
            this.impPassword.TabIndex = 29;
            this.impPassword.TabStop = false;
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = SystemColors.ControlLightLight;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ClientSize = new Size(564, 254);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblErreurConnexion);
            this.Controls.Add(this.btnConnecter);
            this.Controls.Add(this.imgGsb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new Padding(4, 5, 4, 5);
            this.Name = "FrmConnexion";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Laboratoire pharmaceutique Galaxy-Swiss Bourdin - Gestion des visites";
            FormClosing += this.FrmConnexion_FormClosing;
            Load += this.FrmConnexion_Load;
            KeyDown += this.FrmConnexion_KeyDown;
            ((System.ComponentModel.ISupportInitialize)this.imgGsb).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.imgLogin).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.impPassword).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.PictureBox imgGsb;
        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.Label lblErreurConnexion;
        private System.Windows.Forms.ToolTip bulleLogin;
        private System.Windows.Forms.ToolTip bulleMdp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox impPassword;
    }
}

