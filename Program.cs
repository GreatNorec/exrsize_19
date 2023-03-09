//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
int length = number.Length;
int answer = 0;

for (int i = 0; i < (length)/2; i++)
{
    if (number[i] == number[length -1 - i]) answer = 1;
    else answer = 0;
}

if (answer == 1) Console.WriteLine($"Число является палиндромом");
if (answer == 0) Console.WriteLine($"Число не является палиндромом");