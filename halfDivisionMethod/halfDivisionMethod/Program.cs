class Program
{
    static double F(double x)
    {
        return (2 * Math.Sin(x) - Math.Atan(x));
    }
    static void Main(string[] args)
    {
        double a, b,c, epsilon, x;

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

        while (b - a > 2 * epsilon)
        {
            c = (a+b)/2;
            if ( F(a)*F(c) < 0) b = c; else a = c;
        }
        x = (a + b) / 2;
        Console.WriteLine($"Ноль в промежутке равен: {x} (x)");
    }
}