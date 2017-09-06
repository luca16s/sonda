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
            var initialPosition = Console.ReadLine().ToUpper();

            Console.WriteLine("Insira a direção para movimentar a sonda");
            var direction = Console.ReadLine().ToUpper();

            
            IMovementable movement = new Sonda();
            var x = initialPosition.Substring(0, 1);
            var y = initialPosition.Substring(1, 1);
            var position = initialPosition.Substring(2, 1);

            (int, int, string) value;

            value = movement.North(position, x, y, direction);
            value = movement.South(position, x, y, direction);
            value = movement.East(position, x, y, direction);
            value = movement.West(position, x, y, direction);

            Console.WriteLine($"{value.Item1} {value.Item2} {value.Item3}");
            Console.ReadLine();
        }
    }
}
