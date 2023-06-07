//  Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да

Console.Clear();
Console.WriteLine("Этот код проверит, является ли пятизначное число паллиндромом. Введите пятизначное число:");
int Num = int.Parse(Console.ReadLine());

int Mod = Math.Abs(Num); 
while (Mod < 10000 || Mod > 99999)
{
    Console.WriteLine($"Это число не пятизначное");
    Console.WriteLine("Введите пятизначное число: ");
    Num = int.Parse(Console.ReadLine());
    Mod = Math.Abs(Num);
}

if (Num <0)
{Num = -1* Num;}

if ( (Num/10000)%10 == Num%10 && (Num/1000)%10 ==(Num/10)%10)
    Console.WriteLine($" Число {Num} является паллиндромом");
    else Console.WriteLine($" Число {Num} не является паллиндромом");