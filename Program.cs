//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int degree (int a , int b) {
    int c = 1;
    for (int i = 1; i <= b; i++)
    {
        
        
        c *= a;
        Console.WriteLine($"{c}");

    }
    return c;

}

degree(3, 5);


//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.Вариант 1



int amount(int a)
{
    int result = 0;
    if (a <= 99)
    {
        int firstIndex = a / 10;
        int secondIndex = a % 10;
        result = firstIndex + secondIndex;
    }
    else if (a >= 100 && a <= 999)
    {

        int middleIndex = a % 100 / 10;
        int firstIndex = a / 100;
        int lastIndex = a % 10;
        result = middleIndex + firstIndex + lastIndex;
    }
    else if (a >= 1000 && a <= 9999)
    {
        int lastIndex = a % 10;
        int preLastIndex = a % 100 / 10;
        int middleIndex = a / 100 % 10;
        int firstIndex = a / 1000;
        result = middleIndex + firstIndex + lastIndex + preLastIndex;
    }
    return result;

}

Console.WriteLine(amount(999));






//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] numberArray()
{
    
    Console.Write("Введите количество элементов массива: ");
    int n = int.Parse(Console.ReadLine());
    int[] a = new int[n];

    

    for (int i = 0; i < n; i++)
    {
        a[i] = int.Parse(Console.ReadLine());

    }
    return a;
}

Console.WriteLine(String.Join(" ",numberArray()));