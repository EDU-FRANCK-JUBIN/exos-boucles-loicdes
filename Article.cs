using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgiobalta
{
    class Article
    {
        string reference { get; set; }
        string designation { get; set; }
        double prixHT { get; set; }

        private static readonly double tauxTVA = 20;

        public Article() { }
        public Article(string reference, string designation, double prixHT = 0) // Paramètres optionnels
        {
            this.reference = reference;
            this.designation = designation;
            this.prixHT = prixHT;
        }
        public Article(Article article) // Paramètres optionnels
        {
            this.reference = article.reference;
            this.designation = article.designation;
            this.prixHT = article.prixHT;
        }

        public double calculerPrixTTC()
        {
            return this.prixHT + (this.prixHT * tauxTVA / 100);
        }

        public string AfficherArticle()
        {
            return String.Format("Référence: {0} \nDésignation : {1} \nPrix HT : {2}  \nTaux TVA : {3}", this.reference, this.designation, this.prixHT, tauxTVA);
        }

    }
    public class TestArticles
    {
        static void Main(string[] args)
        {
            Article article1 = new Article();
            Article article2 = new Article("123456789", "Papier toilette lotus");
            Article article3 = new Article("123456789", "Papier toilette lotus super soft", 10.2);
            Article article4 = new Article(article2);
            Console.WriteLine("Article 1 " + article1.AfficherArticle() + " \nprix total : " + article1.calculerPrixTTC());
            Console.ReadLine();
            Console.WriteLine("Article 2 " + article2.AfficherArticle() + " \nprix total : " + article2.calculerPrixTTC());
            Console.ReadLine();
            Console.WriteLine("Article 3 " + article3.AfficherArticle() + " \nprix total : " + article3.calculerPrixTTC());
            Console.ReadLine();
            Console.WriteLine("Article 4 " + article4.AfficherArticle() + " \nprix total : " + article4.calculerPrixTTC());
            Console.ReadLine();

        }
    }
}
