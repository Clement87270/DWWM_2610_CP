namespace EstPremier
{
    internal class Program
    {   
        static bool EstPremier(int nombre)
        {  
            for (int div = 2;div<= Math.Sqrt(nombre); div++)
            {
                if (nombre % div == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static double ChiffreValide(string question)
        {
            bool estChiffreValide;
            int chiffre;
            do
            {
                Console.WriteLine(question);
                estChiffreValide = int.TryParse(Console.ReadLine(), out chiffre)&& chiffre>0;
            } while (!estChiffreValide);
            return chiffre;
        }
        static void Main(string[] args)
        {
            double limite = ChiffreValide("rentrez une limite de calcul supérieur à zéro");

            string listeEntierPremier = "";

            for(int i = 2; i < limite; i++)
            {
                if (EstPremier(i) == true)
                {
                    listeEntierPremier += " " +i;
                }
                
            }

            Console.WriteLine(listeEntierPremier);
        }
    }
}
