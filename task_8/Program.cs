//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int posNumber=Convert.ToInt32(Console.ReadLine());
int help=2;
    while (posNumber>=help)
    {
   Console.Write(help+" "); 
   help+=2;
    }