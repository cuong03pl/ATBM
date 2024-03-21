namespace Caesar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listSo = new List<int>();
            string chuoi;
            int k;
            string chuoimahoa = "";
            Console.WriteLine("Nhap chuoi: ");  chuoi = Console.ReadLine();
            Console.WriteLine("Nhap n: "); k = int.Parse( Console.ReadLine());
            foreach (char item in chuoi)
            {
                chuoimahoa += (char.ToUpper((char)((((char.ToLower(item) - 'a') + k) % 26) + 'a')));
            }
            Console.WriteLine("Sau khi ma hoa: " + chuoimahoa);

            string chuoigiaima = "";
            foreach (char item in chuoimahoa)
            {
                chuoigiaima += (char.ToUpper((char)((((char.ToLower(item) - 'a') - k) % 26) + 'a')));
            }
            Console.WriteLine("Sau khi gia ma: " + chuoigiaima);
        }
    }
}
