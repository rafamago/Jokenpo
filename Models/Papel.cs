using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Threading.Tasks;

namespace Jokenpo.Models
{
    public class Papel : Jogada
    {
        public Papel() : base (2) // o 2 representa o value da minha jogada que defini na classe jogada
        {

        }
        public override bool PerdePara(Jogada outraJogada)
        {
            return outraJogada is Tesoura || outraJogada is Lagarto;
        }
    }
}