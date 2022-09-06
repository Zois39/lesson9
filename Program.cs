// задать значение N и написать программу, которая выведет все натуральные числа в промежутке от 1 до N
/*
void PrintNumbers(int m, int n)
{
    Console.Write(m + " ");
    if (n > m)
        PrintNumbers(m + 1, n);
}
PrintNumbers(1, 10);
*/
/*
void ShowNumbers(int n)
{
    if (n > 1) ShowNumbers(n - 1);

    Console.Write(n + " ");
}
ShowNumbers(10);
*/
// необходимо написать программу, которая будет принимать на вход число и показывать сумму цифр
/*
int SumDig (int num)
{
    int sum = num % 10;
    if (num > 0)
        sum += SumDig(num / 10);
    return sum;
}

Console.Write(SumDig(99999));
*/
/*
int FindSum( int n)
{
    if (n > 0) return FindSum(n / 10) + n % 10;
    else return n;
}
Console.Write(FindSum(99999));
*/

// необходимо задать значения m и n и написать программу, которая выведет все натуральные числа в промежутке от m до n
/*
void PrintNumbers(int m, int n)
{
    Console.Write(m + " ");
    if (n > m)
        PrintNumbers(m + 1, n);
}
PrintNumbers(1, 10);
*/
// написать программу, которая возводит число a в степень b

int Degree (int a, int b)
{
    if (b == 0) return 0;
    else if (b == 1) return a;
    else return a * Degree(a, b - 1);
}
Console.Write(Degree(2, 0));