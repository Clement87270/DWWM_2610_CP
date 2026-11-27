namespace an_a_a_n___1_
{   //La multiplication de a par n peut être décomposé de la façon suivante  an = a + a(n − 1)

    internal class Program
    {   static private int Multiplie(int a, int n)
        {
            int resultat;
            if (n < 1)
            {
                resultat = 0;
            }
            else
            {
                resultat = Multiplie(a, n - 1) + a;
            }
            return resultat;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
