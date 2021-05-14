using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojectTransaction
{
    class Produit
    {
       private int code;
       private string nom;
       private string marque;
       private float prix_unitaire;
       private float tva;
       private int quantite;

        public Produit(int code, string nom, string marque, float prix_unitaire, float tva)
        {
            this.Code = code;
            this.Nom = nom;
            this.Marque = marque;
            this.Prix_unitaire = prix_unitaire;
            this.Tva = tva;
        }

        public int Code { get => code; set => code = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Marque { get => marque; set => marque = value; }
        public float Prix_unitaire { get => prix_unitaire; set => prix_unitaire = value; }
        public float Tva { get => tva; set => tva = value; }
        public int Quantite { get => quantite; set => quantite = value; }
    }
}
