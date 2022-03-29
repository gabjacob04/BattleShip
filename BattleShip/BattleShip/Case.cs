using System.Drawing;

namespace BattleShip
{
    internal class Case
    {
        private bool bateau;

        private bool tirs;
        private int taille;

        public Case(int taille)
        {
            Taille = taille;
        }

        public bool Bateau { get => bateau; set => bateau = value; }
        public bool Tirs { get => tirs; set => tirs = value; }
        public int Taille { get => taille; set => taille = value; }

        public Bitmap Dessiner(bool brouillard)
        {
            Bitmap dessinCase = new Bitmap(Taille, taille);
            using (Graphics graphics = Graphics.FromImage(dessinCase))
            {
                Rectangle rectangle = new Rectangle(0, 0, taille, taille);
                if (bateau == true && (brouillard != true || tirs))
                {
                    graphics.FillRectangle(Brushes.Gray, rectangle);
                }
                else
                {
                    graphics.FillRectangle(Brushes.Blue, rectangle);
                }

                if (tirs != false)
                {
                    Rectangle rectangleCercle = new Rectangle(2, 2, taille - 4, taille - 4);
                    graphics.FillEllipse(Brushes.Red, rectangleCercle);
                }
            }
            return dessinCase;
        }
    }
}