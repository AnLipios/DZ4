// Напишите цикл, который принимает на вход 
//два числа (A и B) и возводит число A 
//в натуральную степень B.

Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine($"{A} в степени {B} = {GetRank(A,B)}");


int GetRank(int num, int rank)
{

    int result = num;
    for (int i = 2; i <= rank; i++)
    {
        result = result * num;
    }
    return result;
}