using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgiobalta
{
    class Compte
    {
        private double solde;
        private int code { get; }
        static int nextCode = 0;
        Client propriétaire;

        public Compte(Client propriétaire)
        {
            this.solde = 0;
            this.code = ++nextCode;
            this.propriétaire = propriétaire;
        }
        public void crediter(double montant)
        {
            this.solde += montant;
        }

        public void crediter(double montant, ref Compte compte)
        {
            this.solde += montant;
            compte.solde -= montant;
        }
        public void debiter(double montant)
        {
            this.solde -= montant;
        }

        public void debiter(double montant, ref Compte compte)
        {
            this.solde -= montant;
            compte.solde += montant;
        }
        public static int afficherNbrComptes()
        {
            return nextCode;
        }
        override
            public string ToString()
        {
            return String.Format("Compte n°: {0} \nSolde : {1} \nPropriétaire : {2}", this.code, this.solde, this.propriétaire.ToString());
        }

       
    }
    class Test
    {
        /* static void Main(string[] args)
        {
            Client client1 = new Client("123456789", "Desrosiers", "Loic");
            Client client2 = new Client("987654321", "delettre", "Aymerich");
            Compte compte1 = new Compte(client1);
            Compte compte2 = new Compte(client2);
            Console.WriteLine(compte1.ToString());
            Console.ReadLine();

            Console.WriteLine("Crédit");
            Console.ReadLine();
            compte1.crediter(10.5);
            Console.WriteLine(compte1.ToString());
            Console.ReadLine();

            Console.WriteLine("Débit");
            Console.ReadLine();
            compte1.debiter(1.5);
            Console.WriteLine(compte1.ToString());
            Console.ReadLine();

            Console.WriteLine("Crédit 2");
            Console.ReadLine();
            compte1.crediter(1.5, ref compte2);
            Console.WriteLine(compte1.ToString());
            Console.WriteLine(compte2.ToString());
            Console.ReadLine();

            Console.WriteLine("Débit 2");
            Console.ReadLine();
            compte1.debiter(1.5, ref compte2);
            Console.WriteLine(compte1.ToString());
            Console.WriteLine(compte2.ToString());

            Console.ReadLine();


        }
        */
    }
}
