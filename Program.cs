using System;

namespace CSLight
{
   internal class Program
   {
      static void Main(string[] args)
      {
         int n, n1, n2, k, l;

         Console.WriteLine("Введите количество элементов в одномерном массиве:");
         n = Convert.ToInt32(Console.ReadLine());
         int[] array = new int[n];

         Console.WriteLine("Введите диапазон значений в массивaх:");
         Random rnd = new Random();
         l = Convert.ToInt32(Console.ReadLine());
         k = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("\n");

         for (int i = 0; i < array.Length; i++)
            array[i] = rnd.Next(l, k);

         Console.WriteLine("Исходный одномерный массив:");
         foreach (int i in array)
         {
            Console.WriteLine(i);
         }

         int temp;
         for (int i = 0; i < (array.Length - 1); i++)
         {
            for (int j = i + 1; j < array.Length; j++)
            {
               if (array[i] > array[j])
               {
                  temp = array[i];
                  array[i] = array[j];
                  array[j] = temp;
               }
            }
         }
         Console.WriteLine("Отсортированный одномерный массив:");
         foreach (int i in array)
         {
            Console.WriteLine(i);
         }


         n1 = 3;
         n2 = 3;

         int[,] matrix = new int[n1, n2];

         for (int i = 0; i < matrix.GetLength(0); i++)
         {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
               matrix[i, j] = rnd.Next(l, k);
            }
         }

         Console.WriteLine("\n");
         Console.WriteLine("Исходный двумерный массив:");

         for (int i = 0; i < matrix.GetLength(0); i++)
         {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
               Console.Write((matrix[i, j]) + " ");
            }
            Console.WriteLine("\n");
         }

         int[] myArray = new int[n1 * n2];
         int z = 0;
         for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
               myArray[z] = matrix[i, j];
               z++;
            }

         int temp1;
         for (int i = 0; i < (myArray.Length - 1); i++)
         {
            for (int j = i + 1; j < myArray.Length; j++)
            {
               if (myArray[i] > myArray[j])
               {
                  temp1 = myArray[i];
                  myArray[i] = myArray[j];
                  myArray[j] = temp1;
               }
            }
         }

         Console.WriteLine("Отсортированный двумерный массив:");
         int[,] sortMyMatrix = new int[n1, n2];
         int p = 0;

         for (int i = 0; i < sortMyMatrix.GetLength(0); i++)
         {
            for (int j = 0; j < sortMyMatrix.GetLength(1); j++)
            {
               sortMyMatrix[i, j] = myArray[p];
               Console.Write(sortMyMatrix[i, j] + " ");
               p++;
            }
            Console.WriteLine("\n");
         }


         Console.WriteLine("Введите количество элементов в 3 массивах:");
         int[][] jagget = new int[3][];
         int a, b, c;

         a = Convert.ToInt32(Console.ReadLine());
         b = Convert.ToInt32(Console.ReadLine());
         c = Convert.ToInt32(Console.ReadLine());

         jagget[0] = new int[a];
         jagget[1] = new int[b];
         jagget[2] = new int[c];

         for (int i = 0; i < jagget[0].Length; i++)
            jagget[0][i] = rnd.Next(l, k);

         for (int i = 0; i < jagget[1].Length; i++)
            jagget[1][i] = rnd.Next(l, k);

         for (int i = 0; i < jagget[2].Length; i++)
            jagget[2][i] = rnd.Next(l, k);

         Console.WriteLine("Исходный зубчатый массив:");

         for (int i = 0; i < jagget.Length; ++i)
         {
            for (int j = 0; j < jagget[i].Length; ++j)
            {
               Console.Write("{0} ", jagget[i][j]);
            }
            Console.Write("\n");
         }

         for (int i = 0; i < jagget.Length; i++)
         {
            int[] innerArray = jagget[i];
            for (int j = 0; j < innerArray.Length - 1; j++)
            {
               int minIndex = j;
               for (int s = j + 1; s < innerArray.Length; s++)
               {
                  if (innerArray[s] < innerArray[minIndex])
                  {
                     minIndex = s;
                  }
               }
               int temp3 = innerArray[j];
               innerArray[j] = innerArray[minIndex];
               innerArray[minIndex] = temp3;
            }
         }

         for (int i = 0; i < jagget.Length - 1; i++)
         {
            int[] minArray = jagget[i];
            int minIndex = i;
            for (int j = i + 1; j < jagget.Length; j++)
            {
               if (jagget[j][0] < minArray[0])
               {
                  minArray = jagget[j];
                  minIndex = j;
               }
            }
            if (minIndex != i)
            {
               jagget[minIndex] = jagget[i];
               jagget[i] = minArray;
            }
         }

         Console.WriteLine("Отсортированный зубчатый массив:");
         for (int i = 0; i < jagget.Length; ++i)
         {
            for (int j = 0; j < jagget[i].Length; ++j)
            {
               Console.Write("{0} ", jagget[i][j]);
            }
            Console.Write("\n");
         }



      }
   }
}


