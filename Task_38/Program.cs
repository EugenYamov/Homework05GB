// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

//Функция для заполнения массива
double[] GetArray(int size, int MinRandom, int MaxRandom)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(MinRandom, MaxRandom + 1);
    }
    return result;
}

//Вызов функции для создания массива
double[] array = GetArray(7, 1, 100);

//Алгоритм для нахождения минимального и минимального элемента массива
double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
    if (min > array[i])
    {
        min = array[i];
    }
}

//Вывод результата
Console.WriteLine($"\n[{String.Join(", ", array)}] \n" + 
                $"Минимальный элемент массива = {min} \n" + 
                $"Максимальный элемент массива = {max} \n" +
                $"Разность между максимальным и минимальным элементом = {max - min} \n ");

