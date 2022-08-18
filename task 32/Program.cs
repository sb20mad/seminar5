// Задача 32: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
int[] array = new int[12];

Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{ 
    array[i] = rand.Next(-4, 5); 
Console.WriteLine(string.Join(", ", array));
array[i]= -array[i];
    
// if (array[i] > 0)
//     {
//         array[i]= -array[i];
//     }
//     else     //(array[i] < 0)
//     {
//         array[i] = -array[i];
//     }
} 

Console.WriteLine(string.Join(", ", array));