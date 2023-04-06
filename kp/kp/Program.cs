using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace kp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas1 = new int[5];

            Random random = new Random();
            Console.WriteLine("Defoltniy massiv: ");

            for(int i = 0; i < mas1.Length; i++)    // random zapolnenie
            {
                mas1[i] = random.Next(100);
                Console.Write(mas1[i] + " ");
            }
            Console.WriteLine("\n" + "Otsortirovanniy massiv: ");


            for(int i = 0; i < mas1.Length-1; i++)      // sortirovka
            {
                for (int j = i; j < mas1.Length; j++)
                {
                    if (mas1[j] < mas1[i])
                    {
                        int temp = mas1[i];
                        mas1[i] = mas1[j];
                        mas1[j] = temp;
                    }
                }
            }

            for(int i = 0; i < mas1.Length; i++)        // vyvod
            {
                Console.Write(mas1[i] + " ");
            }
            Console.WriteLine("\n");






            // 14 - 42 №1 


            int[,] m2 = new int[2, 3];                  //sozdanie 
            for (int i = 0; i < m2.GetLength(0); i++)
            {
                for (int j = 0; j < m2.GetLength(1); j++)
                {
                    m2[i, j] = random.Next(100);        //zapolnenie randomom i vyvod
                    Console.Write(m2[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < m2.GetLength(0); i++)           //sortirovka
            {
                for (int j = 0; j < m2.GetLength(1); j++)
                {
                    for (int x = 0; x < m2.GetLength(0); x++)
                    {
                        for (int y = 0; y < m2.GetLength(1); y++)
                        {
                            if (m2[i, j] < m2[x, y])
                            {
                                int temp = m2[i, j];            //zamena
                                m2[i, j] = m2[x, y];
                                m2[x, y] = temp;
                            }
                        }
                    }
                }
            }
            Console.WriteLine();

            for (int i = 0; i < m2.GetLength(0); i++)           //vyvod 
            {
                for (int j = 0; j < m2.GetLength(1); j++)
                {
                    Console.Write(m2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


