//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPPolymorphism
//{
//    abstract class Process
//    {
//        public abstract decimal Processing();
//    }

//    class Rectangle : Process
//    {
//        int length;
//        int width;
//        public Rectangle (int a=0, int b=0)
//        {
//            length = a;
//            width = b;
//        }


//        public override decimal Processing()
//        {
//           // throw new NotImplementedException();
//            return (width * length);
//        }
//    }

//    class Shape : Process
//    {
//        int length1;
//        int width1;
//        public Shape(int a = 0, int b = 0)
//        {
//            length1 = a;
//            width1 = b;
//        }
//        public override decimal Processing()
//        {
//            // throw new NotImplementedException();
//            return (2 * (width1 + length1));
//        }
//    }
//    class RectangelProcess
//    { 
//        static void Main(string[] args)
//        {

//            Process P = new Rectangle(10,7);
//            decimal c = P.Processing();
//            Console.WriteLine("Result : " + c);

//            Process P1 = new Shape(7, 7);
//            decimal c1 = P1.Processing();
//            Console.WriteLine("Result : " + c1);

//            Console.Read();
//        }
//    }
   
//}
