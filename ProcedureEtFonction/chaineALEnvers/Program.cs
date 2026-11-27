namespace chaineALEnvers
{
    internal class Program
    {
        static void ChaineALEnvers(ref string phrase)
        {
            char[] tableauALEndroit = new char[phrase.Length];
            for (int i = 0;i< tableauALEndroit.Length; i++)
            {
                tableauALEndroit[i] = phrase[i];
            }
            string chaineALEnvers = "";
            for(int i = phrase.Length - 1; i >= 0; i--)
            {
                chaineALEnvers= chaineALEnvers+tableauALEndroit[i];
            }
            phrase = chaineALEnvers;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("tapez votre phrase dont vous voulez qu'elle soit à l'envers");
            string phrase1=Console.ReadLine();
            ChaineALEnvers(ref phrase1);
            Console.WriteLine("votre phrase a l'envers est " + phrase1);

        }
    }
}
