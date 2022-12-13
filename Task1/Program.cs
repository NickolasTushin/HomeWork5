//Задача 34:
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 999);
}


int ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++; 
    }
    return count;
}


Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество элементов массива:  ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
InputArray(arr);

Console.WriteLine($" Числа в массиве : [{string.Join(",", arr)}]");

Console.WriteLine($" Чётных чисел в массиве:  =  {ReleaseArray(arr)}");