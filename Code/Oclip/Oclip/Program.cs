
namespace Oclip
{
    class Program
    {
        static public void nhap()
        {
            
        }
        static void Main(string[] args)
        {
            int a, n;
            Console.WriteLine("Nhap a: "); a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap n: "); n = int.Parse(Console.ReadLine());

            int i = 2;
            int[] r = new int[100] ;r[0] = n; r[1] = a;
            int[] x = new int[100] ; x[0] = 0; x[1] = 1;
            int[] y = new int[100] ; y[0] = 1; y[1] = 0;
            int[] q = new int[100];

            do
            {
                r[i] = r[i-2] % r[i-1];
                q[i] = r[i - 2] / r[i - 1];
                x[i] = x[i-2] - q[i] * x[i-1];
                y[i] = y[i-2] - q[i] * y[i-1];
                ++i;
            } while (r[i-1] > 1);
            Console.WriteLine(" Vay x = " + x[i - 1] + "  va  y = " + y[i - 1]);
        }
    }
}
