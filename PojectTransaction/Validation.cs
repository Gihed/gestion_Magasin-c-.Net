using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PojectTransaction
{
    class Validation
    {
        public static  Boolean VerificationEmail (string chaine)
        {
            Regex Rx = new Regex("^[a-zA-Z0-9]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z0-9]{1,3}$");
       
            if (Rx.IsMatch(chaine))
            {return  true ;}
            else 
            {   MessageBox.Show("Veuillez vérifier votre adresse mail !");
                return false; 
            }

        }

        public static Boolean VerificationCode(string valeur)
        {
            Regex Rx2 = new Regex("^[0-9]{1,10}$");
            if (Rx2.IsMatch(valeur))
            { return true; }
            else
            {
                MessageBox.Show("Veuillez vérifier le code, il doit auvoir au maximum 10 chiffres.");
                return false;
            }
        }

        public static Boolean VerificationTexte(string str)
        {
            Regex Rx3 = new Regex("^[a-zA-Z_]");
            if (Rx3.IsMatch(str))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Ce champs comporte des lettres et des espaces!");
                return false;
            }
        }

        public static Boolean VerificationTelephone(string tel)
        {
            Regex Rx4 = new Regex("^[0-9]{8}$");
            if (Rx4.IsMatch(tel))
            { return true; }
            else
            {
                MessageBox.Show("Veuillez vérifier votre numéro de téléphone, il doit avoir 8 chiffres ");
                return false;
            }
        }

        public static Boolean VerificationFloat (string nombreReel)
        {

            Regex Rx5 = new Regex("^[0-9]");
            if (Rx5.IsMatch(nombreReel))
            { return true; }
            else
            {
                MessageBox.Show("Veuillez vérifier votre prix unitaire !  ");
                return false;
            }

        }

        public static Boolean VerificationTVA (float nombreTVA)
        {
            
            if ( (nombreTVA >= 0 && nombreTVA <= 1))
            { return true; }
            else
            {
                MessageBox.Show("le TVA doit être un réel entre 0 et 1 !");
                return false;
            }

        }

     
        public static Boolean VerificationQuantite(string valeur)
        {
            Regex Rx2 = new Regex("^[0-9]{1,4}$");
            if (Rx2.IsMatch(valeur))
            { return true; }
            else
            {
                MessageBox.Show("Veuillez saisir une quantité valide !");
                return false;
            }
        }

       /* public static Boolean VerificationFonction(string fonct)
        {
            
            if ((fonct == "ouvrier") || (fonct == "ingenieur"))
            { return true; }
            else
            {
                MessageBox.Show("veuillez saisir ouvrier ou ingénieur.");
                return false;
            }
        }*/

       /*   public static Boolean VerificationSalaire (string sal)
        {

            Regex Rx5 = new Regex("^[0-9]*[.]?[0-9]");
            if (Rx5.IsMatch(sal))
            { return true; }
            else
            {
                MessageBox.Show("Veuillez vérifier votre salaire !  ");
                return false;
            }

        }*/



    }
}
