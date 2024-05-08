using System;

namespace Affine
{
    class Program
    {
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

            return x[i - 1] < 0 ? x[i-1] + n : x[i-1];
        }
        static void Main(string[] args)
        {
            int a = 7; int b = 5;
            string m = "VN";
            string chuoimahoa = "";
            foreach (char item in m)
            {
                int x = item - 65;
                chuoimahoa += (char)(((a * x + b) % 26) + 65);
            }
            Console.WriteLine("Chuoi sau khi ma hoa: " +  chuoimahoa);


            // giai ma
            foreach (var item in chuoimahoa)
            {
                int y = item - 65;
                Console.WriteLine((char)(((Oclip(a, 26) * (y - b)) % 26) + 65));
            }
        }
    }
}
