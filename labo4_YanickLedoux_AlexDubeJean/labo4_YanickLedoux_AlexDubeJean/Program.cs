using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo4_YanickLedoux_AlexDubeJean
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vous devez entrer une suite logique de 4 nombres.\n");

            Console.WriteLine("Entrez le premier nombre :");
            double nb1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le deuxième nombre :");
            double nb2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le troisième nombre :");
            double nb3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le quatrième nombre :");
            double nb4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le rang du dernier terme de la suite :");
            double rangDernierTerme = double.Parse(Console.ReadLine());

            double raison = 0.0;
            double termeGeneral = 0.0;
            double sommeDeLaSuite = 0.0;
            double step_d = 0;

            double resultatTestGeometrique1 = 0.0;
            double resultatTestGeometrique2 = 0.0;
            double resultatTestGeometrique3 = 0.0;

            double resultatTestArithmetique1 = 0.0;
            double resultatTestArithmetique2 = 0.0;
            double resultatTestArithmetique3 = 0.0;

            Console.Clear();

            Console.WriteLine("Terme 1 : " + nb1);
            Console.WriteLine("Terme 2 : " + nb2);
            Console.WriteLine("Terme 3 : " + nb3);
            Console.WriteLine("Terme 4 : " + nb4);
            Console.WriteLine("Position du dernier terme : " + rangDernierTerme + "\n");


            //On test si c'est une progression géométrique
            resultatTestGeometrique1 = nb4 / nb3;
            resultatTestGeometrique2 = nb3 / nb2;
            resultatTestGeometrique3 = nb2 / nb1;

            //On test si c'est une progression arithmétique
            resultatTestArithmetique1 = nb4 - nb3;
            resultatTestArithmetique2 = nb3 - nb2;
            resultatTestArithmetique3 = nb2 - nb1;

            if (resultatTestGeometrique2 == resultatTestGeometrique1
                && resultatTestGeometrique3 == resultatTestGeometrique1) // correction apportée à vérifier.
            {
                raison = resultatTestGeometrique1; // Le multiple entre les termes.
                termeGeneral = nb1 * (Math.Pow(raison, (rangDernierTerme - 1)));
                sommeDeLaSuite = (nb1 * (Math.Pow(raison, rangDernierTerme) - 1)) / (raison - 1); 

                Console.Write("Les " + rangDernierTerme + " premiers termes de la suite sont {");

                for (int i = 0; i < rangDernierTerme; i++) // Boucle pour additionner tous les termes.
                {
                    double nbSuite = nb1 * Math.Pow(raison, i); 
                    Console.Write(nbSuite + " ; ");
                }
                Console.WriteLine("...}");

                Console.WriteLine("\nLa progression est de type géometrique.");
                Console.WriteLine("\nLa raison 'r' de la suite est : X" + resultatTestGeometrique1);
                Console.WriteLine("\nLe " + rangDernierTerme + "e terme de la suite est : " + termeGeneral);

                Console.WriteLine("\nLa règle de récurence de la suite est : a_n = a_n-1 * " + raison + ", pour n>= 2, où a_1 = " + nb1);
                Console.WriteLine("\nLe terme général de la suite est : a_n = " + nb1 + "(" + raison + "^n-" + (nb1 - raison) + ")");
                Console.WriteLine("\nLa somme des " + rangDernierTerme + " premiers termes de la suite est : " + sommeDeLaSuite);
            }

            else if (resultatTestArithmetique2 == resultatTestArithmetique1
                && resultatTestArithmetique3 == resultatTestArithmetique1)
            {
                raison = resultatTestArithmetique1;
                termeGeneral = raison * rangDernierTerme + (nb1 - raison);
                sommeDeLaSuite = (rangDernierTerme * (nb1 + termeGeneral)) / 2;

                Console.Write("Les " + rangDernierTerme + " premiers termes de la suite sont {");

                for (int i = 0; i < rangDernierTerme; i++)
                {
                    double nbSuite = nb1 + step_d;
                    Console.Write(nbSuite + " ; ");
                    step_d = step_d + raison;
                }
                Console.WriteLine("...}");

                Console.WriteLine("\nLa progression est de type arithmétique.");
                Console.WriteLine("\nLa raison 'd' de la suite est : +" + resultatTestArithmetique1);
                Console.WriteLine("\nLe " + rangDernierTerme + "e terme de la suite est : " + termeGeneral);

                Console.WriteLine("\nLa règle de récurence de la suite est : a_n = a_n-1 + " + raison + ", pour n>= 2, où a_1 = " + nb1);
                Console.WriteLine("\nLe terme général de la suite est : a_n = " + raison + "n + " + (nb1 - raison));
                Console.WriteLine("\nLa somme des " + rangDernierTerme + " premiers termes de la suite est : " + sommeDeLaSuite);
            }
            else
            {
                Console.WriteLine("La progression est de type inconnue.");
            }
            Console.ReadKey();
        }
    }
}