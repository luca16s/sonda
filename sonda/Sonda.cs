using System;
using System.Collections.Generic;
using System.Text;

namespace sonda
{
    public class Sonda: IMovementable
    {
        public int X { get; set; }
        public int Y { get; set; }

        //private string Position { get; set; }
        public string Direction(string position)
        {
            return position;
        }

        public (int, int, string) North(string position, string x, string y, string directionToGo)
        {
            if (position == "N")
            {
                for (var i = 0; i < directionToGo.Length; i++)
                {
                    switch (directionToGo.Substring(i, 1))
                    {
                        case "R":
                            X = Convert.ToInt32(x) + 1;
                            Y = Convert.ToInt32(y);
                            Direction("R");
                            break;
                        case "L":
                            X = Convert.ToInt32(x) - 1;
                            Y = Convert.ToInt32(y);
                            Direction("L");
                            break;
                        case "M":
                            X = Convert.ToInt32(x);
                            Y = Convert.ToInt32(y) + 1;
                            if (position == "NLLLL")
                            {
                                Direction("N");
                                return (X, Y, position);
                            }
                            else
                            {
                                position = position == "NRRRR" ? Direction("S") : Direction(position.Substring(position.Length - 1, 1));
                            }
                            break;
                    }
                }
                return (X, Y, position);
            }
            return (X, Y, position);
        }

        public (int, int, string) South(string position, string x, string y, string directionToGo)
        {
            if (position == "S")
            {
                for (var i = 0; i < directionToGo.Length; i++)
                {
                    switch (directionToGo.Substring(i, 1))
                    {
                        case "R":
                        {
                            X = Convert.ToInt32(x) + 1;
                            Y = Convert.ToInt32(y);
                            Direction("R");
                            break;
                        }
                        case "L":
                        {
                            X = Convert.ToInt32(x) - 1;
                            Y = Convert.ToInt32(y);
                            Direction("L");
                            break;
                        }
                        case "M":
                        {
                            X = Convert.ToInt32(x);
                            Y = Convert.ToInt32(y) - 1;
                            if (position == "NLLLL")
                            {
                                Direction("N");
                            }
                            else
                            {
                                position = position == "NRRRR" ? Direction("S") : Direction(position.Substring(position.Length - 1, 1));
                            }
                            break;
                        }
                    }
                }
                return (X, Y, position);
            }
            return (X, Y, position);
        }

        public (int, int, string) West(string position, string x, string y, string directionToGo)
        {
            if (position == "E")
            {
                for (var i = 0; i < directionToGo.Length; i++)
                {
                    switch (directionToGo.Substring(i, 1))
                    {
                        case "R":
                        {
                            X = Convert.ToInt32(x);
                            Y = Convert.ToInt32(y) + 1;
                            Direction("R");
                            break;
                        }
                        case "L":
                        {
                            X = Convert.ToInt32(x);
                            Y = Convert.ToInt32(y) - 1;
                            Direction("L");
                            break;
                        }
                        case "M":
                        {
                            X = Convert.ToInt32(x) - 1;
                            Y = Convert.ToInt32(y);
                            if (position == "NLLLL")
                            {
                                Direction("N");
                            }
                            else
                            {
                                position = position == "NRRRR"
                                    ? Direction("S")
                                    : Direction(position.Substring(position.Length - 1, 1));
                            }
                            break;
                        }
                    }
                }
                return (X, Y, position);
            }
            return (X, Y, position);
        }

        public (int, int, string) East(string position, string x, string y, string directionToGo)
        {
            if (position == "R")
            {
                for (var i = 0; i < directionToGo.Length; i++)
                {
                    switch (directionToGo.Substring(i, 1))
                    {
                        case "R":
                        {
                            X = Convert.ToInt32(x);
                            Y = Convert.ToInt32(y) - 1;
                            Direction("R");
                            break;
                        }
                        case "L":
                        {
                            X = Convert.ToInt32(x);
                            Y = Convert.ToInt32(y) + 1;
                            Direction("L");
                            break;
                        }
                        case "M":
                        {
                            X = Convert.ToInt32(x) + 1;
                            Y = Convert.ToInt32(y);
                            if (position == "NLLLL")
                            {
                                Direction("N");
                            }
                            else
                            {
                                position = position == "NRRRR" ? Direction("S") : Direction(position.Substring(position.Length - 1, 1));
                            }
                            break;
                        }
                    }
                }
                return (X, Y, position);
            }
            return (X, Y, position);
        }

    }
}
