Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine($"{numberA} является большим числом, а {numberB} меньшим");
}
else
{
    Console.WriteLine($"{numberB} является большим числом, а {numberA} меньшим");
}