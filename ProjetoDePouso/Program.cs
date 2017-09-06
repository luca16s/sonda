using System;

namespace ProjetoDePouso
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira as Coordenadas do Ponto Superior Direito: ");
            string plateuSize = Console.ReadLine();

            Console.WriteLine("Insira a posição inicial: ");
            string initialPosition = Console.ReadLine();

            Console.WriteLine("Insira a direção para movimentar a sonda");
            string direction = Console.ReadLine();
        }
    }
}
