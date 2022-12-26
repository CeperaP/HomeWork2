// Задача 10. Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цмфру этого числа.

Console.WriteLine("Введите трехзначное число");

int Number = Convert.ToInt32(Console.ReadLine());
int NumberPlus;
int Number1;
int Number2;


if (Number >= 0)
{
     NumberPlus = Number;
}
else
{
     NumberPlus = (Number * -1);
}


if (NumberPlus < 100 || NumberPlus > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
     Number1 = NumberPlus/ 10;
     Number2 = Number1 % 10;
     Console.WriteLine($"Вывод:{Number2}");
}