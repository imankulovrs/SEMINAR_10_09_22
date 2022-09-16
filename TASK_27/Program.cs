/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/




Console.WriteLine("Введите число ");
string S = Console.ReadLine();
int Sum = Sumfun(S);
Console.WriteLine(Sum);
int Sumfun(string str)
{
    int Sum = 0;
    for (int i = 0; i <str.Length; i++)
    {
        Sum = Sum + Convert.ToInt32(Convert.ToString(str[i]));
    }
    return Sum;
}