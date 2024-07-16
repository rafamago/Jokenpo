using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jokenpo.Models
{
    public class Spock : Jogada
    {
        public Spock() : base (5)
        {

        }
        public override bool PerdePara(Jogada outraJogada)
        {
            return outraJogada is Lagarto || outraJogada is Papel;
        }
    }
}