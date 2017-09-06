using System;
using sonda;

namespace ProjetoDePouso
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira as Coordenadas do Ponto Superior Direito: ");
            var plateuSize = Console.ReadLine();

            Console.WriteLine("Insira a posição inicial: ");
            var initialPosition = Console.ReadLine();

            Console.WriteLine("Insira a direção para movimentar a sonda");
            var direction = Console.ReadLine();

            
            Console.ReadLine();

            var sonda = new Sonda(initialPosition);
            var plateu = new Plateu(plateuSize);

            var sondaYPosition = sonda.YPosition;
            var sondaXPosition = sonda.XPosition;
            var sondaPosition = sonda.Position;
            Console.WriteLine($"Size: {sondaXPosition} {sondaYPosition} {sondaPosition}");

            Console.ReadLine();
        }
    }
}
