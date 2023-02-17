// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int[] arr = PrintArray();
int[] PrintArray()
{
    int x = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[x];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000, 1000);
        Console.Write($" {array[i]}");
    }
    return array;
}
int Zeror(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine();
Console.WriteLine(Zeror(arr));