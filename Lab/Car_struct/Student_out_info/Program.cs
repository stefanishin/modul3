using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_info_out
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student();
            Student stud2 = new Student();
            Console.WriteLine("ввод информации");
            stud1.InputInfo();
            Console.WriteLine("вывод информации");
            stud1.GetInfo1();

            Console.WriteLine("ввод информации");
            stud2.InputInfo();
            Console.WriteLine("вывод информации");
            stud2.GetInfo1();

            Console.WriteLine();
            string s1 = "";
            string s = "";
            s = stud1.Name;
            stud1.EditLine(ref s);
            Console.WriteLine("Work - ref - " + s);
            stud2.EditLine2(out s1);
            Console.WriteLine("Work - out - " + s1);
        }
    }
}