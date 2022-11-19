// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

bool Weekend (int day)
{
    return day == 6 || day == 7;
}

if (number < 1 || number > 7) Console.WriteLine("Вы ввели неверное число");
else if (number > 0 && number < 6) Console.WriteLine($"{number} -> нет");
else
{
    bool result = Weekend(number);
    Console.WriteLine($"{number} -> да");
}

