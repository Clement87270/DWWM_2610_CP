namespace anneeBissextile
{
    internal class Program
    {
        static bool AnneeBissextile(int annee)
        {
            bool bissextile;
            if ((annee % 4 == 0 && annee%100!=0)||annee%400==0)
            {
               bissextile = true;
            }
            else
            {
               bissextile=false;
            }
            return bissextile;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Quelle est l'année dont vous voulez savoir si elle est bissextile");
            int annee = int.Parse(Console.ReadLine());

           bool anneeBisextilleTrueFalse= AnneeBissextile(annee);

            if( anneeBisextilleTrueFalse = true)
            {
                Console.WriteLine("l'année est bissextile");
            }
            else
            {
                Console.WriteLine("l'année n'est pas bissextile");
            }
        }
    }
}
