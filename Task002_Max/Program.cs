Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
if (B == A)
{
    Console.WriteLine("Числа равны");
}
else
{
    if (B > A)
    {
        Console.WriteLine("Число " + B + " больше чем " + A);
    }
    else
    {
        Console.WriteLine("Число " + A + " больше чем " + B);
    }
}