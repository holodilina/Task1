// Программа, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

{
Console.Write("ВВЕДИТЕ ЧИСЛО: ");

int a;
a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
Console.WriteLine("ДА, число является чётным");

else
Console.Write("НЕТ, число нечётное");
Console.ReadKey();

}
