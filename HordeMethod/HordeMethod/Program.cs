class Program
{
    static double F(double x)
    {
        return (2 * Math.Sin(x) - Math.Atan(x));
    }
    static void Main(string[] args)
    {
        double a, b, c, d, epsilon,h, y, x, x0, x1;

        do
        {
            Console.Write("Введите а: ");
        }
        while (!double.TryParse(Console.ReadLine(), out a));

        do
        {
            Console.Write("Введите b: ");
        }
        while (!double.TryParse(Console.ReadLine(), out b));

        do
        {
            Console.Write("Введите epsilon: ");
        }
        while (!double.TryParse(Console.ReadLine(), out epsilon));

        h = (b - a) / 100;
        y = F(a);
        d = F(a + 2 * h) - 2 * F(a + h) + F(a);
        if (y * d < 0)
        {
            x0 = a;
            c = b;
        }
        else
        {
            x0= F(a + 2 * h) - 2 * F(a + h) + F(a);
            c = a;
        }
        x1 = (x0 * F(c) - c * F(x0)) / (F(c) - F(x0));
        while (Math.Abs(x1 - x0) > epsilon)
        {
            x0 = x1;
            x1 = (x0 * F(c) - c * F(x0)) / (F(c) - F(x0));
        }
        x = x1;
        Console.WriteLine($"Корень равен x:{x}");
    }
}