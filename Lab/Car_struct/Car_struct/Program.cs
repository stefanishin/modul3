using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_out_ref
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto st1 = new Auto();
            Auto st2 = new Auto();
            Console.WriteLine("Ввод информации");
            st1.InputInfo();
            Console.WriteLine("Вывод информации");
            st1.GetInfo1();

            Console.WriteLine("Ввод информации");
            st2.InputInfo();
            Console.WriteLine("Вывод информации");
            st2.GetInfo1();

            Console.WriteLine();
            string s1 = "";
            string s = "";
            s = st1.Name;
            st1.EditLine(ref s);
            Console.WriteLine("Work - ref - " + s);
            st2.EditLine2(out s1);
            Console.WriteLine("Work - out - " + s1);
        }

    }
}