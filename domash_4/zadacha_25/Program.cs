

int degree(int n1, int n2)
{
    int deg = 1;
    for (int i = 0; i<n2; i++)
    {
        deg=deg*n1;
    }
    return deg;
}
Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число в введенной степени равно {degree(num1,num2)}");
