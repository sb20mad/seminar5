// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
//double[] array = { 8, 30, 2, 28 };

double[] array = new double[5];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{ 
    array[i] = rand.NextDouble()*10000;      
}
double max =array[0];
double min=array[0];
double res = 0;
for (int i = 0; i < array.Length; i++)
    if (max < array[i])
    {
        max = array[i];
    }
for (int i = 0; i < array.Length; i++)
    if (array[i] < min )
    {
        min = array[i];
    }
    res=max-min;
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Максимальное число {max}");
Console.WriteLine($"Минимальное число {min}");
Console.WriteLine($"Разница {res}");

