using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojectTransaction
{
    class Transaction
    {
        private int codetr;
        private DateTime datetr;
        private int codeclient;
        private int codeproduit;
        private int qteavendre;

        public Transaction(int codetr, DateTime datetr, int codeclient, int codeproduit, int qteavendre)
        {
            this.Codetr = codetr;
            this.Datetr = datetr;
            this.Codeclient = codeclient;
            this.Codeproduit = codeproduit;
            this.Qteavendre = qteavendre;
        }

        public int Codetr { get => codetr; set => codetr = value; }
        public DateTime Datetr { get => datetr; set => datetr = value; }
        public int Codeclient { get => codeclient; set => codeclient = value; }
        public int Codeproduit { get => codeproduit; set => codeproduit = value; }
        public int Qteavendre { get => qteavendre; set => qteavendre = value; }
    }
}
