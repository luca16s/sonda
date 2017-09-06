using System;
using System.Collections.Generic;
using System.Text;

namespace sonda
{
    public class Plateu
    {
        private int X { get; }
        private int Y { get; }
        int[,] matrizPlateu;

        public Plateu(string plateuSize)
        {
            X = Convert.ToInt32(plateuSize.Substring(0, 1));
            Y = Convert.ToInt32(plateuSize.Substring(1, 1));
            matrizPlateu = new int[X, Y];
        }
    }
}
