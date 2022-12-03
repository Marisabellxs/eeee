Console.WriteLine("Введите первое число");
int firstnumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondnumber = int.Parse(Console.ReadLine());
int max = 0;

if (firstnumber>secondnumber)
{
    max = firstnumber;
    Console.Write("Max = ");
    Console.WriteLine(max);
}
else
{
    max = secondnumber;
    Console.Write("Max = ");
    Console.WriteLine(max);
}
