using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgiobalta
{
    class Client
    {
        string cni { get; set; }
        string nom { get; set; }
        string prenom { get; set; }
        string tel { get; set; }

        public Client(string cni, string nom, string prenom, string tel)
        {
            this.cni = cni;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
        }
        public Client(string cni, string nom, string prenom)
        {
            this.cni = cni;
            this.nom = nom;
            this.prenom = prenom;
        }
        public string Afficher()
        {
            return this.ToString();
        }
        override
            public string ToString()
        {
            return String.Format("{0} {1} \nCNI : {2}\nTel : {3}", this.nom.ToUpper(), this.prenom, this.cni, this.tel);
        }

    }
}
