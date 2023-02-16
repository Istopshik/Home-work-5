//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
Console.Clear();
System.Console.Write("Введите размер массива:   ");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];
MassiveRandom(numbers);
System.Console.Write("Наш массив:  ");
System.Console.WriteLine(String.Join(" ", numbers));
void MassiveRandom(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(1, 10000);
    }
}

    int min = Int32.MaxValue;
    int max = Int32.MinValue;
    for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}
    System.Console.WriteLine($"Мы получили максимальное число {max} и минимальное {min}. Разница между ними составляет {max-min}");
    
