Console.WriteLine("Введите номер четверти 1-4: ");
int num = int.Parse(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("х > 0 и  y >0");
}
else
if (num == 2)
{
    Console.WriteLine("х < 0 и  y >0");
}
else
if (num == 3)
{
    Console.WriteLine("х < 0 и  y <0");
}
else 
if (num == 4)
{
    Console.WriteLine("х > 0 и  y <0");
}
else
{
    Console.WriteLine("Введите корректный номер четверти от 1 до 4");
}