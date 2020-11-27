using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_struct
{
    struct Food
    {
        private string chocolate;
        private string milk;
        private string fish;
        private int IDfood;
        private double sum;

        public Food(string c, string m, string f, int id, int s)
        {
           this.chocolate = c;
           this.milk = m;
           this.fish = f;
           this.IDfood = id;
           this.sum = s;
        }

        public void Print()
        {
            Console.WriteLine($"Шоколад {chocolate}, Молоко {milk}, Рыба {fish}, Номер продукты {IDfood}, сумма {sum}");
        }
    }       
    class Program
    {
        static void Main(string[] args)
        {
            string ch = "Шоколад", m = "Молоко", f = "Рыба"; int id = 0001, price = 200;
            Food fd = new Food(ch, m, f, id, price);

            fd.Print();
            Console.ReadKey();
        }
    }
}
