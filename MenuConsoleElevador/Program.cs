using System;
using System.Threading;
using MenuConsoleElevador.Model;

namespace MenuConsoleElevador
{
    internal class Program
    {
        static void Main()
        {
            bool continuar = true;
            string opcaoEscolhida;
            ElevadorModel elevador = new ElevadorModel();

            do
            {
                Console.Clear();        // limpa a tela de console
                Console.WriteLine(@"Projeto Final - Gerenciamento do Elevador

  1- Entrar no elevador
  2- Subir Andar
  3- Descer Andar 
  4- Sair do Elevador
  5- Sair da aplicação
            ");
                Console.Write("Escolha uma opção: ");
                opcaoEscolhida = Console.ReadLine();
               
                switch (opcaoEscolhida)
                {
                    case "1": elevador.Entrar(); break;
                    case "2": elevador.Subir(); break;
                    case "3": elevador.Descer(); break;
                    case "4": elevador.Sair(); break;
                    case "5": continuar = false; break;
                    default: Console.WriteLine("Opção inválida!"); break;
                };
               
                Thread.Sleep(1500);
            } while (continuar);
            Console.WriteLine("Sair da aplicaçao");
        }
    }   // class program
}  // namespace
