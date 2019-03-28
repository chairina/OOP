using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    abstract class Calculator
    {
        public abstract double RunCalculator();
    }

    // CLASS RECTANGEL (PERSEGI PANJANG)
    class Rectangle : Calculator
    {
        double length;
        double width;
        public Rectangle (double a, double b)
        {
            length = a;
            width = b;
        }
        public override double RunCalculator()
        {
            //throw new NotImplementedException();
            return (2 * (width + length));
 
        }
    }

    // CLASS LINGAKARAN

        class Circle : Calculator
       {
        double JariJari;
        public Circle (double r)
        {
            JariJari = r;
        }
        public override double RunCalculator()
        {
            //throw new NotImplementedException();
            return (2 * (Convert.ToDouble(3.14))* JariJari);
        }
    }

    // CLASS SEGITIGA

    class Triangle : Calculator
    {
        double sisi1;
        double sisi2;
        double sisi3;
        double Result = 0;
        public Triangle (double a, double b, double c)
        {
            sisi1 = a;
            sisi2 = b;
            sisi3 = c;
        }
        public override double RunCalculator()
        {
            // throw new NotImplementedException();
            Result = (sisi1 + sisi2 + sisi3);
            return Result;
        }
    }

    class Trapesium : Calculator
    {
        double SideA;
        double SideB;
        double SideC;
        double SideD;

        public Trapesium (double d, double e, double f, double g)
        {
            SideA = d;
            SideB = e;
            SideC = f;
            SideD = g;
        }
        public override double RunCalculator()
        {
            //throw new NotImplementedException();
            return (SideA + SideB + SideC + SideD);
        }
    }
    class TugasOOP
    {
        static void Main(string [] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine(" Perhitungan Keliling ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(" \n Menu Pilihan: \n");
            Console.WriteLine(" 1.Segitiga");
            Console.WriteLine(" 2.Lingkaran");
            Console.WriteLine(" 3.Persegi Panjang");
            Console.WriteLine(" 4.Trapesium");
            Console.WriteLine("---------------------------------");
            Console.Write(" Masukkan pilihanmu = ");
             
            int nomor = Convert.ToInt32(Console.ReadLine());
           
            if (nomor == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Keliling Segitiga");
                Console.Write("Masukkan Sisi 1 = ");
                double S1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan Sisi 2 = ");
                double S2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan Sisi 3 = ");
                double S3 = Convert.ToDouble (Console.ReadLine());
                Calculator c = new Triangle(S1, S2, S3);
                double h = c.RunCalculator();
                Console.Write("Keliling = " + h);
            } else if (nomor == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Keliling Lingkaran");
                Console.Write("Masukkan Jari - jari = ");
                Double J1 = Convert.ToDouble(Console.ReadLine());
                Calculator c1 = new Circle(J1);
                double s = c1.RunCalculator();
                Console.Write("Keliling = " + s);
            } else if (nomor == 3)
            {
               Console.WriteLine();
                Console.WriteLine("Keliling Persegi Panjang");
                Console.Write("Masukkan Panjang = ");
                double P = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan Lebar = ");
                double L= Convert.ToDouble(Console.ReadLine());
                Calculator c2 = new Rectangle(P, L);
                double y = c2.RunCalculator();
                Console.Write("Keliling = " + y);
            } else
            {
                Console.WriteLine();
                Console.WriteLine("Keliling Trapesium");
                Console.Write("Masukkan Sisi 1 = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan Sisi 2 = ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan Sisi 3 = ");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.Write("Masukkan Sisi 4 = ");
                double d = Convert.ToDouble(Console.ReadLine());
                Calculator c3 = new Trapesium(a, b, c, d);
                double x = c3.RunCalculator();
                Console.Write("Keliling = " + x);
            }
            Console.Read();
        }
    }
}
