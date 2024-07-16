using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jokenpo.Models
{
    public class Pedra : Jogada
    {
        public Pedra() : base (1)
        {

        }
        public override bool PerdePara(Jogada outraJogada)
        {
            return outraJogada is Papel || outraJogada is Spock;
        }
    }
}