class Program
{
    static double F(double x)
    {
        return (2 * Math.Sin(x) - Math.Atan(x));
    }
    static void Main(string[] args)
    {
        double a, b, h, x1, x2, y1, y2;

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
            Console.Write("Введите h: ");
        }
        while (!double.TryParse(Console.ReadLine(), out h));

        x1 = a;
        x2 = a + h;
        y1 = F(x1);
        while (x2 < b)
        {
            y2 = F(x2);
            if (y1 * y2 < 0)
                Console.WriteLine($"x1: {Math.Round(x1, -(int)Math.Log10(h))}\tx2:{Math.Round(x2, -(int)Math.Log10(h))}");
            x1 = x2;
            x2 = x1+h;
            y1 = y2;
        }
    }
}