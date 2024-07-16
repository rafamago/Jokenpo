using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jokenpo.Models
{
    public class Tesoura : Jogada
    {
        public Tesoura() : base (3)
        {

        }
        public override bool PerdePara(Jogada outraJogada)
        {
            return outraJogada is Pedra || outraJogada is Spock;
        }
    }
}