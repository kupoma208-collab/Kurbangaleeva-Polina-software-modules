namespace Лабораторная_работа_10_11__3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N1 = ");
            int N1 =
                Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("M1 =");
            int M1 =
                Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("N2 =");
            int N2 =
                Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("M2 = ");
            int M2 =
                Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B = ");
            int B =
                Convert.ToInt32(Console.ReadLine());
            int P1 = N1 * M1;
            int P2 = N2 * M2;
            int P = P1 + P2;
            long Bytes = (long)P * B;
            double MB = Bytes / (1024.0 * 1024.0);
            Console.WriteLine("P1 = " + P1);
            Console.WriteLine("P2 = " + P2);
            Console.WriteLine("P = " + P);
            Console.WriteLine("Bytes = " + Bytes);
            Console.WriteLine("MB = " + MB);
            Console.ReadLine();

        }
    }
}
