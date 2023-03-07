// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Генерируем массив случайных чисел 
int[,] GenerateArray(int row, int col)
{
    int[,] array = new int[row, col]; // Создаем 2-мерный массив
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(2, 10);
        }
    }
    return array;
}
// вводим содержимое двухмероного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
    }
    Console.WriteLine();

}
//метод который считает среднеарифметическое каждого клонки массива 
double[] AverageArray(int[,] array) // заголовок метода который возвращает массив со средним значением. 
{
    double[]result=new double[array.GetLength(1)]; //создания массива для вычесление средного значение.
    for (int i = 0; i < array.GetLength(1); i++) // цикл по колонкам 
    {
        for (int j = 0; j < array.GetLength(0); j++) // цикл по строкам 
        {
            result[i] += array[j, i]; // суммируем колонку
        }
        result[i] = result[i] / array.GetLength(0); // делим сумму на количество элементов получаем среданее значение 
      
    }
    return result; 
}

void PrintAverage(double[]avg)  // Функция которая печатает массив со средними значениями. 
{
    for (int i = 0; i < avg.GetLength(0); i++) // цикл по элементам массива 
    {
        Console.Write($"{avg[i]}\t"); // печать элементов массива 
    }
    Console.WriteLine();
}



int[,] matrix = GenerateArray(4, 4);
PrintArray(matrix);
Console.WriteLine($"cреднее арифметическое элементов в каждом столбце равны = ");
PrintAverage(AverageArray(matrix));

// int[,] matrix = GenerateArray(4, 4);
// GenerateArray(array[int,j]) ;
// PrintArray(matrix);
// Console.WriteLine($"индексы поискового элемента равны = {PrintArray}");