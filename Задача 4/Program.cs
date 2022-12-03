Console.WriteLine("Введите первое число");
int firstnumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondnumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int thirdnumber = int.Parse(Console.ReadLine());
int max = 0;

if (firstnumber>=secondnumber & secondnumber>=thirdnumber)
{
    max = firstnumber;
    Console.Write("Максимальное из чисел -> ");
    Console.WriteLine(max);
}
else
{
    if (secondnumber>=thirdnumber)
    {
        max = secondnumber;
        Console.Write("Максимальное из чисел -> ");
        Console.WriteLine(max);
    }
    else
    {
        max = thirdnumber;
        Console.Write("Максимальное из чисел -> ");
        Console.WriteLine(max);
    }
}