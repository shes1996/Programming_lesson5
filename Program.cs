/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

void Zadacha34()
{
    Console.WriteLine("Введите количество чисел в массиве");
    int[] number = new int[int.Parse(Console.ReadLine())];
    Random rnd = new Random();
    int count = 0;
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = rnd.Next(100, 1000);
        Console.Write(number[i] + " ");
        if (number[i] % 2 == 0) count += 1;
    }
    Console.WriteLine();
    Console.WriteLine(count);
}
//Zadacha34();

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
void Zadacha36()
{
    Console.WriteLine("Введите количество чисел в массиве");
    int[] number = new int[int.Parse(Console.ReadLine())];
    Random rnd = new Random();
    int sum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = rnd.Next(0, 100);
        Console.Write(number[i] + " ");
        if (i % 2 != 0) sum += number[i];
    }
    Console.WriteLine();
    Console.WriteLine(sum);
}
//Zadacha36();


/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3,21 7,04 22,93 -2,71 78,24] -> 75,53*/
void Zadacha38()
{
    Console.WriteLine("Введите количество чисел в массиве");
    double[] number = new double[int.Parse(Console.ReadLine())];
    Random rnd = new Random();
    double result = 0;
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = rnd.NextDouble()*10;
        Console.Write(number[i] + " ");
    }
    double min = number[0];
    double max = number[0];
    for (int i = 0; i < number.Length; i++)
    {
        if (max < number[i]) max = number[i];
        if (min > number[i]) min = number[i];
    }

    result = max - min;
    Console.WriteLine();
    Console.WriteLine(result);
}
//Zadacha38();


