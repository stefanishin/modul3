using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_struct
{
    struct MenuFood
    {
        private string ;
        private string ;
        private string ;
        private string ;
        private string ;

            public 


    
        public MenuFood(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public void Print()
        {
            Console.WriteLine($"Длина {Length}, ширина {Width}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double length = 7.342,
                  width = 23.49;
            Dimensions dimensions = new Dimensions(length, width);
            dimensions.Print();
        }
    }
}
