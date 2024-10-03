using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conrole_de_Estoque
{
    internal class Program
    {
        static void Main(string[] args)

        {
            bool on = true;
            List<produto> list = new List<produto>();

            while (on)
            {
                Console.WriteLine("[1] Adicionar Produto ");
                Console.WriteLine("[2] Remover produto ");
                Console.WriteLine("[3] Atualizar Produto ");
                Console.WriteLine("[4] Listar todos os produtos ");
                Console.WriteLine("[5] Buscar produto por código ");
                Console.WriteLine("[6] Sair ");
                Console.WriteLine("=====");
                Console.Write("Selecione uma Opção: ");
                int opc = int.Parse(Console.ReadLine());
                Console.WriteLine("=====");
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Vamos adicionar seu produto ");
                         Console.Write("Nome: ");
                         string nome = Console.ReadLine();

                        Console.Write("Preço: ");
                        double preco = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

                        Console.Write("Código do Produto: ");
                        int codigo = int.Parse(Console.ReadLine());

                        list.Add(new produto(nome, preco, codigo));
                        
                        Console.WriteLine("Produto adicionado com sucesso!!!");
                        Console.WriteLine("===");
                        break;

                     case 2:
                        Console.Write("Informe o codigo do produto que deseja remover: ");
                        int cod = int.Parse(Console.ReadLine());
                        Console.WriteLine("===");

                        produto codigoP = list.Find(x => x.CodigoProduto == cod);

                        if(codigoP == list.FirstOrDefault())
                        {                              
                           list.Remove(codigoP);
                           Console.WriteLine("Produto Removido com Sucesso!!!");
                            Console.WriteLine("===");
                        }
                        else
                        {
                            Console.WriteLine("Produto não encontrado!");
                            Console.WriteLine("===");
                        }
                        
                      break;
                     case 3:
                        Console.WriteLine("===");
                        Console.WriteLine("Informe o cod do produto que deseja atualizar: ");
                        int codf = int.Parse(Console.ReadLine());

                        produto codigoPf = list.FirstOrDefault(x => x.CodigoProduto == codf);

                        if (codigoPf != null)
                        {
                            Console.WriteLine("Quantos items deseja adionar: ");
                            int qAtt = int.Parse(Console.ReadLine());
                            Console.WriteLine("===");

                            codigoPf.AtualizarQuantiade(qAtt);
                            Console.WriteLine("Quantidade atualizada com sucesso!");
                            Console.WriteLine("===");
                        }
                        else
                        {
                            Console.WriteLine("Produto não encontrado!");
                            Console.WriteLine("===");
                        }
                        break;

                     case 4:
                        if (list != null && list.Count > 0)
                        {
                            foreach (produto produto in list)
                            {
                                Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco}, Código: {produto.CodigoProduto}, Quantidade: {produto.QuantidadeEstoque}");
                                Console.WriteLine("===");
                            }
                        }
                        else
                        {
                            Console.WriteLine("A lista está vazia!");
                            Console.WriteLine("===");
                        }
                        break;

                     case 5:

                        Console.WriteLine("Informe o cod do produto que deseja localizar: ");
                        int codl = int.Parse(Console.ReadLine());

                        produto codigol = list.FirstOrDefault(x => x.CodigoProduto == codl);

                        if (codigol == list.FirstOrDefault())
                        {
                            Console.WriteLine($"Nome: {codigol.Nome}, Preço: {codigol.Preco}, Código: {codigol.CodigoProduto}, Quantidade: {codigol.QuantidadeEstoque}");
                            Console.WriteLine("===");
                        }
                        else
                        {
                            Console.WriteLine("Produto não encontrado!");
                            Console.WriteLine("===");
                        }
                        break;
                     case 6:
                        Console.WriteLine("===");
                        Console.WriteLine("Encerrando.....");
                        on = false;
                        break;

                }
            }
        }
    }
}
    