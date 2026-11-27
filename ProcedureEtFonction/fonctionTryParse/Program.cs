namespace fonctionTryParse
{
    internal class Program
    {   static int chiffreValide(string question)
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
            int chiffre = chiffreValide("rentrer le nombre");
            Console.WriteLine(chiffre);
        }
    }
}


//TryParse(string nombre, out int chiffre);