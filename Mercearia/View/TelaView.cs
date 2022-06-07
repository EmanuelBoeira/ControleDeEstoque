using System;

namespace Mercearia.View
{
    public class TelaView
    {
        public TelaView()
        {

        }

        public static void Menu()
        {
            bool aux = true;

            while (aux)
            {
                Console.WriteLine("Escolha uma das opções:\n 1 - Clientes\n 2 - Fornecedores\n 3 - Estoque\n 4 - sair");
                char resposta = Console.ReadLine()[0];

                switch (resposta)
                {
                    case '1': TelaView.MenuClientes(); break;
                    case '2': TelaView.MenuFornecedores(); break;
                    case '3': TelaView.MenuEstoque(); break;
                    case '4': aux = false; break;

                    default : Console.WriteLine("valor inválido, tente novamente."); break;
                }

            }
        }

        public static void MenuClientes()
        {
            bool aux = true;

            while (aux)
            {
                Console.WriteLine("Escolha uma das opções:\n 1 - Adicionar Clientes\n 2 - Editar registro de cliente\n 3 - Excluir registro de cliente\n 4 - Mostrar todos os clientes\n 5 - Mostrar cliente por CPF\n 6 - voltar");
                char resposta = Console.ReadLine()[0];

                switch (resposta)
                {
                    case '1':  break;
                    case '2':  break;
                    case '3':  break;
                    case '4': break;
                    case '5': break;
                    case '6': aux = false; break;

                    default: Console.WriteLine("valor inválido, tente novamente."); break;
                }

            }
        }

        public static void MenuFornecedores()
        {
            bool aux = true;

            while (aux)
            {
                Console.WriteLine("Escolha uma das opções:\n 1 - Adicionar Fornecedor\n 2 - Editar registro de Fornecedores\n 3 - Excluir registro de Fornecedores\n 4 - Mostrar todos os Fornecedores\n 5 - Mostrar Fornecedor por CPF\n 6 - voltar");
                char resposta = Console.ReadLine()[0];

                switch (resposta)
                {
                    case '1': break;
                    case '2': break;
                    case '3': break;
                    case '4': break;
                    case '5': break;
                    case '6': aux = false; break;

                    default: Console.WriteLine("valor inválido, tente novamente."); break;
                }

            }
        }

        public static void MenuEstoque()
        {
            bool aux = true;

            while (aux)
            {
                Console.WriteLine("Escolha uma das opções:\n 1 - Adicionar Produto\n 2 - Editar registro de Produtos\n 3 - Excluir registro de Produtos\n 4 - Mostrar todos os Produtos\n 5 - Mostrar Produto por CPF\n 6 - voltar");
                char resposta = Console.ReadLine()[0];

                switch (resposta)
                {
                    case '1': break;
                    case '2': break;
                    case '3': break;
                    case '4': break;
                    case '5': break;
                    case '6': aux = false; break;

                    default: Console.WriteLine("valor inválido, tente novamente."); break;
                }

            }
        }
    }
}
