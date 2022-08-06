using System;
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
            short opcaoSelecionada = short.Parse(Console.ReadLine());

            switch(opcaoSelecionada)
            {
                case 0: Sair(); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
            }
        }

        static void Abrir()         
        {
        
        }
        static void Editar() 
        {

        }
        static void Sair()
        {

        }

    }

}
