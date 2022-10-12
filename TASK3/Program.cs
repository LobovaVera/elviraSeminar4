//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*4 -> 24 
5 -> 120*/

Console.Clear();
Console.WriteLine("Enter your number, please");
int ourNumber = int.Parse(Console.ReadLine()!);

int multResult (int number)
{
    int result = 1;
    for(int i = 1; i <= number; i++)
    {
        result = result*i;
        Console.WriteLine(result);
    }
    return result;
}

Console.WriteLine($"mult result is {multResult(ourNumber)}");

