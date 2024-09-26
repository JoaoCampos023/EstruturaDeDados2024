using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_07___ATV
{
    public class Estoque
    {
        private Dictionary<string, Produto> produtos = new Dictionary<string, Produto>();

        public void AdicionarProduto(Produto produto)
        {
            produtos[produto.Barcode] = produto;
        }

        public Produto BuscarProduto(string barcode)
        {
            produtos.TryGetValue(barcode, out Produto produto);
            return produto;
        }
    }
}