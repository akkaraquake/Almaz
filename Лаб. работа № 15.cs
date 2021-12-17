using System;

namespace Лабораторная_работа___15
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
                    Console.WriteLine("Введите пять вещественных чисел ( каждое число с новой строки): ");
                    double PowerA3(double a, double b = 0)
                    {
                        b = Math.Pow(a, 3);
                        return b;
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        double num = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Ответ: {PowerA3(num)}");
                    }
                    break;
                case 2:
                    Console.WriteLine("Задание № 2");
                    Console.WriteLine("Введите вещественные числа A и B: ");
                    string[] nums = Console.ReadLine().Split();
                    double A = double.Parse(nums[0]);
                    double B = double.Parse(nums[1]);
                    int Sign(double X)
                    {
                        if (X < 0)
                            return -1;
                        else if (X == 0)
                            return 0;
                        else 
                            return 1;

                    }
                    Console.WriteLine($"Ответ: {Sign(A) + Sign(B)}");
                    break;
                case 3:
                    Console.WriteLine("Задание № 3");
                    Console.WriteLine("Введите три раза с новой строки R1 и R2 (R1 > R2): ");
                    double RingS(double R1, double R2)
                    {
                        if (R1 > R2)
                            return 3.14 * (R1 * R1 - R2 * R2);
                        else
                            Console.WriteLine("Err");
                            return 0;
                    }
                    for (int i = 1; i < 4; i++)
                    {
                        string[] numss = Console.ReadLine().Split();
                        double R1 = double.Parse(numss[0]);
                        double R2 = double.Parse(numss[1]);
                        Console.WriteLine($"Ответ для пары № {i}: {RingS(R1, R2)}");
                    }
                    break;
                case 4:
                    { 
                        Console.WriteLine("Задание № 4");
                        Console.WriteLine("Введите каждый раз с новой строки 3 точки с ненулевыми координатами x и y: ");
                        int Quarter(double x, double y)
                        {
                            if ((x == 0) || (y == 0))
                            {
                                Console.WriteLine("Err");
                                return 0;
                                
                            }
                            if ((x > 0) && (y > 0))
                                return 1;
                            else if ((x < 0) && (y > 0))
                                return 2;
                            else if ((x < 0) && (y < 0))
                                return 3;
                            else
                                return 4;
                        }
                        for (int i = 1; i < 4; i++)
                        {
                            string[] numss = Console.ReadLine().Split();
                            double x = double.Parse(numss[0]);
                            double y = double.Parse(numss[1]);
                            Console.WriteLine($"Ответ для пары № {i}: {Quarter(x, y)}");
                        }
                        break;
                    }
                case 5:
                    Console.WriteLine("Задание № 5");
                    Console.WriteLine("Введите целое число N: ");
                    int N = int.Parse(Console.ReadLine());
                    double Fact2(int N)
                    {
                        double res;
                        res = 1;
                        while (N > 0)
                        {
                            res *= N;
                            N -= 2;
                        }
                        return res;
                    }
                    Console.WriteLine($"Ответ: {Fact2(N)}");
                    break;

            }
        }
    }
}
