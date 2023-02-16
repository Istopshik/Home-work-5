// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
Console.Clear();
System.Console.Write("Введите размер массива:   ");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];
MassiveRandom(numbers);
System.Console.Write("Наш массив:  ");
System.Console.WriteLine(String.Join(" ", numbers));
System.Console.WriteLine($"Мы сложили нечетные элементы массива и получили {ResultNumbers(size)}");



int ResultNumbers(int size)
{
    int oddNumbers = 0;
    for(int j = 1; j < numbers.Length; j = j + 2)
    {
        oddNumbers = oddNumbers + numbers[j];
    }
    return oddNumbers;
}
void MassiveRandom(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(1, 10000);
    }
}


