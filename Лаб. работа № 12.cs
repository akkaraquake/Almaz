using System;

namespace Лаб.работа___12
{
    class Program
    {
        static void Main()
        {
			Console.WriteLine("Введите номер задания: ");
			int n, otv;
			n = int.Parse(Console.ReadLine());
			tasks(n);
			Console.WriteLine("Если хотите продолжить нажмите 1, иначе 0: ");
			otv = int.Parse(Console.ReadLine());
			if (otv == 1)
				Main();
		}
        static void tasks(int n)
		{
			if (n == 1)
			{
				Console.WriteLine("Задание №1");
				Console.WriteLine("Введите день и месяц: ");
				int m, d;
				string[] num;
				num = Console.ReadLine().Split(" ");
				d = int.Parse(num[0]);
				m = int.Parse(num[1]);
				string[] darr = { "первое", "второе", "третье", "четвертое", "пятое", "шестое", "седьмое", "восьмое"
		, "девятое", "десятое", "одиннадцатое", "двенадцатое", "тринадцатое", "четырнадцатое", "пятнадцатое",
		"шестнадцатое", "семнадцатое", "восемнадцатое", "девятнадцатое", "двадцатое", "двадцать первое",
		"двадцать второе", "двадцать третье", "двадцать четвертое", "двадцать пятое", "двадцать шестое",
		"двадцать седьмое", "двадцать восьмое", "двадцать девятое", "тридцатое", "тридцать первое" };

				string[] marr = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября",
		"октября", "ноября", "декабря" };


				Console.WriteLine("Ответ: " + darr[d - 1] + " " + marr[m - 1]);
			}
			else if (n == 2)
			{
				Console.WriteLine("Задание №2");
				Console.WriteLine("Введите С и N: ");
				int N;
				string C;
				string[] val;
				val = Console.ReadLine().Split();
				C = val[0];
				N = int.Parse(val[1]);
				switch (C)
				{
					case "С":
						switch (N)
						{
							case 1:
								C = "З";
								break;
							case 0:
								C = "С";
								break;
							case -1:
								C = "В";
								break;
						}
						break;
					case "Ю":
						switch (N)
						{
							case 1:
								C = "В";
								break;
							case 0:
								C = "Ю";
								break;
							case -1:
								C = "З";
								break;
						}
						break;
					case "З":
						switch (N)
						{
							case 1:
								C = "Ю";
								break;
							case 0:
								C = "З";
								break;
							case -1:
								C = "С";
								break;
						}
						break;
					case "В":
						switch (N)
						{
							case 1:
								C = "С";
								break;
							case 0:
								C = "В";
								break;
							case -1:
								C = "Ю";
								break;
						}
						break;
				}
				Console.WriteLine($"Ответ: {C}");
			}
			else if (n == 3)
			{
				Console.WriteLine("Задание №3");
				Console.WriteLine("Введите целое число m (9 < m < 41): ");
				int m = int.Parse(Console.ReadLine());
				string uz = " учебных заданий";
				string uz2 = " учебное задание";
				string uz3 = " учебных задания";
				string[] arr2040 = { "одно", "два", "три", "четыре", "пять", "шесть", "семь", "восемь",
				"девять"};
				if ((m>9) && (m<21))
                {
					string[] arr1020 = {"десять", "одиннадцать", "двенадцать", "тринадцать",
					 "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать",
					  "девятнадцать", "двадцать"};
					Console.WriteLine(arr1020[m - 10] + uz);
                }
				else if ((m>20) && (m<40))
                {
					string dv_or_tr = (m/10 == 2) ? "двадцать " : "тридцать ";
					
					switch (m%10)
                    {
						case 1:
							Console.WriteLine(dv_or_tr + arr2040[m%10-1] + uz2);
							break;
						case 2:
						case 3:
						case 4:
							Console.WriteLine(dv_or_tr + arr2040[m % 10 - 1] + uz3); 
							break;
						default:
							Console.WriteLine(dv_or_tr + arr2040[m % 10 - 1] + uz);
							break;
                    }
                }

			}
			else if (n==4)
            {
				Console.WriteLine("Задание №4");
				Console.WriteLine("Введите целое число m (99 < m < 1000): ");
				int m = int.Parse(Console.ReadLine());
				string[] sot = { "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот",
				"семьсот", "восемьсот", "девятьсот"};

				string[] des = {"десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят",
				"семьдесят", "восемьдесят", "девяносто"};

				string[] ed = { "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

				string[] des1 = {"одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать",
				"шестнадцать", "семнадцать", "восемнадцать", "девятнадцать"};

				string sm = Convert.ToString(m);

				if ((sm.IndexOf("0") == -1) && (sm[1] != '1'))
				{
					Console.WriteLine(sot[m / 100 - 1] + " " + des[(m / 10) % 10 - 1] + " " + ed[m % 10 - 1]);
                }
				else if ((sm.IndexOf("0") == -1) && (sm[1] == '1'))
                {
					Console.WriteLine(sot[m / 100 - 1] + " " + des1[m % 10 - 1]);
                }
				else if ((sm[1] == '0') && (sm[2] == '0'))
				{
					Console.WriteLine(sot[m / 100 - 1]);
				}
				else if (sm[1] == '0')
                {
					Console.WriteLine(sot[m / 100 - 1] + " " + ed[m % 10 - 1]);
                }
				else if (sm[2] == '0')
                {
					Console.WriteLine(sot[m / 100 - 1] + " " + des[(m / 10) % 10 - 1]);
				}
				
 			}
			else if (n==5)
            {
				Console.WriteLine("Задание №5");
				Console.Write("Введите год: ");
				int N = int.Parse(Console.ReadLine());
				Console.Write("год ");
				switch (N%10)
                {
					case 0:
					case 1:
						Console.Write("бел");
						break;
					case 2:
					case 3:
						Console.Write("черн");
						break;
					case 4:
					case 5:
						Console.Write("зелен");
						break;
					case 6:
					case 7:
						Console.Write("красн");
						break;
					case 8:
					case 9:
						Console.Write("желт");
						break;
                }
				if (((N % 12 >= 0) && (N % 12 < 6)) || ((N % 12 > 8) && (N % 12 < 12)))
				{
					Console.Write("ой ");
				}
				else if ((N % 12 > 5) && (N % 12 < 9)) 
				{
					Console.Write("ого ");
                }
				string[] animals = { "крысы", "коровы", "тигра", "зайца", "дракона", "змеи", "лошади",
					"овцы", "обезьяны", "курицы", "собаки", "свиньи"};
				Console.WriteLine(animals[(N + 8) % 12]);
			}
		}
	}
}
