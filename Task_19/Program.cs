// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int num = 0;
bool isValidInput = false;

while (!isValidInput || num < 10000 || num > 99999)
{
    Console.Write("Введите пятизначное число: ");
    isValidInput = int.TryParse(Console.ReadLine(), out num);

    if (!isValidInput || num < 10000 || num > 99999)
    {
        Console.WriteLine("Число не пятизначное!");
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