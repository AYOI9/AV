try
{
    Console.WriteLine("Введите значение t: ");
    double t = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение y: ");
    double y = Convert.ToDouble(Console.ReadLine());
    double Z = (2 * t + y * Math.Cos(t)) / (Math.Sqrt(y) + 4.831);
    Console.WriteLine($"Значение Z: {Z}");
}
catch
{
    Console.WriteLine("Введите верное значение:");
}
        