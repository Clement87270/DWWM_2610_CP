namespace puissance
{
    internal class Program
    {
        static private double Pow(double nombre, int puissance)
        {
            double resultat = 1;
            if (puissance == 0)
            {
                return resultat;
            }
            else
            {
                resultat = nombre * Pow(nombre, puissance - 1);
            }
            return resultat;
        }



        static void Main(string[] args)
        { double resultatNbrALaPuissance;
            Console.WriteLine("Quel est le nombre que vous voulez mettre en puissance");
            double nombre = double.Parse(Console.ReadLine());
            Console.WriteLine("Quel est la puissance");
            int puissance = int .Parse(Console.ReadLine());

            resultatNbrALaPuissance=Pow(nombre, puissance);

            Console.WriteLine(" le résultat de " + nombre + " à la puissance " + puissance + " est " + resultatNbrALaPuissance); 

        }
    }
}
