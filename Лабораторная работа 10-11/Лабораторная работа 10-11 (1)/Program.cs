namespace Лабораторная_работа_10_11__1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a1 = ");
            double a1 =
                Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a2 =");
            double a2 =
                Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a3 =");
            double a3 =
                Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b1 = ");
            double b1 =
                Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b2 =");
            double b2 =
                Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b3 =");
            double b3 =
                Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("alpha = ");
            double alpha =
                Convert.ToDouble(Console.ReadLine());
            double c1 = alpha * a1 + (1 - alpha) * b1;
            double c2 = alpha * a2 + (1 - alpha) * b2;
            double c3 = alpha * a3 + (1 - alpha) * b3;
            double L = Math.Sqrt(c1 * c1 + c2 * c2 + c3 * c3);
            Console.WriteLine("c1 = " + c1);
            Console.WriteLine("c2 = " + c2);
            Console.WriteLine("c3 = " + c3);
            Console.WriteLine("L = " + L);
            Console.ReadLine();

        }
    }
}
