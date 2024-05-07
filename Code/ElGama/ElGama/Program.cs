namespace ElGama
{
    class ElGama
    {
        public static int abmodn(int a, int b, int n)
        {
            int i = 0;
            List<int> b1 = new List<int>();
            // convert b
            do
            {
                int mod = b % 2;
                b = b / 2;
                b1.Add(mod);
                i++;
            } while (b > 0);
            int f = 1;
            for (int j = b1.Count - 1; j >= 0; j--)
            {
                f = (f * f) % n;
                if (b1[j] == 1) f = (f * a) % n;

            }
            return f;
        }
        public static int Oclip(int a, int n)
        {
            int i = 2;
            int[] r = new int[100]; r[0] = n; r[1] = a;
            int[] x = new int[100]; x[0] = 0; x[1] = 1;
            int[] y = new int[100]; y[0] = 1; y[1] = 0;
            int[] q = new int[100];

            do
            {
                r[i] = r[i - 2] % r[i - 1];
                q[i] = r[i - 2] / r[i - 1];
                x[i] = x[i - 2] - q[i] * x[i - 1];
                y[i] = y[i - 2] - q[i] * y[i - 1];
                ++i;
            } while (r[i - 1] > 1);
            return x[i-1] < 0 ? x[i-1] + n : x[i-1];
        }
        public static void Main(string[] args)
        {
            int p, a, x, y;
            Console.WriteLine("Nhap p: "); p = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap a: "); a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap x: "); x = int.Parse(Console.ReadLine());

            y = abmodn(a, x, p);
            Console.WriteLine($"Khoa ca nhan: ({p},{a},{x})");
            Console.WriteLine($"Khoa cong khai: ({p},{a},{y})");

            int M;
            Console.WriteLine("Nhap thong diep M: "); M = int.Parse(Console.ReadLine());
            int k = 1;
            do
            {
                Console.WriteLine("Nhap k: ");
                k = int.Parse(Console.ReadLine());

            } while (k < 1 || k > p - 1);
            int K = abmodn(y, k, p);
            int c1 = abmodn(a, k, p);
            int c2 = (K * M) % p;

            Console.WriteLine($"Ma hoa: ({c1}, {c2})");

            // giai ma

            int K2 = abmodn(c1, x, p);
            Console.WriteLine(K2);
            int ktru1 = Oclip(K2, p);
            Console.WriteLine(ktru1);

            Console.WriteLine($"M = {(c2 * ktru1) % p}");
        }
    }
}
