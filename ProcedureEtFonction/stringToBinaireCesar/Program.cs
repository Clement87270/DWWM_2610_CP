namespace stringToBinaireCesar
{
    internal class Program
    {
        static string CodeDeCesar(string chaineDeCaracter)
        {
            string codeModifie = "";
            for (int i = 0; i < chaineDeCaracter.Length; i++)
            {
                char lettreModifie = (char)(chaineDeCaracter[i] + 3);
                if (chaineDeCaracter[i] == 'x')
                {
                    lettreModifie = 'a';
                }
                if (chaineDeCaracter[i] == 'y')
                {
                    lettreModifie = 'b';
                }
                if (chaineDeCaracter[i] == 'z')
                {
                    lettreModifie = 'c';
                }
                if (chaineDeCaracter[i] == 'X')
                {
                    lettreModifie = 'A';
                }
                if (chaineDeCaracter[i] == 'Y')
                {
                    lettreModifie = 'B';
                }
                if (chaineDeCaracter[i] == 'Z')
                {
                    lettreModifie = 'C';
                }
                if (chaineDeCaracter[i] == ' ')
                {
                    lettreModifie = ' ';
                }

                codeModifie += lettreModifie.ToString();
            }
            return codeModifie;
        }
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
                int cDecimal = (int)c;
                phraseEnBinaire = phraseEnBinaire + DecimalVersBinaire(cDecimal);
            }
            return phraseEnBinaire;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Rentrez votre phrase: ");
            string phraseAMettreEnBinaire = Console.ReadLine();

            Console.WriteLine("la phrase que vous avez écrite correspond à:");
            Console.WriteLine(StringToBinaire(CodeDeCesar(phraseAMettreEnBinaire)));
        }
    }
}
