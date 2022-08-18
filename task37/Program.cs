// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int[] array = new int[5];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 5);

}
Console.WriteLine(string.Join(", ", array));
//int[] array = {6, 7, 3, 6};
int[] resArray = new int[(array.Length + 1) / 2];
for (int i = 0; i < resArray.Length; i++)
{
    resArray[i] = array[i] * array[array.Length - 1 - i];
}

if (array.Length % 2 == 1)
{
    resArray[resArray.Length - 1] = array[array.Length / 2];
}
//Console.WriteLine(string.Join(", ", rand));
Console.WriteLine(string.Join(", ", resArray));


// { 
//     array[i] = rand.Next(1, 7);
//     Console.WriteLine(string.Join(", ", array));
// }
// int j = array.Length - 1; //; j < array.Length; j++)
// Console.WriteLine(j);
// for (int i = 0; i < (array.Length + 1) / 2; i++){
//     int sum = array[i] * array[j];
//     Console.Write(sum + " ");
//     j--;
// }


// int e = array.Length; // e > array.Length; e--)
//     Console.WriteLine(e);

// int sum = j*e;
//     Console.WriteLine(sum);
// }
//sum = J*e;

//    int sum = array[i]*j; 
//    Console.WriteLine("----------------");

//Console.WriteLine(sum);

// int j = array.Length;
// int sum = array[i]*j;

// Lenght/2 +Lenght%2

//Console.WriteLine(string.Join(", ", array));