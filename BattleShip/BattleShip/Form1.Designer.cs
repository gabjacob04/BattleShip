
namespace BattleShip
{
    partial class Frm
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
            this.ptbTirsAdverses.Location = new System.Drawing.Point(11, 279);
            this.ptbTirsAdverses.Margin = new System.Windows.Forms.Padding(2);
            this.ptbTirsAdverses.Name = "ptbTirsAdverses";
            this.ptbTirsAdverses.Size = new System.Drawing.Size(201, 201);
            this.ptbTirsAdverses.TabIndex = 1;
            this.ptbTirsAdverses.TabStop = false;
            this.ptbTirsAdverses.Paint += new System.Windows.Forms.PaintEventHandler(this.ptbTirsAdverses_Paint);
            // 
            // lblAdverse
            // 
            this.lblAdverse.AutoSize = true;
            this.lblAdverse.Location = new System.Drawing.Point(11, 264);
            this.lblAdverse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdverse.Name = "lblAdverse";
            this.lblAdverse.Size = new System.Drawing.Size(86, 13);
            this.lblAdverse.TabIndex = 2;
            this.lblAdverse.Text = "Les tirs adverses";
            // 
            // lblJoueur
            // 
            this.lblJoueur.AutoSize = true;
            this.lblJoueur.Location = new System.Drawing.Point(9, 7);
            this.lblJoueur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJoueur.Name = "lblJoueur";
            this.lblJoueur.Size = new System.Drawing.Size(41, 13);
            this.lblJoueur.TabIndex = 3;
            this.lblJoueur.Text = "Vos tirs";
            // 
            // ptbTirsJoueur
            // 
            this.ptbTirsJoueur.Location = new System.Drawing.Point(11, 22);
            this.ptbTirsJoueur.Margin = new System.Windows.Forms.Padding(2);
            this.ptbTirsJoueur.Name = "ptbTirsJoueur";
            this.ptbTirsJoueur.Size = new System.Drawing.Size(201, 201);
            this.ptbTirsJoueur.TabIndex = 4;
            this.ptbTirsJoueur.TabStop = false;
            this.ptbTirsJoueur.Paint += new System.Windows.Forms.PaintEventHandler(this.ptbTirsJoueur_Paint);
            this.ptbTirsJoueur.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptbTirsJoueur_MouseUp);
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 491);
            this.Controls.Add(this.ptbTirsJoueur);
            this.Controls.Add(this.lblJoueur);
            this.Controls.Add(this.lblAdverse);
            this.Controls.Add(this.ptbTirsAdverses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Battleship";
            this.Load += new System.EventHandler(this.Form1_Load);
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

