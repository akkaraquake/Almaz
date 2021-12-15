using System;

namespace Лабораторная_работа___13
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
            switch (n)
            {
                case 1:
                    Console.WriteLine("Задание № 1");
                    Console.WriteLine("Введите стоимость 1 кг конфет: ");
                    double cost = double.Parse(Console.ReadLine());
                    for (double i = 0.1; i <= 1; i += 0.1)
                        Console.WriteLine(i * cost);
                    break;
                case 2:
                    {
                        Console.WriteLine("Задание № 2");
                        Console.WriteLine("Введите целое число N: ");
                        int N = int.Parse(Console.ReadLine());
                        double pr = 1;
                        for (int i = 1; i < N + 1; i++)
                            pr *= (i * 0.1) + 1;
                        Console.WriteLine($"Ответ: {pr}");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Задание № 3");
                        Console.WriteLine("Введите целое число N: ");
                        int N = int.Parse(Console.ReadLine());
                        int kv = 0;
                        for (int i = 1; i <= (2 * N - 1); i += 2)
                            kv += i;
                        Console.WriteLine($"Ответ: {kv}");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Задание № 4");
                        Console.WriteLine("Введите вещественное число А и целое число N: ");
                        string[] nums = Console.ReadLine().Split();
                        double A = double.Parse(nums[0]);
                        int N = int.Parse(nums[1]);
                        double sum = 0;
                        for (int i = 0; i <= N; i++)
                            sum += Math.Pow(A, i);
                        Console.WriteLine($"Ответ: {sum}");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Задание № 5");
                        Console.WriteLine("Введите вещественное число А и целое число N: ");
                        string[] nums = Console.ReadLine().Split();
                        double A = double.Parse(nums[0]);
                        int N = int.Parse(nums[1]);
                        double sum = 0;
                        for (int i = 0; i <= N; i++)
                            sum += Math.Pow(-1, i) * Math.Pow(A, i);
                        Console.WriteLine($"Ответ: {sum}");
                        break;
                    }
            }
        }
    }
}
