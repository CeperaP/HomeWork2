//Задача 15. Напишите программу,которая принимает на вход цифру,обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число,соответствующее дню недели от 1 до 7");

int day = Convert.ToInt32(Console.ReadLine());

if (day > 7 || day < 1)
{
    Console.WriteLine("Нет такого дня недели");
}
if(day>=1 & day<=5)
{
    Console.WriteLine("Не выходной");
}

if(day ==6 || day==7)
{
     Console.WriteLine("Выходной");
}