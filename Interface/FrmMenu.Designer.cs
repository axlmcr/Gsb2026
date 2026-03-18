namespace Interface
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Size = new Size(782, 99);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = DockStyle.Fill;
            this.pictureBox1.Image = Properties.Resources.logoGSB;
            this.pictureBox1.Location = new Point(0, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(782, 366);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(782, 553);
            this.Controls.Add(this.pictureBox1);
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.KeyPreview = true;
            this.MinimumSize = new Size(800, 600);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            Load += this.FrmMenu_Load;
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
    }
}