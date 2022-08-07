// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//Функция для заполнения массива
int[] GetArray(int size, int MinRandom, int MaxRandom)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(MinRandom, MaxRandom + 1);
    }
    return result;
}
//Объявляем массив с нужными параметрами
int[] array = GetArray(10, 100, 999);

//Объявляем счетчик четных элементов массива
int count = 0;

//Алгоритм для подсчета четных элементов
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}

//Вывод результата
Console.WriteLine($" \n [{String.Join(", ", array)}]");
Console.WriteLine($"Колличество четных чисел массива : {count} \n ");

