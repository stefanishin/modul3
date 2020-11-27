using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometicFigure
{
	/*
	 Написать приложение, которое будет отображать в консоли выбранные пользователем простейшие геометрические фигуры: 	 «прямоугольник», «ромб», «треугольник», «трапеция», «многоугольник».
	 В меню пользователь выбирает фигуры и выбирает цвета для каждой фигуры.
	 Фигуры рисуются звездочками или другими символами. 
	 Для реализации программы необходимо разработать иерархию классов (продумать возможность абстрагирования).
	 Все заданные пользователем фигуры хранятся в объекте «Обобщённая фигура», который имеет метод «отобразить все выбранные фигуры».
	 */
	class Program
	{
		abstract class Figure
		{ // Абстрактный класс
			public Figure(string n)
			{
				name = n;
			}
			private string name;
			public abstract void Draw(); // Абстрактный метод
			public void ShowName()
			{
				Console.WriteLine(name);
			}
		}
		class Rectangle : Figure
		{
			private int a;
			private int b;
			public string name = "прямоугольник";

			public Rectangle(int b, int a) : base("Прямоугольник")
			{
				this.a = a;
				this.b = b;
			}
			public override void Draw()
			{ // реализация абстрактного метода
				for (int i = 0; i < b; i++)
				{
					for (int j = 0; j < a; j++)
					{
						Console.Write("*");
					}
					Console.WriteLine();
				}
			}
		}
		class Rhombus : Figure
		{
			private int a;
			public string name = "ромб";
			public Rhombus(int a) : base("Ромб")
			{
				this.a = a;
			}
			public override void Draw()
			{ // реализация абстрактного метода
				int i, j;
				for (i = 1; i <= a; i++)
				{
					if (i <= (int)a / 2 + 1)

						for (j = 1; j <= a; j++)
							if ((j >= (int)a / 2 + 2 - i) && (j <= (int)a / 2 + i))
								Console.Write("*");
							else Console.Write(" ");

					// после середины
					else
						for (j = 1; j <= a; j++)
							if ((j >= (int)a / 2 + 1 + i - a) && (j <= (int)a / 2 + 1 - i + a))
								Console.Write("*");
							else Console.Write(" ");
					Console.WriteLine();
				}
			}
		}
		class Triangle : Figure
		{
			private int a;
			public string name = "треугольник";
			public Triangle(int a) : base("Треугольник")
			{
				this.a = a;
			}
			public override void Draw()
			{ // реализация абстрактного метода
				int i, j;
				for (i = 1; i <= a; i++)
				{
					for (j = 1; j <= i; j++)
					{
						Console.Write("*");
					}
					Console.WriteLine();
				}

			}
		}
		class Trapezoid : Figure
		{
			private int a;
			private int b;
			public string name = "трапеция";
			public Trapezoid(int a, int b) : base("Трапеция")
			{
				this.a = a;
				this.b = b;
			}
			public override void Draw()
			{ // реализация абстрактного метода
				int i, j;
				int s = (b - a) / 2;
				for (i = 1; i <= s + 1; i++)
				{
					for (j = 1; j <= b; j++)
					{
						if (j < s - i + 1 || j > (a + s + i)) Console.Write(" ");
						else Console.Write("*");
					}
					Console.WriteLine();
				}
			}
		}

		static void Main(string[] args)
		{
			void Color_Set()
			{
				int sch;
				Console.WriteLine("Выбор цвета");
				Console.WriteLine("Blue    - 1");
				Console.WriteLine("Gray    - 2");
				Console.WriteLine("Green   - 3");
				Console.WriteLine("Cyan    - 4");
				Console.WriteLine("Red     - 5");
				Console.WriteLine("Magenta - 6");
				Console.WriteLine("Yellow  - 7");
				Console.WriteLine("White   - 8");
				Console.Write("  Ваш выбор - ");
				sch = int.Parse(Console.ReadLine());
				switch (sch)
				{
					case 1:
						{
							Console.Clear();
							Console.BackgroundColor = ConsoleColor.Blue;
							break;
						}
					case 2:
						{
							Console.Clear();
							Console.BackgroundColor = ConsoleColor.Gray;
							break;
						}
					case 3:
						{
							Console.Clear();
							Console.BackgroundColor = ConsoleColor.Green;
							break;
						}
					case 4:
						{
							Console.Clear();
							Console.BackgroundColor = ConsoleColor.Cyan;
							break;
						}
					case 5:
						{
							Console.Clear();
							Console.BackgroundColor = ConsoleColor.Red;
							break;
						}
					case 6:
						{
							Console.Clear();
							Console.BackgroundColor = ConsoleColor.Magenta;
							break;
						}
					case 7:
						{
							Console.Clear();
							Console.BackgroundColor = ConsoleColor.Yellow;
							break;
						}
					case 8:
						{
							Console.Clear();
							Console.BackgroundColor = ConsoleColor.White;
							break;
						}
					default: { break; }
				}
			}
			//-------------------------------------------------------
			Rectangle f = new Rectangle(4, 8);
			Rhombus f1 = new Rhombus(9);
			Triangle f3 = new Triangle(15);
			Trapezoid f4 = new Trapezoid(9, 18);
			string[] df = new string[4];
			int z1, z2 = 0;
			int i = 0;
			do
			{
				Console.ResetColor();
				Console.Clear();
				Console.WriteLine("     M Е Н Ю ");
				Console.WriteLine("   ПРЯМОУГОЛЬНИК          - 1");
				Console.WriteLine("       РОМБ               - 2");
				Console.WriteLine("    ТРЕУГОЛЬНИК           - 3");
				Console.WriteLine("      ТРАПЕЦИЯ            - 4");
				Console.WriteLine("ПОКАЗАТЬ ВЫБРАННЫЕ ФИГУРЫ - 5");
				Console.WriteLine("             В Ы Х О Д    - 6");
				Console.Write("             Ваш выбор - ");
				z1 = int.Parse(Console.ReadLine());

				switch (z1)
				{
					case 1:
						{
							Color_Set();
							f.ShowName();
							f.Draw();
							df[i] = f.name;
							i++;
							break;
						}
					case 2:
						{
							Color_Set();
							f1.ShowName();
							f1.Draw();
							df[i] = f1.name;
							i++;
							break;
						}
					case 3:
						{
							Color_Set();
							f3.ShowName();
							f3.Draw();
							df[i] = f3.name;
							i++;
							break;
						}
					case 4:
						{
							Color_Set();
							f4.ShowName();
							f4.Draw();
							df[i] = f4.name;
							i++;
							break;
						}
					case 5:
						{
							while (i < 4)
							{
								Console.WriteLine(df[i]);
								i++;
							}
							break;
						}
				}
				Console.WriteLine("Для продолжения нажмите 1, для выхода 0");
				z2 = int.Parse(Console.ReadLine());
			} while (z2 == 1);

		}
	}
}
