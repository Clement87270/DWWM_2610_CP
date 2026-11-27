namespace moyenneDe2Nombre
{
    internal class Program
    {   
        static double Moyenne (double a, double b)
        {
            double resultat;
                
            resultat = (a + b) / 2;
            double arrondiResultat = Math.Round(resultat,2);
            return arrondiResultat;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez rentrer A : ");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez rentrer B : ");
            double B = double.Parse(Console.ReadLine());

            double result = Moyenne(A, B);
            Console.WriteLine(result);
        }
    }
}
