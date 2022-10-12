// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*456 -> 3
78 -> 2
89126 -> 5*/
Console.Clear();
Console.WriteLine("Enter your number, please");
int ourNumber = int.Parse(Console.ReadLine()!);

int numberOfDigits (int number)
{
    int count = 0;
    for(int i =1; number > 0; i++)
    {
        number /= 10;
        count =i;

    }

    return count;
}


Console.WriteLine(numberOfDigits(ourNumber));



