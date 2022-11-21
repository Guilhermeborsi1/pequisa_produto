using System;

namespace Produto
{
    class Program
    {
        static void Main()
        {
            Projeto_Lib.Class1 Pesquisar = new Projeto_Lib.Class1();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("     Diga seu produto   ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("     Como posso ajudar:       ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1- Para pesquisar pelo NOME");
            Console.WriteLine("2- Para pesuisar pelo GRUPO");
            Console.WriteLine("3- Para cadastrar o produto");
            Console.WriteLine("4- Para alterar o produto");
            Console.WriteLine("5- Para excluir o produto");
            Console.WriteLine("6- Para sair");
            string resposta = Console.ReadLine();

            switch (resposta)
            {
                case "1":
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("     Digite o produto que queria encontrar   ");
                    Console.WriteLine("------------------------------------------");
                    string resposta1 = Console.ReadLine();

                    Pesquisar.Listar_Produtos(resposta1);


                    break;

                case "2":
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("     Digite o grupo que queira encontar  ");
                    Console.WriteLine("------------------------------------------");
                    string resposta2 = Console.ReadLine();

                    Pesquisar.Listar_Grupo(resposta2);

                    break;

                case "3":

                    break;

                case "4":

                    break;

                case "5":

                    break;

                case "6":

                    break;

                default:

                    break;
            }



        }

    }
}