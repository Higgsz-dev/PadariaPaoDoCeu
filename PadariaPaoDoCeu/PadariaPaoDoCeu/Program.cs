using System;
using System.Globalization;

namespace PadariaPaoDoCeu
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            {
                int cod_prod, cod_prod1, cod_prod2, cod_prod3;
                double valor_prod1, valor_prod2, valor_prod3, valor_venda;
                string nome_prod1, nome_prod2, nome_prod3;
                int estoque_prod1, estoque_prod2, estoque_prod3;
                int cont1, cont2, cont3;
                double valor_prod, total_venda;

                valor_prod = 0;
                total_venda = 0;

                //Produto 1
                nome_prod1 = "Pão";
                cod_prod1 = 1;
                valor_prod1 = 3.5;
                //


                //Produto 2
                nome_prod2 = "Leite";
                cod_prod2 = 2;
                valor_prod2 = 2.5;
                //

                //Produto 3
                nome_prod3 = "Manteiga";
                cod_prod3 = 3;
                valor_prod3 = 4.9;
                //


                cont1 = 0;
                cont2 = 0;
                cont3 = 0;

                Console.WriteLine("Digite o codigo do produto");
                cod_prod = int.Parse(Console.ReadLine());

                while (cod_prod != 0)
                {
                    //Adicionando O Produto 1 a venda
                    if (cod_prod == 1)
                    {

                        Console.WriteLine("Produto: " + nome_prod1);
                        Console.WriteLine("Código: " + cod_prod1);
                        Console.WriteLine("Preço: " + valor_prod1);
                        cont1 = cont1 + 1;
                        total_venda = total_venda + valor_prod1;
                        Console.WriteLine("Vendidos: " + cont1);
                        Console.WriteLine("Sub total: " + total_venda);
                    }

                    //Adicionando o Produto 2 a venda
                    if (cod_prod == 2)
                    {

                        Console.WriteLine("Produto: " + nome_prod2);
                        Console.WriteLine("Código: " + cod_prod2);
                        Console.WriteLine("Preço: " + valor_prod2);
                        cont1 = cont1 + 1;
                        total_venda = total_venda + valor_prod2;
                        Console.WriteLine("Vendidos: " + cont2);
                        Console.WriteLine("Sub total: " + total_venda);
                    }

                    //Adicionando o Produto 3 a venda
                    if (cod_prod == 3)
                    {

                        Console.WriteLine("Produto: " + nome_prod3);
                        Console.WriteLine("Código: " + cod_prod3);
                        Console.WriteLine("Preço: " + valor_prod3);
                        cont1 = cont1 + 1;
                        total_venda = total_venda + valor_prod3;
                        Console.WriteLine("Vendidos: " + cont3);
                        Console.WriteLine("Sub total: " + total_venda);
                    }

                    Console.WriteLine("Digite o codigo do produto");
                    cod_prod = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Valor total: " + total_venda);
            }
            
            
            
            Console.ReadKey();
        }
    }
}
