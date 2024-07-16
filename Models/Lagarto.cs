using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jokenpo.Models
{
    public class Lagarto : Jogada
    {
        // a base serve para chamar o construtor da classe pai, o valor é passado como argumento para o campo "valor" que criei na classe pai para definir qual escolha da jogada
        public Lagarto() : base (4)
        {

        }
         // qlqr coisa diferente de void precisa de um return
        public override bool PerdePara(Jogada outraJogada)
        {
            return outraJogada is Tesoura || outraJogada is Pedra;
        }

    }
}