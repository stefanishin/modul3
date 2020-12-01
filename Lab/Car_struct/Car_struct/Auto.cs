using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_out_ref
{
    public partial class Auto
    {
        public static decimal cena = 100; //стат поле цена 

        public static string kpp = "Avtomat";// стат поле коробка передач
        private string name; //имя
        private string color; //цвет
        private double dv;// объем двигателя
        private string pr;// привод - full front rear

        // методы доступа к закрытым полям
        public string Name { get; set; }
        public string Color { get; set; }
        public double Dv { get; set; }
        public string Pr { get; set; }
        public Auto(string name, string color, double dv, string pr)
        {
            Name = name;
            Color = color;
            Dv = dv;
            Pr = pr;
        }
        // доступ к стат полям
        public static decimal Cena
        {
            get { return cena; }
            set { if (value > 0) cena = value; }
        }
        public static string Kpp { get; set; }

        //конструкторы  по умолчанию и перегруженные
        public Auto()
        { }
        public Auto(string name)
        {
            this.name = name;
        }
        public Auto(string name, string color) : this(name)
        {
            this.color = color;
        }

        public Auto(string name, string color, double dv) : this(name, color)
        {
            this.dv = dv;
        }
        //стат конструктор
        static Auto()
        {
            Cena = cena;
            Kpp = kpp;
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
            Console.WriteLine("Ввод наименования - ");
            string name1 = Console.ReadLine();
            Name = name1;

            Console.WriteLine("Ввод колора - ");
            string color1 = Console.ReadLine();
            Color = color1;

            Console.WriteLine("двигатель - ");
            double dv1 = Convert.ToDouble(Console.ReadLine());
            Dv = dv1;

            Console.WriteLine("привод - ");
            string pr1 = Console.ReadLine();
            Pr = pr1;

            Console.WriteLine("коробка передач - ");
            string kpp1 = Console.ReadLine();
            Kpp = kpp1;

            Console.WriteLine("стоимость - ");
            cena = Convert.ToDecimal(Console.ReadLine());
            Cena = cena;
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