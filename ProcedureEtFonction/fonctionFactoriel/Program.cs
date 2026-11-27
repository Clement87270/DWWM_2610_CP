namespace fonctionFactoriel
{
    internal class Program
    {
        static int factoriel(int nombre)
        {
            int fact = 1;
            for (int i = 1; i <= nombre; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        static int chiffreValide(string question)
        {
            bool estChiffreValide;
            int chiffre;
            do
            {
                Console.WriteLine(question);
                estChiffreValide = int.TryParse(Console.ReadLine(), out chiffre);
            } while (!estChiffreValide);
            return chiffre;
        }
        static void Main(string[] args)
        {
            int nombre = chiffreValide("rentrer le nombre dont vous voulez savoir la factorielle");
            Console.WriteLine("la factorielle de " + nombre + " est " + factoriel(nombre));
        }
    }
}
