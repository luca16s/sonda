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
            var position = initialPosition.Substring(2, 1);

            if (initialPosition.Substring(2, 1) == "N")
                for (var i = 0; i < direction.Length; i++)
                {
                    switch (direction.Substring(i, 1))
                    {
                        case "R":
                            x = Convert.ToInt32(initialPosition.Substring(0, 1)) + 1;
                            y = Convert.ToInt32(initialPosition.Substring(1, 1));
                            position = position + "R";
                            break;
                        case "L":
                            x = Convert.ToInt32(initialPosition.Substring(0, 1)) - 1;
                            y = Convert.ToInt32(initialPosition.Substring(1, 1));
                            position = position + "L";
                            break;
                        case "M":
                            x = Convert.ToInt32(initialPosition.Substring(0, 1));
                            y = Convert.ToInt32(initialPosition.Substring(1, 1)) + 1;
                            if (position == "NLLLL")
                            {
                                position = "N";
                            }
                            else
                            {
                                position = position == "NRRRR" ? "S" : position.Substring(position.Length - 1, 1);
                            }
                            break;
                    }
                }
            else if (initialPosition.Substring(2, 1) == "S")
            {
                for (var i = 0; i < direction.Length; i++)
                {
                    switch (direction.Substring(i, 1))
                    {
                        case "R":
                        {
                            x = Convert.ToInt32(initialPosition.Substring(0, 1)) + 1;
                            y = Convert.ToInt32(initialPosition.Substring(1, 1));
                            position = "R";
                            break;
                        }
                        case "L":
                        {
                            x = Convert.ToInt32(initialPosition.Substring(0, 1)) - 1;
                            y = Convert.ToInt32(initialPosition.Substring(1, 1));
                            position = "L";
                            break;
                        }
                        case "M":
                        {
                            x = Convert.ToInt32(initialPosition.Substring(0, 1));
                            y = Convert.ToInt32(initialPosition.Substring(1, 1)) - 1;
                            if (position == "NLLLL")
                            {
                                position = "N";
                            }
                            else
                            {
                                position = position == "NRRRR" ? "S" : position.Substring(position.Length - 1, 1);
                            }
                            break;
                        }
                    }
                }
            }
            else if (initialPosition.Substring(2, 1) == "E")
            {
                for (var i = 0; i < direction.Length; i++)
                {
                    switch (direction.Substring(i, 1))
                    {
                        case "R":
                        {
                            x = Convert.ToInt32(initialPosition.Substring(0, 1));
                            y = Convert.ToInt32(initialPosition.Substring(1, 1)) + 1;
                            if (position.Contains("RR"))
                                y = Convert.ToInt32(initialPosition.Substring(1, 1)) + 2;
                            position = "R";
                            break;
                        }
                        case "L":
                        {
                            x = Convert.ToInt32(initialPosition.Substring(0, 1));
                            y = Convert.ToInt32(initialPosition.Substring(1, 1)) - 1;
                            if (position.Contains("LL"))
                                y = Convert.ToInt32(initialPosition.Substring(1, 1)) - 2;
                            position = "L";
                            break;
                        }
                        case "M":
                        {
                            x = Convert.ToInt32(initialPosition.Substring(0, 1)) - 1;
                            y = Convert.ToInt32(initialPosition.Substring(1, 1));
                            if (position == "NLLLL")
                            {
                                position = "N";
                            }
                            else
                            {
                                position = position == "NRRRR" ? "S" : position.Substring(position.Length - 1, 1);
                            }
                            break;
                        }
                    }
                }
            }
            else if (initialPosition.Substring(2, 1) == "R")
            {
                for (var i = 0; i < direction.Length; i++)
                {
                    switch (direction.Substring(i, 1))
                    {
                        case "R":
                        {
                            x = Convert.ToInt32(initialPosition.Substring(0, 1));
                            y = Convert.ToInt32(initialPosition.Substring(1, 1)) - 1;
                            position = "R";
                            break;
                        }
                        case "L":
                        {
                            x = Convert.ToInt32(initialPosition.Substring(0, 1));
                            y = Convert.ToInt32(initialPosition.Substring(1, 1)) + 1;
                            position = "L";
                            break;
                        }
                        case "M":
                        {
                            x = Convert.ToInt32(initialPosition.Substring(0, 1)) + 1;
                            y = Convert.ToInt32(initialPosition.Substring(1, 1));
                            if (position == "NLLLL")
                            {
                                position = "N";
                            }
                            else
                            {
                                position = position == "NRRRR" ? "S" : position.Substring(position.Length - 1, 1);
                            }
                            break;
                        }
                    }
                }
            }

            Console.WriteLine($"{x} - {y} - {position}");
            Console.ReadLine();
        }
    }
}
