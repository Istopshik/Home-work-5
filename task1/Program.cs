// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
Console.Clear();
System.Console.Write("Введите количество чисел для массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[size]; 
RandomNumbers(massive);
System.Console.Write("Мы молучили такой массив:  ");
System.Console.WriteLine(String.Join(" ", massive));
System.Console.WriteLine($"В нашем массиве у нас {ResultNumbers(size)} четных числа!");


int ResultNumbers(int size)
{
    int count = 0;
    for(int j = 0; j < massive.Length; j++)
    if(massive[j] %2 ==0)
    count++;
    return count;
}




void RandomNumbers(int[] massive)
{
    for(int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(100, 1000);
    }
}

