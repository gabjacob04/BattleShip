
namespace BattleShip
{
    partial class Form1
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
            this.ptbTirsAdverses = new System.Windows.Forms.PictureBox();
            this.lblAdverse = new System.Windows.Forms.Label();
            this.lblJoueur = new System.Windows.Forms.Label();
            this.ptbTirsJoueur = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTirsAdverses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTirsJoueur)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbTirsAdverses
            // 
            this.ptbTirsAdverses.Location = new System.Drawing.Point(12, 327);
            this.ptbTirsAdverses.Name = "ptbTirsAdverses";
            this.ptbTirsAdverses.Size = new System.Drawing.Size(314, 259);
            this.ptbTirsAdverses.TabIndex = 1;
            this.ptbTirsAdverses.TabStop = false;
            // 
            // lblAdverse
            // 
            this.lblAdverse.AutoSize = true;
            this.lblAdverse.Location = new System.Drawing.Point(12, 307);
            this.lblAdverse.Name = "lblAdverse";
            this.lblAdverse.Size = new System.Drawing.Size(116, 17);
            this.lblAdverse.TabIndex = 2;
            this.lblAdverse.Text = "Les tirs adverses";
            // 
            // lblJoueur
            // 
            this.lblJoueur.AutoSize = true;
            this.lblJoueur.Location = new System.Drawing.Point(12, 18);
            this.lblJoueur.Name = "lblJoueur";
            this.lblJoueur.Size = new System.Drawing.Size(55, 17);
            this.lblJoueur.TabIndex = 3;
            this.lblJoueur.Text = "Vos tirs";
            // 
            // ptbTirsJoueur
            // 
            this.ptbTirsJoueur.Location = new System.Drawing.Point(12, 38);
            this.ptbTirsJoueur.Name = "ptbTirsJoueur";
            this.ptbTirsJoueur.Size = new System.Drawing.Size(314, 266);
            this.ptbTirsJoueur.TabIndex = 4;
            this.ptbTirsJoueur.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 613);
            this.Controls.Add(this.ptbTirsJoueur);
            this.Controls.Add(this.lblJoueur);
            this.Controls.Add(this.lblAdverse);
            this.Controls.Add(this.ptbTirsAdverses);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbTirsAdverses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTirsJoueur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbTirsAdverses;
        private System.Windows.Forms.Label lblAdverse;
        private System.Windows.Forms.Label lblJoueur;
        private System.Windows.Forms.PictureBox ptbTirsJoueur;
    }
}

