using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conrole_de_Estoque
{
     class produto
    {
        public string Nome { get;  set; }
        public double Preco { get;  set; }
        public int QuantidadeEstoque { get;  set; }  
        public int CodigoProduto { get;  set; }


        public produto(string nome, double preco, int codigoproduto) 
        {
            Nome = nome;
            Preco = preco;
            CodigoProduto = codigoproduto;
            QuantidadeEstoque = 10;
        }


        public void AdicionarProduto(string nome, double preco, int codigoproduto)
        {
            Nome = nome;
            Preco = preco;
            CodigoProduto = codigoproduto;       
        }

        public void AtualizarQuantiade(int quantidade)
        {
            QuantidadeEstoque +=  quantidade;
        }

        public override string ToString()
        {
            return Nome + "," + Preco + "," + QuantidadeEstoque + ",";
        }
    }
}
