// Выяснить является ли число чётным

int a;                             
Console.Write("Enter Number: ");
a = Console.Read();

switch (a % 2)
{
    case 1:
        Console.WriteLine("odd number");

        break;
    default:
        Console.WriteLine("Even number");
        break;
}