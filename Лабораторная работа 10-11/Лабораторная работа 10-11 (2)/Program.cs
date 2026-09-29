namespace Лабораторная_работа_10_11__2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x1 = ");
            double x1 =
                Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x2 =");
            double x2 =
                Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x3 =");
            double x3 =
                Convert.ToDouble(Console.ReadLine());
            double e1 = Math.Exp(x1);
            double e2 = Math.Exp(x2);
            double e3 = Math.Exp(x3);
            double S = e1 + e2 + e3;
            double q = Math.Log(S);
            Console.WriteLine("e1 = " + e1);
            Console.WriteLine("e2 = " + e2);
            Console.WriteLine("e3 = " + e3);
            Console.WriteLine("S = " + S);
            Console.WriteLine("q = " + q);
            Console.ReadLine();

        }
    }
}
