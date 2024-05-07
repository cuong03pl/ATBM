namespace abmodn
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, n, b, i = 0;
            List<int> b1 = new List<int>();
            Console.WriteLine("Nhap a: "); a = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Nhap b: "); b = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Nhap n: "); n = int.Parse(Console.ReadLine());
            // convert b
            while(b>0) /// sua
            {
                int mod = b % 2;
                b = b / 2;
                Console.WriteLine("mod: " + mod);

                b1.Add(mod);
                i++;
            } 
            int f = 1;
            for (int j = b1.Count - 1; j >= 0 ; j--)
            {
                f = (f * f) % n;
                if (b1[j] == 1) f = (f * a) % n;
                
            }
            
            Console.WriteLine($"F = "+ f);
        }
    }
}