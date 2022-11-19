// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = Math.Abs(number);

int ThirdDigit (int digit)
{
    while (digit > 999)
    {
        digit /= 10;
    }
    return digit % 10;
}

if (number > 99)
{
    int result = ThirdDigit(number);
    Console.WriteLine($"Третья цифра числа {number} -> {result}");
} 

else Console.WriteLine($"У числа {number} нет третьей цифры");


