// Показать чётные числа от 1 до N.

Console.WriteLine("Enter long: ");
int n = int.Parse(Console.ReadLine());
    
for (int i = 2; i <= n; i += 2)
    Console.WriteLine(i);