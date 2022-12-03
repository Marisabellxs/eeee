Console.WriteLine("Введите первое число");
int firstnumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondnumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int thirdnumber = int.Parse(Console.ReadLine());

if (firstnumber>=secondnumber & secondnumber>=thirdnumber)
{
    Console.WriteLine("Первое число максимальное");
}
else
{
    if (secondnumber>=thirdnumber)
    {
        Console.WriteLine("Второе число максимальное");
    }
    else
    {
        Console.WriteLine("Третье число максимальное");
    }
}