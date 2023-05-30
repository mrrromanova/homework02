Console.Clear();
Console.WriteLine("Введите первое число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = int.Parse(Console.ReadLine());
if (A>B)
{
    Console.Write($"max = {A}");
}
 
if (B>A)
 {
    Console.Write($"max = {B}");
 }

if (A==B)
{
    Console.Write("Числа равны");
}