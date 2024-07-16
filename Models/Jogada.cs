using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Jokenpo.Models
{
    public class Jogada
    {
            public int valor { get; set; }
    // estou usando o encapsulamento para proteger de alterações internas para que possa ser feitas validações antes de atribuir um valor
  
        // como não existe nenhuma variável "_valor", ele vai buscar o atributo da classe e armazenar o valor nela
        //criando uma instancia da minha classe jogada, e os valores que vou passar como argumento estão nas classes filhas
        public Jogada(int valor)
        {
            //atribui o valor passado como parametro durante a criação do objeto que é a instancia da minha classe
            this.valor = valor;
        }
  

    //retorna false pois aqui não vai comparar nenhuma jogada, vai apenas servir para as classes filhas sobrescreverem o metodo
        public virtual bool PerdePara(Jogada outraJogada) 
        {
            return false;
        }

    }
    
}
    