using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgiobalta
{
    class Boucles
    {
        static void calculSomme(int borneInf, int borneSup)
        {
            int total = 0;
            while (borneInf <= borneSup)
            {
                total += borneInf;
                Console.Write(borneInf != borneSup ? borneInf + " + " : "" + borneInf);
                borneInf++;
            }
            Console.WriteLine(" = " + total);
        }
        static double moyenneListe(List<double> list)
        {
            double total = 0;
            foreach(double el in list)
            {
                total += el;
            }
            return total / list.Count;
        }

        static int somme()
        {
            List<int> multiples3 = new List<int>();
            List<int> multiples5 = new List<int>();
            int total = 0;
           for(var i = 0; i<= 100; i++)
            {
                if (i % 3 == 0) multiples3.Add(i);
                if (i % 5 == 0) multiples5.Add(i);
            }
           if (multiples3.Count > multiples5.Count)
            {
                multiples3.ForEach(el =>
                {
                    if (multiples5.Contains(el)) total += 2 * el;
                });
            }
           else
            {
                multiples5.ForEach(el =>
                {
                    if (multiples3.Contains(el)) total += 2 * el;
                });
            }
            return total;
        }

        static void Main(string[] args)
        {
            
            // Multiples de 20
            Console.WriteLine("Boucle for");
            for (var i = 0; i<=20; i+=2)
            {
                Console.WriteLine(i);
            }
            int index = 0;
            Console.WriteLine("\nBoucle while");
            while (index <= 20)
            {
                Console.WriteLine(index);
                index += 2;
            }

            // Somme totale
            Console.WriteLine("Entrez un nombre : ");
            int nombre = Convert.ToInt32(Console.ReadLine());
            double total = 0;
            for(var i = 0; i <= nombre; i++)
            {
                total += i;
                Console.Write(i != nombre ? i + " + " : "" +i);
            }
            Console.WriteLine(" = " +total);

            // Moyenne
            total = 0;
            for (var i = 0; i < 5; i++)
            {
                Console.Write("Entrez un nombre : ");
                total += Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Moyenne : " + total/5);

            Console.ReadLine();

            Console.Write("Entrez une borne inférieure : ");
            int borneInf = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez une borne supérieure : ");
            int borneSup = Convert.ToInt32(Console.ReadLine());

            calculSomme(borneInf, borneSup);
            
            List<double> list = new List<double>() { 1.0, 5.5, 9.9, 2.8, 9.6 };
            Console.WriteLine(moyenneListe(list));
            
            Console.WriteLine(somme());
            Console.ReadLine();
        }
    }
}
