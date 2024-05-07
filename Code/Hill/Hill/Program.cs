
namespace Oclip
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int N = 26;
            int M;
            int[,] K = new int[2,2];
            int[,] H = new int[2, 2];
            string P;

            //Console.WriteLine("Nhap M: "); M = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap P: "); P = Console.ReadLine();

            // nhap ma tran K
            Console.WriteLine("Nhap ma tran K");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    K[i, j] = int.Parse(Console.ReadLine());
                }
            }


            int q = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    H[i, j] = char.ToLower(P[q]) - 'a';
                    q++;
                }
            }
           
            List<int> l = new List<int>();
            
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int z = 0;
                    for(int k = 0; k < 2; k++)
                    {
                        z += H[i, k] * K[k, j];
                    }
                    l.Add(z % 26);
                }
            }

            Console.Write("chuoi sau khi ma hoa: ");
            foreach (var item in l)
            {
                Console.Write((char)('A' + (item)));

            }
        }
    }
}