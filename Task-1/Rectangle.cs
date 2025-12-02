using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Rectangle
    {
        private double length;
        private double breadth;

        public double Length
        {
            get => length;
            set => length = value;
        }
        public double Breadth
        {
            get => breadth;
            set => breadth = value;
        }

        public double GetArea() => length*breadth;
        
        public String ShowDetails() => $"Length:{length}, Breadth:{breadth}";

        public double GetPerimeter() => 2 * (length + breadth);
        

    }
}
