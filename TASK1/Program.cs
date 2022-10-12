// 
Console.Clear();


/*void summNumbers (int a)
{
      int summa = 0;
    for (int i = 1; i <= a; i++)
    {
      
        summa += i;
    }
    Console.WriteLine($"summ is = {summa}");
}


Console.WriteLine("Enter A number, please");
int A = int.Parse(Console.ReadLine()!);
summNumbers(A);*/


int SumNumbers (int a)
{
    int result = 0;
    for(int i =0; i <= a; i++)
    {
        result += i;

    }
    return result;
}

Console.WriteLine("Enter A number, please");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine($" summ is {SumNumbers(A)} ");