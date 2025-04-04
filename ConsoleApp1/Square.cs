using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Square : Rectangle
    {
       
        public Square(double side) : base(side, side)
        {
            base.Name = "Square"; 
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"This is a square with side length: {Side1}");
        }
    }
}
