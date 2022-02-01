// Даны два числа. Показать большее и меньшее число

 Console.WriteLine("Enter num1: ");
 int num1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Enter num2: ");
 int num2 = Convert.ToInt32(Console.ReadLine());
 
 if(num1 > num2)
 {
     Console.WriteLine("The first number is greater than the second");
 }
 else if (num1 < num2)
 {
     Console.WriteLine("The first number is less than the second");
 }
  else
 {
     Console.WriteLine("Both numbers are equal");
 }
