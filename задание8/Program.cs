Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int even = 2;
while(even <= number)
{
    if(even % 2 == 0)
    {
        Console.Write($"{even}, ");
        even++;
    }
    else
    {
        even++;
    }
}