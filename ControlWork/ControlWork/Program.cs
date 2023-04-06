using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

Random rand = new Random();

int lenArr = rand.Next(2, 10);
int lenArr1 = rand.Next(2, 10);
int lenArr2 = rand.Next(2, 10);

int[] odnArr = new int[lenArr];

int[,] dvArr = new int[lenArr, lenArr1]; 

int[][] zubArr = new int[3][]; //
zubArr[0] = new int[lenArr];   //
zubArr[1] = new int[lenArr1];  //
zubArr[2] = new int[lenArr2];  //

for (int i = 0; i < odnArr.Length; i++) //одномерный массив
    odnArr[i] = rand.Next(100);

for (int i = 0; i < lenArr; i++) // двумерный массив
{
    for (int j = 0; j < lenArr1; j++)
    {
        dvArr[i, j] = rand.Next(100);
    }
}

for (int i = 0; i < lenArr; i++) // зубчатый массив
{
    for (int j = 0; j < lenArr; j++)
    {
        zubArr[0][j] = rand.Next(100);
    }
    for (int j = 0; j < lenArr1; j++)
    {
        zubArr[1][j] = rand.Next(100);
    }
    for (int j = 0; j < lenArr2; j++)
    {
        zubArr[2][j] = rand.Next(100);
    }
}


///сортировка одномерного массива///
Console.WriteLine("Исходный одномерный массив:");

foreach (var i in odnArr)
    Console.Write(i.ToString() + " ");

Console.WriteLine();
Console.WriteLine("Отсортированный одномерный массив: ");

int temp;
for (int i = 0; i < odnArr.Length - 1; i++) //сортировка
{
    for (int j = i + 1; j < odnArr.Length; j++)
    {
        if (odnArr[i] > odnArr[j])
        {
            temp = odnArr[i];
            odnArr[i] = odnArr[j];
            odnArr[j] = temp;
        }
    }
}

foreach (var i in odnArr)
    Console.Write(i.ToString() + " ");

///сортировка двумерного массива///
Console.WriteLine();
Console.WriteLine("Исходный двумерный массив:");
for (int a = 0; a < lenArr; a++)
{
    for (int b = 0; b < lenArr1; b++)
    {
        Console.Write(dvArr[a, b] + " ");
    }
    Console.WriteLine();
}


int[] dopArr = new int[lenArr * lenArr1];//создание одномерного массива с размером двумерного массива
int count = 0;

for (int i = 0; i < lenArr; i++) //перевод 2мерного массива в одномерный
    for (int j = 0; j < lenArr1; j++)
    {
        dopArr[count] = dvArr[i, j];
        count++;
    }

for (int i = 0; i < dopArr.Length - 1; i++) //сортировка
{
    for (int j = i + 1; j < dopArr.Length; j++)
    {
        if (dopArr[i] > dopArr[j])
        {
            temp = dopArr[i];
            dopArr[i] = dopArr[j];
            dopArr[j] = temp;
        }
    }
}

int[,] sorted_dvArr = new int[lenArr, lenArr1];
int count1 = 0;

for (int i = 0; i < lenArr; i++) //перевод одномерного массива в 2мерный
    for (int j = 0; j < lenArr1; j++)
    {
        sorted_dvArr[i,j] = dopArr[count1];
        count1++;
    }

Console.WriteLine();
Console.WriteLine("Сортированный двумерный массив:");
for (int a = 0; a < lenArr; a++)
{
    for (int b = 0; b < lenArr1; b++)
    {
        Console.Write(sorted_dvArr[a, b] + " ");
    }
    Console.WriteLine();
}

///сортировка ступенчатого массива///
Console.WriteLine();
Console.WriteLine("Исходный двумерный массив:");

int[] mass_dlin = { lenArr,lenArr1,lenArr2 }; // массив хранящий длины каждой строки в зубчатом массиве

for (int i = 0; i < mass_dlin.Length; i++)
{
    int dlin = mass_dlin[i];
    for (int j = 0; j < dlin; j++)
    {
        Console.Write(zubArr[i][j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < 3; i++) //сортировка по каждой строке
{
    int dlin = mass_dlin[i];
    for (int j = 0; j < dlin - 1; j++)
    {
        for (int k = j + 1; k < dlin; k++)
        {
            if (zubArr[i][j] > zubArr[i][k])
            { 
                temp = zubArr[i][j];
                zubArr[i][j] = zubArr[i][k];
                zubArr[i][k] = temp;
            }
        }
    }
}

Console.WriteLine();
Console.WriteLine("Сортированный двумерный массив:");

for (int i = 0; i < mass_dlin.Length; i++) //вывод готового зубчатого массива
{
    int dlin = mass_dlin[i];
    for (int j = 0; j < dlin; j++)
    {
        Console.Write(zubArr[i][j] + " ");
    }
    Console.WriteLine();
}