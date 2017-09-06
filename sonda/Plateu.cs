using System;
using System.Collections.Generic;
using System.Text;

namespace sonda
{
    public class Plateu
    {
        public int X { get; }
        public int Y { get; }
        public int[,] matrizPlateu;

        public Plateu(string plateuSize)
        {
            X = Convert.ToInt32(plateuSize.Substring(0, 1));
            Y = Convert.ToInt32(plateuSize.Substring(1, 1));
            matrizPlateu = new int[X, Y];
        }
    }
}
