/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/


Console.Clear();
Console.WriteLine("Введите первую цифру: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую цифру: ");
int numberB = int.Parse(Console.ReadLine());
 int max = 0;
 int min = 0;

 if ( numberA < numberB )
 {
    min = numberA;
    max = numberB  ;
    Console.Write( $"Максимальное число {numberB}, минимальное число {numberA}" );
 }
 else
 {
    min = numberB;
    max = numberA;
    Console.Write( $"Максимальное число {numberA}, минимальное число {numberB}" );
 }