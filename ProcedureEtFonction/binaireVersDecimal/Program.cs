namespace binaireVersDecimal
{
    internal class Program
    {
        static bool BinaireVersDecimal(string binaire, out int chiffreDecimal)
        { chiffreDecimal = 0;
            for (int i = 0; i < binaire.Length; i++)
            {
                bool bitValide;
               
                bitValide = int.TryParse(binaire[i].ToString(),out int bit)&& (bit == 0 || bit == 1);
                if (!bitValide)
                {
                    return false;
                }
                int puissance = binaire.Length - 1 - i;
                chiffreDecimal = chiffreDecimal + bit*(int) Math.Pow(2,puissance);
            }
            return true;
        }
        
        static void Main(string[] args)
        {   
            bool conversionBonne;
            int chiffreDecimal;
            string binaire;
            do
            {
                Console.WriteLine("Quelle chiffre binaire, voulez vous qu'il soit en decimal rentrez que des 1 et 0");
                binaire = Console.ReadLine();
                conversionBonne = BinaireVersDecimal(binaire, out chiffreDecimal);
            } while (!conversionBonne);

            Console.WriteLine(chiffreDecimal);
        }
    }
}
