using System;
using System.Collections.Generic;
using System.Text;

namespace sonda
{
    public class Sonda: IMovementable
    {
        public Sonda()
        {
        }

        public Sonda(string initialValues)
        {
            XPosition = Convert.ToInt32(initialValues.Substring(0, 1));
            YPosition = Convert.ToInt32(initialValues.Substring(1, 1));
            Position = Convert.ToChar(initialValues.Substring(2, 1));
            
        }

        public int XPosition
        {
            get;
        }

        public int YPosition
        {
            get;
        }

        public char Position
        {
            get;
        }

        public int plateuSize
        {
            get;
        }


        public void Calculo()
        {
            throw new NotImplementedException();
        }
    }
}
