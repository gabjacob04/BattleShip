using System;
using System.Drawing;
using System.Windows.Forms;

namespace BattleShip
{//Équipe Gabriel Jacob, Thomas Toulouse (et Jean-Nicolas Paquet)
    public partial class Frm : Form
    {
        private PictureBox[,] tableau = new PictureBox[8, 8];
        private Plateau plateauJoueuer = new Plateau(true);
        private Plateau plateauOrdi = new Plateau(false);

        public Frm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ptbTirsJoueur_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bitmapDuPlateaDeJeuJoueur = plateauJoueuer.Dessiner();
            e.Graphics.DrawImage(bitmapDuPlateaDeJeuJoueur, 0, 0);
        }

        private void ptbTirsAdverses_Paint(object sender, PaintEventArgs e)
        {
            Bitmap BitmapDuPlateaDeJeuOrdi = plateauOrdi.DessinerEnnemi();
            e.Graphics.DrawImage(BitmapDuPlateaDeJeuOrdi, 0, 0);
        }

        private void ptbTirsJoueur_MouseUp(object sender, MouseEventArgs e)
        {
            int X = e.Location.X;
            int Y = e.Location.Y;
            plateauJoueuer.PositionTirsJoueur(X, Y);

            ptbTirsJoueur.Invalidate();
            plateauOrdi.Ordinateur = true;

            if (plateauJoueuer.Victoire())
            {
                plateauJoueuer.recommencer();
                plateauOrdi.recommencer();
                plateauOrdi.Ordinateur = false;
            }

            tourAdversaire();

            ptbTirsJoueur.Invalidate();
            ptbTirsAdverses.Invalidate();
        }

        private void tourAdversaire()
        {
            plateauOrdi.ToursOrdi();
            ptbTirsAdverses.Invalidate();
            plateauOrdi.Ordinateur = false;
            if (plateauOrdi.Victoire())
            {
                plateauOrdi.recommencer();
                plateauJoueuer.recommencer();
            }
        }
    }
}