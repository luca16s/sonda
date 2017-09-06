using System;
using System.Collections.Generic;
using System.Text;

namespace sonda
{
    public interface IMovementable
    {
        string Direction(string position);
        (int, int, string) North(string position, string x, string y, string directionToGo);
        void South(string position, string x, string y, string directionToGo);
        void West(string position, string x, string y, string directionToGo);
        void East(string position, string x, string y, string directionToGo);
    }
}
