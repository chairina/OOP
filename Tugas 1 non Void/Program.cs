//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tugas_1_non_Void
//{
//    class Program
//    {
//        static Program calling = new Program();
//        static void Main(string[] args)
//        {
//            calling.View();
//        }

//        public void View()
//        {
//            decimal bil1, bil2;
//            Console.Write("Insert number (1) : ");
//            bil1 = Convert.ToDecimal(Console.ReadLine());
//            Console.Write("Insert number (2) : ");
//            bil2 = Convert.ToDecimal(Console.ReadLine());

//            Console.Write("Result : " + calling.process(bil1, bil2));
//            Console.Read();
//        }
//        public decimal process (decimal bil1, decimal bil2)
//        {
//            decimal hasil = 0;
//            if (bil2 > 0)
//            {
//                for (int i = 1; i <= bil2; i++)
//                {
//                    hasil = hasil + bil1;
//                }
//            }
//            else
//            {
//                for (decimal i = bil2; i < 0; i++)
//                {
//                    hasil = hasil - bil1;
//                }
//            }
//            return hasil; 
//        }
//    }
//}
