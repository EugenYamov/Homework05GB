// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

//Функция заполнения массива
int[] GetArray(int size, int MinRandom, int MaxRandom)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(MinRandom, MaxRandom + 1);
    }
    return result;
}

//Объявляем массив
int[] array = GetArray(10, 1, 10);

//Алгоритм для нахождения суммы элементов, стоящих на нечетных позициях
int summ = 0;

for (int i = 1; i < array.Length; i+=2)
{
    summ = summ + array[i];
}

//Вывод результата
Console.WriteLine($" \n [{String.Join(", ", array)}] \n " +
                $"Сумма элементов с нечетными индексами = {summ} \n ");

