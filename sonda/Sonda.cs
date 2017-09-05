using System;

namespace sonda
{
    public class Sonda
    {
        public Sonda(int yCoordinate, char direction, int xCoordinate)
        {
            this._yCoordinate = yCoordinate;
            this._direction = direction;
            this._xCoordinate = xCoordinate;
        }

        private readonly int _xCoordinate;
        public int XCoordinate { get; set; }

        private readonly int _yCoordinate;
        private int YCoordinate { get; set; }

        private readonly char _direction;
        private char Direction { get; set; }
    }
}
