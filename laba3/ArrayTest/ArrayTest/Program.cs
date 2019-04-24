using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] i= new int[45];
            // Arrs t = new Arrs();
            //Arrs.CreateOneDimAr(i);
            // foreach (var d in i)
            // {
            //    Console.Write(" "+d); 
            // }

            Quest_1();
            Quest_2();
            Quest_3();
            Console.ReadKey();
        }

        private static void Quest_1()
        {
            Console.WriteLine("Задание 1");
            int[] A = new int[5], B = new int[5], C = new int[5], X = { 5, 5, 6, 6, 7, 7 }, U, V;
            //присвоение массива
            U = new int[3]; for (int i = 1; i <= U.Length; i++)
                U[i - 1] = i;
            V = new int[] { 1, 2, 3 };

            V = U;

            V[0] = 9;
            //рандомно заполняем массивы а и б
            Arrs.CreateRandDimAr(A); Arrs.CreateRandDimAr(B);
            //находим сумму двух массивов
            for (int i = 0; i < C.Length; i++)
                C[i] = A[i] + B[i];

            //выводы
            Console.Write("Array A:"); Arrs.PrintArr(A);
            Console.Write("Array B:"); Arrs.PrintArr(B);
            Console.Write("Array C(summ):"); Arrs.PrintArr(C);
            Console.Write("Array X:"); Arrs.PrintArr(X);
            Console.Write("Array U:"); Arrs.PrintArr(U);
            Console.Write("Array V:"); Arrs.PrintArr(V);

            Console.WriteLine("Введите размерность массива:");
            int size = int.Parse(Console.ReadLine());
            int[] D = new int[size];
            Arrs.CreateRandDimAr(D);
            Console.Write("Array D:"); Arrs.PrintArr(D);
        }
        private static void Quest_2()
        {
            Console.WriteLine("\nЗадание 2");
            int[,] A = new int[2, 3];
            int[,] B = new int[3, 2];
            Arrs.CreateRandDimAr(A);
            Console.WriteLine("Matrix a:"); Arrs.PrintArr(A); Console.WriteLine();
            Arrs.CreateRandDimAr(B);
            Console.WriteLine("Matrix b:"); Arrs.PrintArr(B); Console.WriteLine();
            int[,] C = Arrs.MultMatr(A, B);
            Console.WriteLine("Multyplied matrix:"); Arrs.PrintArr(C); Console.WriteLine();
        }
        private static void Quest_3()
        {
            Console.WriteLine("\nЗадание 3");
            int[][] arr = new int[10][];
            Arrs.CreateRandDimAr(arr);
            Arrs.PrintArr(arr);
        }
    }
}