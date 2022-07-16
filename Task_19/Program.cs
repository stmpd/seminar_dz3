// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите 5-ти значное число: ");
int num = Convert.ToInt32(Console.ReadLine());

void IsPalindrome(int number)
{
    if(number >= 10000 && number <= 99999)
    {
        int num1 = number / 10000;
        int num2 = number % 10;
        if(num1 == num2)
        {
            int num3 = number / 1000 % 10;
            int num4 = number % 100 / 10;
            if(num3 == num4)
            {
                Console.WriteLine("Является палиндромом");
            }
            else
            {
                Console.WriteLine("Не является палиндромом");
            }
        }
        else
        {
            Console.WriteLine("Не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine("Некорректное число");
    }
}

IsPalindrome(num);
