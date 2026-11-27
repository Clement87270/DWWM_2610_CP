namespace procedurePerimetreAireTriangle
{
    internal class Program
    {
        static void perimetreAireTriangle(int a, int b, int c, ref double perimetre, ref double aire)
        {
            perimetre = a + b + c;
            //Math.Pow(...),1/2)-->... exposant 1/2
            aire = Math.Pow((perimetre / 2 - a)*(perimetre / 2 - b)*(perimetre / 2 - c),1/2);
        }

        static void Main(string[] args)
        {
            int A = 2;
            int B = 3;
            int C = 5;

            double perimetre1=0;
            double aire1=0;

            perimetreAireTriangle(A,B,C, ref perimetre1,ref aire1);
            Console.WriteLine("le perimètre est "+ perimetre1 + " , l'aire est "+aire1);
        }
    }
}
