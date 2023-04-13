using System;

int[] nums = { 2, 1, 5, 72, 55, 55, 9, 15, 16, 71 };
int trump;
for (int i = 0; i < nums.Length - 1; i++)
{
    for(int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] > nums[j]) 
        {
            trump = nums[i];
            nums[i] = nums[j];
            nums[j] = trump;
        }
    }
}
Console.WriteLine("Ответ на первое задание:");
for (int i = 0;i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}

int[,] dnums = new int[6, 6]
{
    {42,98,43,9,2,85},
    {29,49,92,4,94,24},
    {32,44,42,42,43,7},
    {39,25,78,27,58,8},
    {28,75,99,42,28,48},
    {73,38,47,4,28,37}
};
int temp;
int row = dnums.GetLength(0);
int column = dnums.GetLength(1);
int[] array = new int[row*column];
int k = 0;
for (int i = 0;i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        array[k] = dnums[i, j];
        k++;
    }
}
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

Console.WriteLine("Ответ на второе задание:");
int[,] sorting = new int[row, column];
int l = 0;

for (int i = 0; i < sorting.GetLength(0); i++)
{
    for (int j = 0; j < sorting.GetLength(1); j++)
    {
        sorting[i, j] = array[l];
        Console.Write(sorting[i, j] + " ");
        l++;
    }
}