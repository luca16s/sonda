using System;
using System.Collections.Generic;
using System.Text;

namespace sonda
{
    public interface IMovementable
    {
        string Direction(string position);
        (int, int, string) North(string position, string x, string y, string directionToGo);
        (int, int, string) South(string position, string x, string y, string directionToGo);
        (int, int, string) West(string position, string x, string y, string directionToGo);
        (int, int, string) East(string position, string x, string y, string directionToGo);
    }
}
