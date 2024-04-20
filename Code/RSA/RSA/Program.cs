namespace RSA
{
    class RSA { 
    
        public static int OClipMR(int a, int n)
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

            return x[i-1];
        }
        public static bool UCLN(int p, int q)
        {
            while (q != 0)
            {
                int t = q;
                q = p % q;
                p = t;
            }
            if (p == 1)
            {
                return true;
            }
            else return false;
        }
        
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
        public static void Main(String[] args)
        {
            int p, q;
            Console.WriteLine("Nhap p: "); p = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap q: "); q = int.Parse(Console.ReadLine());
            int n = p * q;
            int phiN = (p-1) * (q-1);
            int e = 2;
            for(int i = 2; i < phiN; i++)
            {
                if (UCLN(i, phiN))
                {
                    e = i; 
                    break;
                }
            }
            
            int d = OClipMR(e, phiN) < 0 ? OClipMR(e, phiN) + phiN : OClipMR(e, phiN);

            Console.WriteLine($"n = {n}");
            Console.WriteLine($"phiN = {phiN}");
            Console.WriteLine($"e = {e}");
            Console.WriteLine($"d = {d}");
            Console.WriteLine($"Khoa cong khai: ({n},{e})");
            Console.WriteLine($"Khoa bi mat: ({n},{d})");

            int m = 0;
            for(int i = 2; i < n; i++) {
                if(UCLN(i, n)) {
                    m = i; break;
                }
            }
            //Console.WriteLine("m = " + m);
            //Console.WriteLine(e);
            //Console.WriteLine(n);
            //int c = abmodn(m, e, n);
            //Console.WriteLine($"{m}^{e} mod {n} =" + c);

            //Console.WriteLine($"{c}^{d} mod {n} =" + abmodn(c, d, n));


            // su dung bit
            string bit;
            Console.WriteLine("Nhap bit: "); bit = Console.ReadLine();
            m = Convert.ToInt32(bit, 2);
            Console.WriteLine("m = " + m);
            Console.WriteLine(e);
            Console.WriteLine(n);
            int c = abmodn(m, e, n);
            Console.WriteLine($"{m}^{e} mod {n} =" + c);

            Console.WriteLine($"{c}^{d} mod {n} =" + abmodn(c, d, n));
        }
    }
}