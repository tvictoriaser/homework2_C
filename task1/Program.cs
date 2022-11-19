// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit (int num)
{
    return num / 10 % 10;
}

if (number > 99 && number < 1000)
{
    int result = secondDigit(number);
    Console.WriteLine($"Вторая цифра числа {number} -> {result}");
}
else Console.WriteLine("Введите верное число");





