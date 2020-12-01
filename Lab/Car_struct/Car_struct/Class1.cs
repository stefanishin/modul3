using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_out_ref
{
    public partial class Auto
    {
        partial void GetInfo() //вывод инфы
        {
            Console.WriteLine("Наименование - " + Name);
            Console.Write(Color);
            Console.WriteLine($"двигатель - {Dv} привод - {Pr}");
            Console.WriteLine($"коробка передач -   {Kpp}");
            Console.WriteLine($"стоимость -  {Cena}");
        }

    }
}
