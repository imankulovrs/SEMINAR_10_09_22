/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/



int A = Prompt("Введите число А ");
int B = Prompt("Введите число B");
Console.WriteLine(Math.Pow(A,B));
int Prompt(string message)
{
Console.Write(message);
string value = Console.ReadLine();
return Convert.ToInt32(value);
}

