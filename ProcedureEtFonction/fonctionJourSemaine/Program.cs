namespace fonctionJourSemaine
{
    internal class Program
    {
        static string JourSemaine(int jour,int mois,int annee)
        {
            string j="";
            int resultat4;
            int reste7;
            int valeurMois;
            resultat4 = annee % 4;

            switch (mois)
            {
                case 1:
                    if (resultat4 == 0)
                    {
                        valeurMois = 0;
                    }
                    else
                    {
                        valeurMois = 1;
                    }
                    break;
                case 2:
                    if (resultat4 == 0)
                    {
                        valeurMois = 3;
                    }
                    else
                    {
                        valeurMois = 4;
                    }
                    break;
                case 3:
                    valeurMois = 4;
                    break;
                case 4:
                    valeurMois = 0;
                    break;
                case 5:
                    valeurMois = 2;
                    break;
                case 6:
                    valeurMois = 5;
                    break;
                case 7:
                    valeurMois = 0;
                    break;
                case 8:
                    valeurMois = 3;
                    break;
                case 9:
                    valeurMois = 6;
                    break;
                case 10:
                    valeurMois = 1;
                    break;
                case 11:
                    valeurMois = 4;
                    break;
                case 12:
                    valeurMois = 6;
                    break;
                default:
                    valeurMois = 0;
                    break;
            }
            reste7 = (annee + resultat4 + valeurMois + jour) % 7;

            switch (reste7)
            {
                case 0:
                    j = "c'était un dimanche";
                    break;
                case 1:
                    j = "c'était un lundi";
                    break;
                case 2:
                    j = "c'était un mardi";
                    break;
                case 3:
                    j = "c'était un mercredi";
                    break;
                case 4:
                    j = "c'était un jeudi";
                    break;
                case 5:
                    j = "c'était un vendredi";
                    break;
                case 6:
                    j = "c'était un samedi";
                    break;  
            }
            return j;
        }


        static void Main (String[] args)
        {
            Console.WriteLine("quel est le jour ?");
            int jour = int.Parse(Console.ReadLine());

            while (jour < 1 || jour > 31)
            {
                Console.WriteLine("veuillez entré un  jour valide entre 1 et 31");
                Console.WriteLine("Quel est le jour ?");
                jour = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Quel est le mois?");
            int mois = int.Parse(Console.ReadLine());

            while (mois < 1 || mois > 12)
            {
                Console.WriteLine("veuillez entrer un  mois valide entre 1 et 12 inclus");
                Console.WriteLine("Quel est le mois ?");
                mois = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Quelle est l'année comprise entre 1901 et 1999 inclus en sachant que vous devez rentrer les deux dernier chiffre exemple pour 1981 rentrez 81");
            int annee = int.Parse(Console.ReadLine());

            //mettre ligne de code pour si sup ou inf de 1901 et 1999 entraine erreur 
            while (annee < 1 || annee > 99)
            {
                Console.WriteLine("Veuillez entré une année valide entre 1 et 99 inclus");
                Console.WriteLine("Quel est l'année ?");
                annee = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(JourSemaine(jour, mois, annee));
        }
    }
}
