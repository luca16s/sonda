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

            var x = 0;
            var y = 0;
            string[] position = new string[direction.Length];

            if (initialPosition.Substring(2, 1) == "N")
            {
                for (var i = 0; i < direction.Length; i++)
                {
                    switch (direction.Substring(i, 1))
                    {
                        case "RM":
                        {
                            x = Convert.ToInt32(initialPosition.Substring(0, 1)) + 1;
                            y = Convert.ToInt32(initialPosition.Substring(1, 1));
                            position[i] = "R";
                            break;
                        }
                        case "LM":
                        {
                            x = Convert.ToInt32(initialPosition.Substring(0, 1)) - 1;
                            y = Convert.ToInt32(initialPosition.Substring(1, 1));
                            position[i] = "L";
                                break;
                        }
                        case "M":
                        {
                            x = Convert.ToInt32(initialPosition.Substring(0, 1));
                            y = Convert.ToInt32(initialPosition.Substring(1, 1)) + 1;
                            position[i] = position[i - 1];
                                break;
                        }
                    }
                }
            }
            if (initialPosition.Substring(2, 1) == "S")
            {
                for (var i = 0; i < direction.Length; i++)
                {
                    switch (direction.Substring(i, 1))
                    {
                        case "RM":
                        {
                            x = Convert.ToInt32(initialPosition.Substring(0, 1)) + 1;
                            y = Convert.ToInt32(initialPosition.Substring(1, 1));
                            position[i] = "R";
                                break;
                        }
                        case "LM":
                        {
                            x = Convert.ToInt32(initialPosition.Substring(0, 1)) - 1;
                            y = Convert.ToInt32(initialPosition.Substring(1, 1));
                            position[i] = "R";
                                break;
                        }
                        case "M":
                        {
                            x = Convert.ToInt32(initialPosition.Substring(0, 1));
                            y = Convert.ToInt32(initialPosition.Substring(1, 1)) - 1;
                            break;
                        }
                    }
                }
            }
            if (initialPosition.Substring(2, 1) == "E")
            {
                for (var i = 0; i < direction.Length; i++)
                {
                    switch (direction.Substring(i, 1))
                    {
                        case "RM":
                        {
                            x = Convert.ToInt32(initialPosition.Substring(0, 1));
                            y = Convert.ToInt32(initialPosition.Substring(1, 1)) + 1;
                            position[i] = "R";
                                break;
                        }
                        case "LM":
                        {
                            x = Convert.ToInt32(initialPosition.Substring(0, 1));
                            y = Convert.ToInt32(initialPosition.Substring(1, 1)) - 1;
                            position[i] = "R";
                                break;
                        }
                        case "M":
                        {
                            x = Convert.ToInt32(initialPosition.Substring(0, 1)) - 1;
                            y = Convert.ToInt32(initialPosition.Substring(1, 1));
                            break;
                        }
                    }
                }
            }
            if (initialPosition.Substring(2, 1) == "R")
            {
                for (var i = 0; i < direction.Length; i++)
                {
                    switch (direction.Substring(i, 1))
                    {
                        case "RM":
                        {
                            x = Convert.ToInt32(initialPosition.Substring(0, 1));
                            y = Convert.ToInt32(initialPosition.Substring(1, 1)) - 1;
                            position[i] = "R";
                                break;
                        }
                        case "LM":
                        {
                            x = Convert.ToInt32(initialPosition.Substring(0, 1));
                            y = Convert.ToInt32(initialPosition.Substring(1, 1)) + 1;
                            position[i] = "R";
                                break;
                        }
                        case "M":
                        {
                            x = Convert.ToInt32(initialPosition.Substring(0, 1)) + 1;
                            y = Convert.ToInt32(initialPosition.Substring(1, 1));
                            break;
                        }
                    }
                }
            }
            Console.WriteLine($"{x} - {y} - {position[1]}");
            Console.ReadLine();
        }
    }
}
