// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] array = new int[50];
Random rand = new Random();
int p = 0; //сумма
for (int i = 0; i < array.Length; i++)
{
    {
        array[i] = rand.Next(0, 10001);
    }
    int j = 1;
    if (j % 2 == 1)
    {
        p = p + array[i];
    }
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях-->{p}");