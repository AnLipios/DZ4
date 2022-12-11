//Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int number=int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {number} = {GetSum(number)}");
int GetSum(int number)
{
    int sum=0;
    while (number>0)
    {
        sum = sum+number%10;
        number = number/10;
    }
    return sum;
    
}
