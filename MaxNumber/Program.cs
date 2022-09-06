// Программа, которая принимает на вход три числа и выдает максимальное из этих чисел.

{
    Console.WriteLine("ВВЕДИТЕ ТРИ ЧИСЛА ДЛЯ СРАВНЕНИЯ");
    int a, b, c;
    Console.Write("Введите первое число: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число: ");
    c = Convert.ToInt32(Console.ReadLine());

    {
        int max = a;

        if (a > max) max = a;
        if (b > max) max = b;
        if (c > max) max = c;

        Console.Write("Максимальное число: max = ");
        Console.WriteLine(max);
    }
    
}
