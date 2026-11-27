namespace fonctionTableauFibonnacci
{
    internal class Program
    {
        static long[] TableauFibonnacci(int nombreDeNumeroDeFibonnacci)
        {
            long[] tableauDeFibonnacci = new long[nombreDeNumeroDeFibonnacci];
            for(int i = 2; i < tableauDeFibonnacci.Length; i++)
            {
                tableauDeFibonnacci[0] = 0;
                tableauDeFibonnacci[1] = 1;

                tableauDeFibonnacci[i] = tableauDeFibonnacci[i - 1] + tableauDeFibonnacci[i - 2];
            }
            return tableauDeFibonnacci;
        }
        static int NombreValide (string question)
        {   bool nbrEstValide;
            int chiffre;
            do
            {
                Console.WriteLine(question);
                nbrEstValide = int.TryParse(Console.ReadLine(), out chiffre)&&chiffre>0;

            } while (!nbrEstValide);
            return chiffre;
        } 

        static void AfficherTableau(long[] tableauDeChiffre)
        {
            for(int i = 0;i < tableauDeChiffre.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write("[" + tableauDeChiffre[i] + ",");
                }
                else if (i == tableauDeChiffre.Length - 1)
                {
                    Console.Write(tableauDeChiffre [i]+"]");
                }
                else
                {
                    Console.Write(tableauDeChiffre[i] + ",");
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int longueurTableauDeFibonnacci = NombreValide("Rentrez de combien vous voulez avoir le nombre de Fibonnacci?");
            long[]tableauDeFibonnacciLongueurAuChoix=TableauFibonnacci(longueurTableauDeFibonnacci);
            Console.WriteLine("La suite est la suivante");
            AfficherTableau(tableauDeFibonnacciLongueurAuChoix);
        }
    }
}
