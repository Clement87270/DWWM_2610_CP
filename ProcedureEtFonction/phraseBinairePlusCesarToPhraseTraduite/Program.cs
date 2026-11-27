namespace phraseBinairePlusCesarToPhraseTraduite
{
    internal class Program
    {
        static string InverseCodeDeCesar(string chaineDeCaracter)
        {
            string codeModifie = "";
            for (int i = 0; i < chaineDeCaracter.Length; i++)
            {
                char lettreModifie = (char)(chaineDeCaracter[i] - 3);
                if (chaineDeCaracter[i] == 'a')
                {
                    lettreModifie = 'x';
                }
                if (chaineDeCaracter[i] == 'b')
                {
                    lettreModifie = 'y';
                }
                if (chaineDeCaracter[i] == 'c')
                {
                    lettreModifie = 'z';
                }
                if (chaineDeCaracter[i] == 'A')
                {
                    lettreModifie = 'X';
                }
                if (chaineDeCaracter[i] == 'B')
                {
                    lettreModifie = 'Y';
                }
                if (chaineDeCaracter[i] == 'C')
                {
                    lettreModifie = 'Z';
                }
                if (chaineDeCaracter[i] == ' ')
                {
                    lettreModifie = ' ';
                }

                codeModifie += lettreModifie.ToString();
            }
            return codeModifie;
        }
        static bool BinaireVersDecimal(string binaire, out int chiffreDecimal)
        {
            chiffreDecimal = 0;
            for (int i = 0; i < binaire.Length; i++)
            {
                bool bitValide;

                bitValide = int.TryParse(binaire[i].ToString(), out int bit) && (bit == 0 || bit == 1);
                if (!bitValide)
                {
                    return false;
                }
                int puissance = binaire.Length - 1 - i;
                chiffreDecimal = chiffreDecimal + bit * (int)Math.Pow(2, puissance);
            }
            return true;
        }
        static string PhraseBinaireToPhraseTraduite(string phraseBinaire)
        {
            string resultat = "";
            if (((phraseBinaire.Length) % 8) != 0)
            {
                return "la phrase ne peut se traduire";
            }
            else
            {
                //Au lieu d'incrémenter de 1, on saute de 8 caractères à chaque tour de boucle pour analyser chaque octet indépendamment.
                for (int i = 0; i < phraseBinaire.Length; i = i + 8)
                {
                    // Création d'un tableau pour stocker les 8 caractères
                    char[] buffer = new char[8];

                    for (int j = 0; j < 8; j++)
                    {
                        buffer[j] = phraseBinaire[i + j]; // On récupère chaque bit un par un
                    }

                    string octetString = new string(buffer); // On reconstruit la chaîne de 8 caractères soit un octet

                    bool octetValide = BinaireVersDecimal(octetString, out int valeurAscci);
                    if (!octetValide)
                    {
                        return "la phrase ne peut se traduire";
                    }
                    else
                    {
                        resultat = resultat + (char)valeurAscci;
                       
                    }
                }
            }
            return resultat;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Quel est votre phrase en binaire");
            string phraseBinaire1 = Console.ReadLine();

            Console.WriteLine("la phrase traduite est: ");
            Console.WriteLine(InverseCodeDeCesar(PhraseBinaireToPhraseTraduite(phraseBinaire1)));
        }
    }
}
