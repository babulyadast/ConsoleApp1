namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double z = -0.5;
            double x = 1.7;
            double c = 0.44;

            double v = Math.Pow(2.7,(-x * c)) * Math.Sin(z * c + x) - Math.Sqrt(Math.Abs(x * c + z));
            double b = x * Math.Sin(Math.Pow((z * c), 2) * Math.Cos(z * c)) - 1;

            Console.WriteLine("v = {0}",v);
            Console.WriteLine("b = {0}",b);
            Console.ReadKey();
        }
    }
}