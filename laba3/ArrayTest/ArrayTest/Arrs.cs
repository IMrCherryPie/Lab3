using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Arrs
    {
        private static Random rnd = new Random(Guid.NewGuid().ToByteArray().Sum(x => x));
        public static void CreateRandDimAr(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(10, 50);
        }
        public static void PrintArr(int[] arr)
        {
            if (arr == null) Console.WriteLine("Empty");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        public static void CreateRandDimAr(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
                for (int y = 0; y < array.GetLength(1); y++)
                    array[i, y] = rnd.Next(10, 50);
        }
        public static void PrintArr(int[,] arr)
        {
            if (arr == null) Console.WriteLine("Empty");
            else
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int y = 0; y < arr.GetLength(1); y++)
                        Console.Write(arr[i, y] + " ");
                    Console.WriteLine();
                }
            }
        }
        public static int[,] MultMatr(int[,] arr1, int[,] arr2)
        {
            if (arr1.GetLength(1) != arr2.GetLength(0)) return null;
            int[,] Mass = new int[arr1.GetLength(0), arr2.GetLength(1)];
            int sum = 0;
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    for (int r = 0; r < arr2.GetLength(0); r++)
                    {
                        sum = sum + arr1[i, r] * arr2[r, j];
                    }
                    Mass[i, j] = sum;
                    sum = 0;
                }
            }
            return Mass;
        }
        public static void PrintArr(int[][] arr)
        {
            if (arr == null) Console.WriteLine("Empty");
            foreach (var t in arr)
            {
                for (int i = 0; i < t.Length; i++)
                    Console.Write(t[i] + " ");
                Console.WriteLine();
            }
        }
        public static void CreateRandDimAr(int[][] array)
        {
            if (array != null)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    var k = new int[i + 1];
                    for (int j = 0; j <= i; j++)
                        k[j] = rnd.Next(10, 100);
                    array[i] = k;
                }
            }
        }
    }
}
