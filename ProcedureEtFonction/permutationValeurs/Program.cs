namespace permutationValeurs
{
    internal class Program
    {

        static void PermutationValeurs(ref int valeurA, ref int valeurB)
        {
            int temp;
            temp = valeurA;
            valeurA = valeurB;
            valeurB = temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("quel est le premier chiffre? : ");
                int a =int.Parse(Console.ReadLine());
            Console.WriteLine("quel est le deuxième chiffre? : ");
                int b = int.Parse(Console.ReadLine());

            PermutationValeurs (ref a, ref b);

            Console.WriteLine("Premutation le premier devient " + a + " ,le deuxième devient " + b);

        }
    }
}
