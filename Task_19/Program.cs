// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int num = 0;
bool isValidInput = false;

while (num < 10000 || num > 99999)
{
    Console.Write("Введите пятизначное число: ");
    isValidInput = int.TryParse(Console.ReadLine(), out num);

    if (isValidInput)
    {
        Console.WriteLine("Это не пятизначное число!");
    }
}

if (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10)
{
    Console.WriteLine("Да.");
}
else
{
    Console.WriteLine("Нет.");
}