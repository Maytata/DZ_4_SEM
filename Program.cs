Console.Write("Введите число: ");
	int A = Convert.ToInt32(Console.ReadLine());
	Console.Write($"Введите степень, в которую необходимо возвести число {A}: ");
	int B = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(FindMulti(A, B));

int FindMulti(int A, int B)
{
    int newA = A;
    for(int i = 1; i <  B; i++)
    {
        newA *= A;
    }
    return newA;
}


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void SumNumbers()
{
    Console.Clear();
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int sum = FindSum(num);
    Console.WriteLine($"Сумма цифр числа {num} равна {sum}");
}

SumNumbers();

int FindSum(int currentNum)
{
    int sum = 0;
    while (currentNum > 0)
    {
        sum += currentNum % 10;
        currentNum /= 10;
    }
    return sum;
}


//Задача про массив
int size = 8;
    int[] array = new int[size];
    array = FillArrayFunc(size);
    int[] NewArray = OrderArray(array);
    PrintArray(NewArray);


int[] FillArrayFunc(int size)
{
    int[] FillArray = new int[size];
    Random rand = new Random(size);
    for(int i = 0; i < FillArray.Length; i++)
    {
        FillArray[i] = rand.Next(-100, 101);
    }
    return FillArray;
}

int[] OrderArray(int[] array)
{
    int len = array.Length - 1;
    while(len > 0)
    {
        int index = 0;
        int max = Math.Abs(array[index]);
        int temp;
        int maxIndex = 0;
        while(index <= len)
        {
            if(Math.Abs(array[index]) > Math.Abs(max))
            {
                max = array[index];
                maxIndex = index;
            }
            index++;
        }
        temp = array[len];
        array[len] = max;
        array[maxIndex] = temp;
    len--;
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
