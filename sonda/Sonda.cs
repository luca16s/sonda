using System;
using System.Collections.Generic;
using System.Text;

namespace sonda
{
    public class Sonda
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
            set;
        }

        public int YPosition
        {
            get;
            set;
        }

        public char Position
        {
            get;
            set;
        }
    }
}
