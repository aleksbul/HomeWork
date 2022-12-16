// Напишите программу, которая на вход принимает число N, 
// а на выходе показывает все четные числа от 1 до N.

Console.WriteLine("Введите число");

int N = Convert.ToInt32(Console.ReadLine());
int i;
int x;
if(N > 0)
{
    i = 2;
    x = 2;
}
else 
{
    i = 0;
    x = -2;
}
for (; Math.Abs(i) < Math.Abs(N); i+=x)
{
    Console.Write(i + " ");
}
