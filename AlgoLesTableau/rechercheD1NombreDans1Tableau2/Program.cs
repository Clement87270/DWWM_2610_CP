namespace rechercheD1NombreDans1Tableau2
{
    internal class Program
    {   static void AfficherTableau(int[] tableauDeNombre)
        {
            for (int i = 0;i< tableauDeNombre.Length; i++)
            {   if (i == 0)
                {
                    Console.Write("[" + tableauDeNombre[i]+",");
                }
                else if (i == tableauDeNombre.Length - 1)
                {
                    Console.Write(tableauDeNombre[i]+"]");
                }
                else
                {
                    Console.Write(tableauDeNombre [i]+",");
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {   int nbrElement;
            Console.WriteLine("De combien d'élément est constitué votre tableau");
            nbrElement = int.Parse(Console.ReadLine());
            int[]tableauOrdreCroissant = new int[nbrElement];

            Console.WriteLine("Quel est le chiffre 1");
            tableauOrdreCroissant[0] = int.Parse(Console.ReadLine());

            int ancienChiffre = tableauOrdreCroissant[0];
            int nouveauChiffre;
            int chiffreASavoirIndice;
            for (int i = 1; i < nbrElement; i++)
            {
                do
                {
                    Console.WriteLine("Donnez moi un chiffre supérieur au chiffre donné");
                    nouveauChiffre = int.Parse(Console.ReadLine());
                } while (nouveauChiffre < ancienChiffre);
                ancienChiffre = nouveauChiffre;
                tableauOrdreCroissant[i] = ancienChiffre;
            }

            AfficherTableau(tableauOrdreCroissant);
            Console.WriteLine("Quel est le chiffre dont vous voulez savoir l'indice");
            chiffreASavoirIndice = int.Parse(Console.ReadLine());
            string listeIndiceTrouve = " ";
            bool indiceTrouve = false;
            int j = 0;

            for (int i = 0;i < nbrElement; i++)
            {
                if (tableauOrdreCroissant[i] == chiffreASavoirIndice)
                {
                    j = i + 1;
                    listeIndiceTrouve = listeIndiceTrouve + j +",";
                    indiceTrouve=true;
                }
            }
            if (listeIndiceTrouve[listeIndiceTrouve.Length - 1] == ',')
            {
                //permet de supprimer le dernier char (,) et le remplacer par un .
                listeIndiceTrouve = listeIndiceTrouve.Remove(listeIndiceTrouve.Length-1,1)+ '.';
            }
                
            

            if (indiceTrouve == true)
            {
                Console.WriteLine("le chiffre a était trouve a(ux) indice(s) suivant " +listeIndiceTrouve);
            }
            else
            {
                Console.WriteLine("Le chiffre n'a pas été trouvé");
            }
        }

    }
}
