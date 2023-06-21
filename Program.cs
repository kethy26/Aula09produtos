using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09Produtos
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> produtos = new List<string>() { "Pepsi,""fanta" }
           
             
            Console.WriteLine("Bem-vindo ao Keithy Store");
            Console.WriteLine("Digite 1 para cadastrar ou 2 para listar");
            string resposta = Console.ReadLine();

            if ( resposta == "1")
            {
                Console.WriteLine("Digite nome do produto");
                string produto = Console.ReadLine();
                 
                if (produtos.Contains(produto))
                {
                    Console.WriteLine(" Esse produto já está na lista...");
                }
                else
                {
                    produtos.Add(produto);
                    Console.WriteLine("produto adicionado!");
                }


            }


            else
            {
                string texto = "";
                int contador = 0;

                while(contador < produtos.Count)
                {
                    string nome = produtos[contador]
                    string primeira_letra = nome.Substring(0, 1).Substring ToUpper();
                    string resto = nome.Substring(1, nome.Length Length - 1);
                    string nome_tratado = primeira_letra + resto;


                }

            }


        }
    }
}
