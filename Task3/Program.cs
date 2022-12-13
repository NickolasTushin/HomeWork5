//Задача 38:_ 
//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1,100);
        Console.WriteLine($"[{string.Join(", ", array)}]");
}
void MinMax(int []array)
{
int min = array[0];
int max = 0;      
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > max)
                {
                    // найден больший элемент
                    max = array[j];
                }
                
            }
    if (min > array[i])
    // найден меньший элемент
    min = array[i]; 

}
 Console.WriteLine($"Минимальный элемент: {min}");

 Console.WriteLine($"Максимальный элемент: {max}");
 
 Console.WriteLine($"Разница между элементами = {max - min}");
}
InputArray(array);
MinMax(array);



