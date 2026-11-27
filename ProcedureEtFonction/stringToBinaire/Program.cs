namespace stringToBinaire
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


        static string StringToBinaire(string phrase)
        {
            string phraseEnBinaire = "";
            for (int i = 0; i < phrase.Length; i++)
            {
                char c = phrase[i];
                int cDecimal = (int) c;
                phraseEnBinaire = phraseEnBinaire + DecimalVersBinaire(cDecimal);
            }
            return phraseEnBinaire;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Rentrez votre phrase: ");
            string phraseAMettreEnBinaire=Console.ReadLine();

            Console.WriteLine("la phrase que vous avez écrite correspond à:");
            Console.WriteLine(StringToBinaire(phraseAMettreEnBinaire));
        }
    }
}
