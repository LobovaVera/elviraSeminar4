// f

/*int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(Math.Log10(number));

Console.WriteLine(Math.Floor(Math.Log10(number)));*/
/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/
Console.Clear();
const int SIZE =8;
int[] ourArray = new int[SIZE];

fillArray(ourArray);
writeArray(ourArray);


void fillArray(int[] arr)
{
    for (int i = 0; i<arr.Length; i++)
    {
        arr[i]= new Random().Next(0,2);

    }

}

void writeArray (int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");

    }
   
}


