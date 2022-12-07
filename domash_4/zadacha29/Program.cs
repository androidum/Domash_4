//Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.

void fillarray(int[] arr)
{
    for(int i=0; i<arr.Length;i++) 
    {
        Console.WriteLine($"Введите элемент массива под индексом {i}");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void printarray(int[] arr)
{
    for (int i = 0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] array = new int [8];
fillarray(array);
printarray(array);