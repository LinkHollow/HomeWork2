// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Берем числа до 100000
Console.WriteLine("Введите число до 100000: ");
int num = int.Parse(Console.ReadLine()!);
if(num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    if(num > 99 && num < 1000) 
    {
        Console.WriteLine(num % 10);
    }
    if(num > 999 && num < 10000)
    {
        Console.WriteLine((num % 100) / 10);
    }
    if(num > 9999 && num < 100000)
    {
        Console.WriteLine((num % 1000) / 100);
    }
    if(num > 100000)
    {
        Console.WriteLine("Введено число свыше 100000");
    }
}