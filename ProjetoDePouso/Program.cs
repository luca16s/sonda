using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sonda;

namespace ProjetoDePouso
{
    internal static class ControlaImpressaoAsync
    {
        private static void Main(string[] args)
        {
            var plateuSize = "";
            var initialPosition = new List<string>();
            var x = new List<string>();
            var y = new List<string>();
            var position = new List<string>();
            var direction = new List<string>();
            IMovementable sondaA = new Sonda();
            IMovementable sondaB = new Sonda();
            (int, int, string) valueSondaA = (0, 0, null);
            (int, int, string) valueSondaB = (0, 0, null);

            Console.Title = "NASA - Programa Espacial";
            Console.WriteLine("Insira as Coordenadas do Ponto Superior Direito: ");
            plateuSize = Console.ReadLine();

            Console.WriteLine("Insira a posição inicial das sondas: ");
            initialPosition.Add(Console.ReadLine().ToUpper());
            initialPosition.Add(Console.ReadLine().ToUpper());

            if (initialPosition.Count != 3)
            {
                initialPosition.RemoveRange(0, 1);
                initialPosition.Add(Console.ReadLine().ToUpper());
            }
            if (initialPosition.Count != 3)
            {
                initialPosition.RemoveRange(1, 1);
                initialPosition.Add(Console.ReadLine().ToUpper());
            }

            x.Add(initialPosition[0].Substring(0, 1));
            y.Add(initialPosition[0].Substring(1, 1));
            x.Add(initialPosition[1].Substring(0, 1));
            y.Add(initialPosition[1].Substring(1, 1));

            if (Convert.ToInt32(x[0]) > Convert.ToInt32(plateuSize.Substring(0, 1)) ||
                Convert.ToInt32(y[0]) > Convert.ToInt32(plateuSize.Substring(1, 1)))
            {
                initialPosition.RemoveRange(0, 1);
                Console.WriteLine(
                    "Reinsira a posição inicial, a mesma não pode ser maior que o tamanho do planalto: ");
                initialPosition.Add(Console.ReadLine().ToUpper());
            }
            if (Convert.ToInt32(x[1]) > Convert.ToInt32(plateuSize.Substring(0, 1)) ||
                Convert.ToInt32(y[1]) > Convert.ToInt32(plateuSize.Substring(1, 1)))
            {
                initialPosition.RemoveRange(1, 1);
                Console.WriteLine(
                    "Reinsira a posição inicial, a mesma não pode ser maior que o tamanho do planalto: ");
                initialPosition.Add(Console.ReadLine().ToUpper());
            }

            position.Add(initialPosition[0].Substring(2, 1));
            position.Add(initialPosition[1].Substring(2, 1));

            if (initialPosition.Count == 2)
            {
                Console.WriteLine("Insira a direção para movimentar a sonda");
                direction.Add(Console.ReadLine().ToUpper());
                direction.Add(Console.ReadLine().ToUpper());
            }
            valueSondaA = ImpressaoAsync(valueSondaA, sondaA, position, x, y, direction, 0).Result;
            valueSondaB = ImpressaoAsync(valueSondaB, sondaB, position, x, y, direction, 1).Result;
            Console.WriteLine("A posição da sonda passou a ser:");
            Console.WriteLine($"{valueSondaA.Item1} {valueSondaA.Item2} {valueSondaA.Item3}");
            Console.WriteLine($"{valueSondaB.Item1} {valueSondaB.Item2} {valueSondaB.Item3}");
            Console.ReadLine();
        }

        private static (int, int, string) MostraPosicao((int, int, string) valueSonda, IMovementable sonda, IReadOnlyList<string> position, IReadOnlyList<string> x, List<string> y, IReadOnlyList<string> direction, int controller)
        {
            valueSonda = sonda.North(position[controller], x[controller], y[controller], direction[controller]);
            valueSonda = sonda.South(position[controller], x[controller], y[controller], direction[controller]);
            valueSonda = sonda.East(position[controller], x[controller], y[controller], direction[controller]);
            valueSonda = sonda.West(position[controller], x[controller], y[controller], direction[controller]);
            return valueSonda;
        }

        private static async Task<(int, int, string)> ImpressaoAsync((int, int, string) valueSonda, IMovementable sonda,
            List<string> position, List<string> x, List<string> y, List<string> direction, int controller)
        {
            var value = await Task.Run(() => MostraPosicao(valueSonda, sonda, position, x, y, direction, controller));
            return value;
        }
    }
}