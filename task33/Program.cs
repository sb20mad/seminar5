// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] array = new int[12];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{ 
    array[i] = rand.Next(-4, 5); 
}
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(string.Join(", ", array));
bool flag = false; //Если фолсе  то элементе в массиве нет, иначе есть
for (int i = 0; i < array.Length; i++)
{
if (number == array[i])
    {
       flag = true;        
    }
}
if (flag == true)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
      
//Console.WriteLine(string.Join(", ", array));