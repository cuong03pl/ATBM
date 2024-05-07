using System;
using System.Collections.Generic;

namespace Caesar
{
    class Program
    {
        static void Main(string[] args)
        {
            string chuoi;
            int k;
            string chuoimahoa = "";
            Console.WriteLine("Nhap chuoi: ");
            chuoi = Console.ReadLine();
            Console.WriteLine("Nhap n: ");
            k = int.Parse(Console.ReadLine());
            foreach (char item in chuoi)
            {
                if (char.IsLetter(item))
                {
                    int offset = char.IsUpper(item) ? 65 : 97; // 65 là mã ASCII của "A", 97 là mã ASCII của "a"). 
                    // item-offset chuyển mã kí tự thành số nguyên từ 0-25
                    // + k để biết vị trí của nó khi mã hóa thành
                    // + offset để chuyển số nguyên thành một mã ascii 
                    chuoimahoa += (char)((((item-offset) + k) % 26) + offset);

                }
                else
                {
                    chuoimahoa += item;
                }
            }
            Console.WriteLine("Sau khi ma hoa: " + chuoimahoa);

            string chuoigiaima = "";
            foreach (char item in chuoimahoa)
            {
                if (char.IsLetter(item))
                {
                    int offset = char.IsUpper(item) ? 65 : 97;
                    chuoigiaima += (char)((((item - offset) + (26-k)) % 26) + offset);
                }
                else
                {
                    chuoigiaima += item;
                }
            }
            Console.WriteLine("Sau khi gia ma: " + chuoigiaima);
        }
    }
}
