using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojectTransaction
{
    class Client
    {
        private int codec;
        private string nomc;
        private string prenomc;
        private string emailc;
        private string telephonec;
        private string adressec;

        public Client(int codec, string nomc, string prenomc, string emailc, string telephonec, string adressec)
        {
            Codec = codec;
            Nomc = nomc;
            Prenomc = prenomc;
            Emailc = emailc;
            Telephonec = telephonec;
            Adressec = adressec;
            
        }

        public int Codec { get => codec; set => codec = value; }
        public string Nomc { get => nomc; set => nomc = value; }
        public string Prenomc { get => prenomc; set => prenomc = value; }
        public string Emailc { get => emailc; set => emailc = value; }
        public string Telephonec { get => telephonec; set => telephonec = value; }
        public string Adressec { get => adressec; set => adressec = value; }
    }


}
