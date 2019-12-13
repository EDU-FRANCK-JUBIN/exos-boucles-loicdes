using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgiobalta
{
    class Program
    {
        // Premiers exos
        /*static void Main(string[] args)
        {
            
            Console.WriteLine("12 + 5 * 12.5 - 1253.68 = {0} ", 12 + 5 * 12.5 - 1253.68);
            Console.ReadLine();
            Console.WriteLine("(1.0 + 5.5 + 9.9 + 2.8 + 9.6) / 5 = {0}", (1.0 + 5.5 + 9.9 + 2.8 + 9.6) / 5);
            Console.ReadLine();
            Console.WriteLine("Entrez un rayon");
            int r = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rayon = {0}", 2 * Math.PI * r);
            Console.ReadLine();
            Console.WriteLine("Surface = {0}", 2 * Math.PI * r * r);
            Console.ReadLine();
            
            // Tableau Exercice
            int [] ages = { 1, 2, 3, 4, 5, 6 };
            string[] prenoms = { "A", "B", "C", "D", "E", "F" };
            for(int i = 0; i < 6; i++) {
                Console.WriteLine("{0} : {1}", ages[i], prenoms[i]);
            }

            // Liste exercice
            List<string> fruits = new List<string>();
            fruits.Add("banane");
            fruits.Add("melon");
            fruits.Add("fraise");
            fruits.Add("fromage");
            fruits.Add("fruit de la passion");
            fruits.Remove("banane");
            fruits.ForEach(fruit =>
            {
                Console.WriteLine(fruit);
            });
            
            

            // Dictionnaire exercice

            Dictionary<string, int> dico = new Dictionary<string, int>();
            dico.Add("Loic DSRS", 20);
            dico.Add("Aymerich DLTR", 21);
            dico.Add("Loriane LPZ", 22);
            dico.Add("Florent MNC", 21);
            dico.Add("Nicolas FRR", 21);
            dico.Add("Robin FRD", 23);


            Console.WriteLine("Affichage des trois premiers en utilisant la clé");
            Console.WriteLine("{0} a {1} ans", "Loic", dico["Loic DSRS"]);
            Console.WriteLine("{0} a {1} ans", "Aymerich", dico["Aymerich DLTR"]);
            Console.WriteLine("{0} a {1} ans", "Loriane", dico["Loriane LPZ"]);

            Console.WriteLine("Suppression des 3e et 5e éléments");
            dico.Remove(dico.ElementAt(2).Key);
            dico.Remove(dico.ElementAt(4).Key);

            foreach (var key in dico.Keys)
            {
                Console.WriteLine("{0} a {1} ans", key.Split(' ')[0], dico[key]);
            }
            Console.ReadLine();
            

        }*/
    }
}
