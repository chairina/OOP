//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tugas_1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int bil1, bil2, hasil = 0;
//            Console.Write("Insert number (1) : ");
//            bil1 = Convert.ToInt16(Console.ReadLine());
//            Console.Write("Insert number (2) : ");
//            bil2 = Convert.ToInt16(Console.ReadLine());
//            // Console.Write( bil1 + "X" + bil2 + " adalah ");
//            if (bil2 > 0) {
//                for (int i = 1; i <= bil2; i++)
//                {
//                    hasil = hasil + bil1;
//                }
//                Console.Write("Result : " + hasil);
//            }
//            else if (bil2 < 0) {
//                bil2 = bil2 * -1;
//                for (int i = 1; i <= bil2; i++)
//                {
//                    hasil = hasil + bil1;
//                }
//                Console.Write("Result : " + hasil * -1);
//            }
//            else
//            {
//                Console.Write("Result : 0");
//            }
//            Console.Read();
//        }
//    }
//}
