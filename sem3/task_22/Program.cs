Console.WriteLine("Введите число N:");
int numberN = int.Parse(Console.ReadLine());
int count = 1;
while(count <= numberN)
{
    Console.Write($"{count*count}, ");
    count++;
}
Console.WriteLine();
for (int i=1; i<=numberN; i++)
{
    Console.Write($"{i*i}, ");
}
Console.WriteLine();