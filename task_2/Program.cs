//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
System.Console.WriteLine("Введите первое число:");
int firstNumber=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int secondNumber=Convert.ToInt32(Console.ReadLine());
if (firstNumber>=secondNumber)
{
  if (firstNumber>secondNumber)
  {
    System.Console.WriteLine("Большее число:"+firstNumber+", меньшее число:"+secondNumber);
  } 
  else System.Console.WriteLine("Числа равны"); 
}
else System.Console.WriteLine("Большее число:"+secondNumber+", меньшее число:"+firstNumber);