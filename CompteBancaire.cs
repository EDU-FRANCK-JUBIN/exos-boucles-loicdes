using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgiobalta
{

    class CompteBancaire
    {
        private string titulaire { get; set; }
        private double solde { get; set; }
        private char devise { get; set; }

        static int nbrComptes;

        public CompteBancaire(string titulaire, double solde, char devise)
        {
            this.titulaire = titulaire;
            this.solde = solde;
            this.devise = devise;
        }

        public void crediter(double montant)
        {
            this.solde += montant;
        }
        public void debiter(double montant)
        {
            this.solde -= montant;

        }
        public string decrire()
        {
            return this.ToString();
        }
        override
            public string ToString()
        {
            return String.Format("Titulaire du compte : {0} \nSolde : {1} \nDevise : {2}", this.titulaire, this.solde, this.devise);
        }
    }
}
