using System;

namespace Лаб._работа___14
{
    class Program
    {
        static void Main(string[] args)
        {
            tasks(4);
        }

        static void tasks(int n)
        {
            switch (n)
            {
                case 1:
                    {
                        Console.WriteLine("Задание № 1");
                        Console.WriteLine("Введите целые положительные числа a и b (a < b): ");
                        string[] nums = Console.ReadLine().Split();
                        int a = int.Parse(nums[0]);
                        int b = int.Parse(nums[1]);

                        if ((a > 0) && (a < b))
                        {
                            for (int i = a; i <= b; i++)
                            {
                                for (int j = 1; j <= i; j++)
                                    Console.WriteLine(i);
                            }
                        }
                        else
                            Console.WriteLine("err");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Задание № 2");
                        Console.WriteLine("Введите положительные числа a и b (a > b): ");
                        string[] nums = Console.ReadLine().Split();
                        double a = double.Parse(nums[0]);
                        double b = double.Parse(nums[1]);
                        while (a > b)
                        {
                            a -= b;
                        }
                        Console.WriteLine($"Ответ: {a}");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Задание № 3");
                        Console.WriteLine("Введите целое число N (N > 1): ");
                        int N = int.Parse(Console.ReadLine());
                        int sum = 0, k = 0;
                        for (int i = 1; sum < N; i++)
                        {
                            sum += i;
                            k = i;
                        }
                        Console.WriteLine($"Ответ: {k}");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Задание № 4");
                        Console.WriteLine("Введите вещественное число P (0 < P < 25): ");
                        double P = double.Parse(Console.ReadLine());
                        double S = 1000;
                        int k = 0;
                        while (S <=1100)
                        {
                            S += S * (P / 100);
                            k++;
                        }
                        Console.WriteLine($"Ответ: k = {k}, S = {S}");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Задание № 5");
                        Console.WriteLine("Введите целые положительные числа a и b: ");
                        string[] nums = Console.ReadLine().Split();
                        int a = int.Parse(nums[0]);
                        int b = int.Parse(nums[1]);
                        int nod = Math.Max(a, b);
                        b = Math.Min(a, b);
                        a = nod;

                        while (a % b != 0)
                        {
                            nod = b;
                            b = a % b;
                            a = nod;
                        }
                        nod = b;
                        Console.WriteLine($"НОД = {nod}");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Задание № 6");
                        Console.WriteLine("Введите целое число N (N > 1): ");
                        int N = int.Parse(Console.ReadLine());
                        int k = 2;
                        int f1 = 1;
                        int f2 = 1;
                        int f3 = 0;

                        while (N != f2)
                        {
                            f3 = f2;
                            f2 = f1 + f2;
                            f1 = f3;
                            k++;
                        }
                        Console.WriteLine($"{k} - номер порядкового числа Фибоначчи {N}");
                        break;
                    }
            }
        }
    }
}
