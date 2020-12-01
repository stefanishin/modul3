using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{

    public partial class Student
    {
        public static int age = 17; //стат поле возраст 

        public static string st = "";// стат поле заочник дневник
        private string name; //имя
        private string fam;
        private double sr_ball;
        private string gr;

        // методы доступа к закрытым полям
        public string Name { get; set; }
        public string Fam { get; set; }
        public double Sr_ball { get; set; }
        public string Gr { get; set; }
        public Student(string name, string fam, double sr_ball, string gr)
        {
            Name = name;
            Fam = fam;
            Sr_ball = sr_ball;
            Gr = gr;
        }
        // доступ к стат полям
        public static int Age
        {
            get { return age; }
            set { if (value > 15) age = value; }
        }
        public static string St { get; set; }

        //конструкторы  по умолчанию и перегруженные
        public Student()
        { }
        public Student(string name)
        {
            this.name = name;
        }
        public Student(string name, string fam) : this(name)
        {
            this.fam = fam;
        }

        public Student(string name, string fam, double sr_ball) : this(name, fam)
        {
            this.sr_ball = sr_ball;
        }
        //стат конструктор
        static Student()
        {
            Age = age;
            St = st;
        }
        // методы
        partial void GetInfo(); //вывод инфы
        public void GetInfo1()
        {
            GetInfo();
            Console.WriteLine();
        }

        public void InputInfo() //ввод инфы
        {
            Console.WriteLine("Ввод имени - ");
            string name1 = Console.ReadLine();
            Name = name1;

            Console.WriteLine("Ввод фамилии - ");
            string fam1 = Console.ReadLine();
            Fam = fam1;

            Console.WriteLine("средний балл - ");
            double sr_ball1 = Convert.ToDouble(Console.ReadLine());
            Sr_ball = sr_ball1;

            Console.WriteLine("группа- ");
            string gr1 = Console.ReadLine();
            Gr = gr1;

            Console.WriteLine("cтатус - ");
            string st1 = Console.ReadLine();
            St = st1;

            Console.WriteLine("возраст - ");
            int age1 = Convert.ToInt32(Console.ReadLine());
            Age = age1;
        }
        //методы со ссылками
        public void EditLine(ref string n) // входная 
        {
            n = Name;
        }
        public void EditLine2(out string n)// выходная
        {
            n = Name;
        }

    }
}