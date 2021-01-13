using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezziDiTrasporto
{
    public class Automobile : MezzoDiTrasporto
    {
        public int Cilindrata { get; private set; }
        public bool Elettrica { get; set; }

        private const ushort NUMERO_RUOTE = 4;

        public Automobile(int lunghezza, double peso, Colore colore, int cilindrata) : base(lunghezza, peso, colore)
        {
            Cilindrata = cilindrata;
            Elettrica = false;
        }

        public override ushort GetNumeroRuote()
        {
            return NUMERO_RUOTE;
        }

        public override string ToString()
        {
            return base.ToString() + $" Cilindrata = {Cilindrata}; Elettrica = {Elettrica};";
        }
    }
}
