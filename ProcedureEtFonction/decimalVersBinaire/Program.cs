namespace decimalVersBinaire
{
    internal class Program
    {
        static string DecimalVersBinaire(int nombre)
        {
            int reste;
            int bit;
            reste = nombre;
            string binaire = "";
            do
            {
                bit = reste % 2;
                binaire = bit + binaire;
                reste = (reste - bit) / 2;
            }
            while (reste != 0);
                            // passe en 8 bit
            return binaire.PadLeft(8, '0');
        }
        static void Main(string[] args)
        {
            Console.WriteLine("quel est le chiffre?");
            int chiffre = int.Parse(Console.ReadLine());

            Console.WriteLine("le chiffre "+ chiffre + " est en binaire: " +DecimalVersBinaire(chiffre));
        }
    }
}
