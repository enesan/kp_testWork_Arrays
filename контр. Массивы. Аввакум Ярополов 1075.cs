using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace контр_КП
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // одномерный массив 
            Console.WriteLine("одномерный массив");
            Random rand = new Random();  
            int[] array = new int[8];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0,101);
                Console.Write(array[i]+" ");
            }
            Console.WriteLine();
            
            

            for (int i = 0; i < array.Length; i++) //сортировка 
            {
                for (int j = 0;j<array.Length -i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int num = array[j+1];
                        array[j+1] = array[j];
                        array[j] = num;
                    }
                }  

            }
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
            Console.WriteLine();

            //Двумерный массив 
            Console.WriteLine("Двумерный массив ");

            int[,] array2 = new int[2,3]; 
            for (int i = 0;i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = rand.Next(0, 101);
                    Console.Write(array2[i,j]+" ");
                }
                Console.WriteLine();
            }
     
            int[] arr = new int[array2.GetLength(0) * array2.GetLength(1)]; // создание лже массива
          
            int s = 0;
                for (int i = 0; i < array2.GetLength(0); i++) // заполнение лже массива 
                {
                    for (int j = 0; j < array2.GetLength(1); j++)
                    {
                        arr[s] = array2[i, j];
                     s++;
                    }
                }
           

            //for (int i = 0; i < arr.Length; i++) // вывод лже массива
            //{
            //    Console.Write(arr[i]+" ");

            //}
            Console.WriteLine();
            Console.WriteLine("отсортированный");

            for (int i = 0; i < arr.Length; i++)   // сортировка лже масива
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int num = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = num;
                    }
                }
            }
            //for (int i = 0; i < arr.Length; i++) // вывод лже массива
            //{
            //    Console.Write(arr[i] + " ");

            //}
            //Console.WriteLine();

            // замена двумер масива 
            int k= 0;
                for (int i = 0; i < array2.GetLength(0); i++)
                {
                    for (int j = 0; j < array2.GetLength(1); j++)
                    {
                        array2[i, j] = arr[k];
                    k++;
                    }
                 
                }
            

            
            for (int i = 0; i < array2.GetLength(0); i++)   // вывод
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.Write(array2[i, j] + " ");
                }
                Console.WriteLine();
            }

            // зубчатый массив 
            Console.WriteLine();
            Console.WriteLine("зубчатый массив");

            int[][] a= new int[2][];
            a[0] = new int[3];
            a[1] = new int[5];
            Random ran = new Random();

            for (int i = 0; i < a.Length; i++) //заполнение 
            {
                for (int j = 0;j < a[i].Length; j++)
                {
                    a[i][j]= ran.Next(0, 101);

                }
            }
            
            for (int i = 0; i < a.Length; i++) // вывод
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j]+" ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("отсортированный");
            for (int i = 0; i < a.Length; i++) // сортировка
            {
                int dlin = a[i].Length;
                for (int j = 0; j < dlin - 1; j++)
                {
                    for (int z = j + 1; z < dlin; z++)
                    {
                        if (a[i][j] > a[i][z])
                        {
                            int temp = a[i][j];
                            a[i][j] = a[i][z];
                            a[i][z] = temp;
                        }
                    }
                }
            }
            

            for (int i = 0; i < a.Length; i++) //вывод
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");

                }
                Console.WriteLine();
            }


        }






    }
}
