namespace factorielle
{
    internal class Program
    {
        static private int factorielle (int nombre)
        {
            int resultat;
            if (nombre == 1)
            {
                resultat = 1;
            }
            else
            {
                resultat = nombre * factorielle (nombre - 1);
            }
            return resultat;
        }
        static void Main(string[] args)
        {
            int chiffre;
            int resultatFactorielle;
            Console.WriteLine("De quel chiffre vous voulez savoir la factorielle?");
            chiffre = int.Parse(Console.ReadLine());
            resultatFactorielle= factorielle(chiffre);

            Console.WriteLine("la factorielle de "+ chiffre +" est égal à "+ resultatFactorielle);

        }
    }
}
