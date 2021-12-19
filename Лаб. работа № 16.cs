using System;

namespace Лаб._работа___16
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
                    {
                        Console.WriteLine("Задание № 1");
                        Console.WriteLine("Введите размер массива N: ");
                        int N = int.Parse(Console.ReadLine());
                        int[] nums = new int[N];
                        int k = 1;
                        for (int i = 0; i < N; i++) 
                        {
                            nums[i] = k;
                            k += 2;
                        }
                        Console.Write("Ответ: ");
                        for (int i = 0; i < N; i++)
                            Console.Write(nums[i] + " ");
                        Console.Write("\n");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Задание № 2");
                        Console.WriteLine("Введите N, A, D: ");
                        string[] nums = Console.ReadLine().Split();
                        int N = int.Parse(nums[0]);
                        int A = int.Parse(nums[1]);
                        int D = int.Parse(nums[2]);
                        double[] num = new double[N];
                        for (int i = 0; i < N; i++)
                            num[i] = A * Math.Pow(D, i + 1);
                        Console.Write("Ответ: ");
                        for (int i = 0; i < N; i++)
                            Console.Write(num[i] + " ");
                        Console.Write("\n");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Задание № 3");
                        Console.WriteLine("Введите N, A, B: ");
                        string[] nums = Console.ReadLine().Split();
                        int N = int.Parse(nums[0]);
                        int A = int.Parse(nums[1]);
                        int B = int.Parse(nums[2]);
                        int[] num = new int[N];
                        num[0] = A;
                        num[1] = B;
                        int sum = num[0];
                        for (int i=2;i<N;i++)
                        {
                            sum += num[i - 1];
                            num[i] = sum;
                        }
                        Console.Write("Ответ: ");
                        for (int i = 0; i < N; i++)
                            Console.Write(num[i] + " ");
                        Console.Write("\n");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Задание № 4");
                        Console.WriteLine("Введите размер массива N: ");
                        int N = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите элементы массива: ");
                        string[] elem = Console.ReadLine().Split();
                        Console.Write("Ответ: ");
                        for (int i = 0; i < N; i++)
                        {
                            Console.Write(elem[i] + " ");
                            Console.Write(elem[N - 1 - i] + " ");
                        }
                        Console.Write("\n");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Задание № 5");
                        Console.WriteLine("Введите размер массива N: ");
                        int N = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите элементы массива: ");
                        string[] A = Console.ReadLine().Split();
                        Console.Write("Ответ 1: ");
                        for (int i = 1; i < N; i += 2)
                            Console.Write(A[i] + " ");
                        Console.Write("\n");
                        Console.Write("Ответ 2: ");
                        if (N % 2 == 0)
                        {
                            for (int j = N - 2; j >= 0; j -= 2)
                                Console.Write(A[j] + " ");
                        }
                        else
                        {
                            for (int j = N - 1; j >= 0; j -= 2)
                            {
                                Console.Write(A[j] + " ");
                            }
                        }
                        Console.Write("\n");
                        break;
                    }

            }
        }
    }
}
