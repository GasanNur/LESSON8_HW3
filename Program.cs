// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int InputUser(string msg) // тип возвращаемого значение (int) название метода. в скобках тип параметра который метод принемает. 
{
    Console.Write($"{msg} = >");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}
// Метод заполнения массива случайными положительными числами
double[] FillArray(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(rnd.Next(1, 1000) / 10.0);
    }

    return array;
}

double DifferenceMaxMinArray(double[] intArray)
{
    double min = intArray[0];
    double max = intArray[1];
    if (min > max)
    {
        max = min;
        min = intArray[1];
    }
    for (int i = 2; i < intArray.Length; i++)
    {
        if (max < intArray[i]) max = intArray[i];
        if (min > intArray[i]) min = intArray[i];
    }
    return Math.Round(max - min, 2);
}
//  метод показывает количество четных чисел в массиве
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();

}

int userNumber = InputUser("Введите колличество элементов массива ");
double[] myArray = new double[userNumber];
FillArray(myArray);
PrintArray(myArray);

Console.WriteLine($"Разница между максимальными и минимальными элементами массива равна {DifferenceMaxMinArray(myArray)} ");