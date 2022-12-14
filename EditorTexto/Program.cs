using System;
using System.IO;
using System.Threading;

namespace EditorTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Editor de Texto");
            Console.WriteLine("");
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("");
            Console.WriteLine("1 - Abrir Arquivo");
            Console.WriteLine("2 - Criar Novo Arquivo");        
            Console.WriteLine("0 - Sair");
            Console.WriteLine("");
            short opcaoSelecionada = short.Parse(Console.ReadLine());

            switch(opcaoSelecionada)
            {
                case 0: Sair(); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default : Menu(); break;
            }
        }

        static void Abrir()         
        {
            Console.Clear();
            Console.WriteLine("Abrir arquivo de Texto");
            Console.WriteLine("");
            Console.WriteLine("Qual o Caminho do arquivo?: ");
            Console.WriteLine("");
            string caminho = Console.ReadLine();

            string arquivoAberto = File.ReadAllText(caminho);
            Console.WriteLine(arquivoAberto);

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Editar() 
        {
            Console.Clear();
            Console.WriteLine("Criação de Texto");
            Console.WriteLine("");
            Console.WriteLine("Pressione ESC para Sair");
            Console.WriteLine("");
            Console.WriteLine("Digite seu texto abaixo: ");
            Console.WriteLine("");
            string textoDigitado = "";

            do
            {
                textoDigitado += Console.ReadLine();
                textoDigitado += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(textoDigitado);
        }

        static void Salvar(string textoEditado)
        {
            Console.Clear();
            Console.WriteLine(" Onde deseja salvar o arquivo?: ");
            Console.WriteLine("");
            var caminho = Console.ReadLine();

            File.WriteAllText(caminho, textoEditado);

            Console.WriteLine($"Arquivo {caminho} Salvo com sucesso!");
            Thread.Sleep(2000);
            Menu();
        }

        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Obrigado! Volte Sempre.");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }
}
