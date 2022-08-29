// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


int FindPositiveNumbers(int[] array)
{
    var result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result += 1;
        }
    }
    return result;
}

Console.WriteLine("Пожалуйста введите числа через запятую и нажмите Enter:");
string?[] numbers = Console.ReadLine()!.Split(',');

int[] numbersToArray = numbers.Select(x => int.Parse(x!.ToString())).ToArray();
Console.Write("Количество чисел больше нуля равно: ");
Console.Write(FindPositiveNumbers(numbersToArray));