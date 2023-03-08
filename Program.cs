Console.Clear();
Console.WriteLine("Введите размер двухмерного массива");
int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);

int[,] arr = GetArray(m, n, 0, 10);
PrintArray(arr);
Console.WriteLine();
int min = MinSumLine(arr);
Console.WriteLine($"Наименьшая сумма элементов в строке - {min}");

int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
     int[,] result = new int[m, n];
     for (int i = 0; i < m; i++)      
     {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);  
        }              
     }
     return result;
}

int MinSumLine(int[,] Array)
{   
    int min = 0;
    for(int i = 0; i < Array.GetLength(0); i++)
    {   
        int sum = 0;
        for(int j = 0; j < Array.GetLength(1); j++)
        {   
            sum = sum + Array[i, j];
        }
        if(sum < min) { min = i;}
    }
    return min;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}