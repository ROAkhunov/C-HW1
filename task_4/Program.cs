// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("Введите первое число: ");
int firstNumber= Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int secondNumber= Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
int firdNumber= Convert.ToInt32(Console.ReadLine());
if (firstNumber>=secondNumber)
{
if (firstNumber>=firdNumber)
{
System.Console.WriteLine("Максимально число:"+firstNumber);    
}
else System.Console.WriteLine("Максимально число:"+firdNumber);  
}
else
{
  if (secondNumber>=firdNumber)
{
System.Console.WriteLine("Максимально число:"+secondNumber);    
}
else System.Console.WriteLine("Максимально число:"+firdNumber);    
}