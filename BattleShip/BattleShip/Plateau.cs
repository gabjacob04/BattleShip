using System;
using System.Drawing;

namespace BattleShip
{
    internal class Plateau
    {
        private int taille = 8;
        private int nombreBateaux = 3;
        private int tailleCase = 25;
        private int nombresDeCasesTotal;

        private bool brouillard;
        private int sourisX;
        private int sourisY;

        private int bateauDetruitOrdi;
        private int bateauDetruitDuJoueur;
        private bool ordinateur = false;

        private Case[,] casesDessin;

        private static Random aleatoire = new Random();

        public Plateau(bool brouillardDeGuerre)
        {
            nombreBateaux = NbrBateaux;
            ordinateur = Ordinateur;
            taille = Taille;
            tailleCase = TailleCase;
            nombresDeCasesTotal = taille * tailleCase;
            brouillard = brouillardDeGuerre;
            casesDessin = new Case[taille, taille];

            for (int ligne = 0; ligne <= casesDessin.GetUpperBound(0); ligne++)
            {
                for (int colonne = 0; colonne <= casesDessin.GetUpperBound(1); colonne++)
                {
                    casesDessin[ligne, colonne] = new Case(tailleCase);
                }
            }
            PositionDesBateaux(nombreBateaux);
        }

        public int TailleCase { get => tailleCase; set => tailleCase = value; }

        public bool Ordinateur { get => ordinateur; set => ordinateur = value; }
        public int Taille { get => taille; set => taille = value; }
        public int NbrBateaux { get => nombreBateaux; set => nombreBateaux = value; }
        internal Case[,] CasesDessin { get => casesDessin; set => casesDessin = value; }
        public int SourisX { get => sourisX; set => sourisX = value; }
        public int SourisY { get => sourisY; set => sourisY = value; }
        public bool Brouillard { get => brouillard; set => brouillard = value; }

        public int BateauDetruitDuJoueur { get => bateauDetruitDuJoueur; set => bateauDetruitDuJoueur = value; }
        public int BateauDetruitOrdi { get => bateauDetruitOrdi; set => bateauDetruitOrdi = value; }

        public Bitmap Dessiner()
        {
            Bitmap bitmap = new Bitmap(tailleCase * taille, tailleCase * taille);
            using (Graphics graphic = Graphics.FromImage(bitmap))
            {
                Pen pen = new Pen(Brushes.Black);

                for (int ligne = 0; ligne <= casesDessin.GetUpperBound(0); ligne++)
                {
                    for (int colonne = 0; colonne <= casesDessin.GetUpperBound(1); colonne++)
                    {
                        graphic.DrawImage(casesDessin[ligne, colonne].Dessiner(brouillard), tailleCase * ligne, tailleCase * colonne);
                        for (int y = 0; y <= (taille + 1); ++y)
                        {
                            graphic.DrawLine(pen, 0, y * tailleCase, nombresDeCasesTotal, y * tailleCase);
                        }

                        for (int x = 0; x <= (taille + 1); ++x)
                        {
                            graphic.DrawLine(pen, x * tailleCase, 0, x * tailleCase, nombresDeCasesTotal);
                        }
                    }
                }
            }
            return bitmap;
        }

        public Bitmap DessinerEnnemi()
        {
            Bitmap bitmap = new Bitmap(tailleCase * taille, tailleCase * taille);
            using (Graphics graphic = Graphics.FromImage(bitmap))
            {
                Pen pen = new Pen(Brushes.Black);

                for (int ligne = 0; ligne <= casesDessin.GetUpperBound(0); ligne++)
                {
                    for (int colonne = 0; colonne <= casesDessin.GetUpperBound(1); colonne++)
                    {
                        graphic.DrawImage(casesDessin[ligne, colonne].Dessiner(brouillard), tailleCase * ligne, tailleCase * colonne);
                        for (int y = 0; y <= (taille + 1); ++y)
                        {
                            graphic.DrawLine(pen, 0, y * tailleCase, nombresDeCasesTotal, y * tailleCase);
                        }

                        for (int x = 0; x <= (taille + 1); ++x)
                        {
                            graphic.DrawLine(pen, x * tailleCase, 0, x * tailleCase, nombresDeCasesTotal);
                        }
                    }
                }
            }
            return bitmap;
        }

        public void ToursJoueur()
        {
            ToursOrdi();
        }

        public void ToursOrdi()
        {
            if (ordinateur)
            {
                int x = aleatoire.Next(0, 8);
                int y = aleatoire.Next(0, 8);
                PositionTirsEnnemi(x, y);
            }
        }

        public bool Victoire()
        {
            if (bateauDetruitOrdi == nombreBateaux)
            {
                System.Windows.Forms.MessageBox.Show("Vous avez gagner!");
                return true;
            }

            if (bateauDetruitDuJoueur == nombreBateaux)
            {
                System.Windows.Forms.MessageBox.Show("Vous avez perdu!");
                return true;
            }
            return false;
        }

        public void recommencer()
        {
            bateauDetruitDuJoueur = 0;
            bateauDetruitOrdi = 0;
            for (int ligne = 0; ligne < casesDessin.GetUpperBound(0) + 1; ligne++)
            {
                for (int colonne = 0; colonne < casesDessin.GetUpperBound(1) + 1; colonne++)
                {
                    casesDessin[ligne, colonne].Tirs = false;
                    casesDessin[ligne, colonne].Bateau = false;
                }
            }
            PositionDesBateaux(nombreBateaux);
        }

        public void PositionTirsJoueur(int x, int y)
        {
            Math.Abs(SourisX = x / 25);
            Math.Abs(SourisY = y / 25);

            ToursJoueur();

            if (casesDessin[sourisX, sourisY].Bateau && casesDessin[sourisX, sourisY].Tirs == false)
            {
                BateauDetruitOrdi++;
            }
            casesDessin[sourisX, sourisY].Tirs = true;
        }

        public void PositionTirsEnnemi(int x, int y)
        {
            ordinateur = false;
            if (casesDessin[x, y].Bateau && casesDessin[x, y].Tirs == false)
            {
                BateauDetruitDuJoueur++;
            }
            casesDessin[x, y].Tirs = true;
        }

        public void PositionDesBateaux(int nombreDeBateauAplacer)
        {
            int nombreDeBateauxPlacer = 0;

            while (nombreDeBateauxPlacer < nombreDeBateauAplacer)
            {
                int randomX = aleatoire.Next(0, 8);
                int randomY = aleatoire.Next(0, 8);
                casesDessin[randomX, randomY].Bateau = true;

                nombreDeBateauxPlacer++;
            }
        }
    }
}