using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
    class Produto
    {
        public string nome;
        public double preco;
        public int qtdEstoque;

        public double CalcularTotal()
        {
            return qtdEstoque * preco;
        }
    }
}
