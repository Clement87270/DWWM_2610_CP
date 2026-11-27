namespace afficherTableau
{
    internal class Program
    {
        //signature de méthode: void parce que renvoie rien nom procédure AfficherTableau paramètre tableau de int
        static void AfficherTableau(int[] tableauDeNombre)
        {
            for (int i = 0; i < tableauDeNombre.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write("[" + tableauDeNombre[i] + ",");
                }
                else if (i == tableauDeNombre.Length - 1)
                {
                    Console.Write(tableauDeNombre[i] + "]");
                }
                else
                {
                    Console.Write(tableauDeNombre[i] + ",");
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] tableauDeNombre = { 2, 6, 10, 5, 3, 9 };

            AfficherTableau(tableauDeNombre);
        }
    }
}
