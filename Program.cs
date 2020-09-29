using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloads
{
    class Square
    {
        int a;
        public int A
        {
            get { return a; }
            set
            {
                if (value < 1)
                    a = 1;
                else
                    a = value;
            }
        }

        public Square() : this(1) { }

        public Square(int a)
        {
            A = a;
        }

        public override string ToString()
        {
            return $"Square: A - {A}";
        }


        public static Square operator ++(Square s)
        {
            s.A++;
            return s;
        }

        public static Square operator --(Square s)
        {
            if (s.A - 1 < 1)
                throw new Exception("Operation is not possible!");
            else
                s.A--;
            return s;
        }

        public static Square operator +(Square s1, Square s2)
        {
            Square s3 = new Square
            {
                A = s1.A + s2.A,

            };
            return s3;
        }

        public static Square operator -(Square s1, Square s2)
        {
            Square s3 = new Square
            {
                A = s1.A - s2.A,

            };

            if (s3.A < 1)
                throw new Exception("Operation is not possible!");
            else
                return s3;
        }

        public static Square operator *(Square s1, Square s2)
        {
            Square s3 = new Square
            {
                A = s1.A * s2.A,

            };
            return s3;
        }

        public static Square operator /(Square r1, Square r2)
        {

            Square s3 = new Square
            {
                A = r1.A / r2.A,

            };
            return s3;
        }

        public static bool operator ==(Square s1, Square s2)
        {
            return s1.Equals(s2);
        }

        public static bool operator !=(Square s1, Square s2)
        {
            return !(s1 == s2);
        }

        public static bool operator >(Square s1, Square s2)
        {
            return s1.A > s2.A;
        }

        public static bool operator <(Square s1, Square s2)
        {
            return !(s1 > s2);
        }


        public static bool operator >=(Square s1, Square s2)
        {
            return s1.A > s2.A;
        }

        public static bool operator <=(Square s1, Square s2)
        {
            return !(s1 > s2);
        }

        public static bool operator true(Square s)
        {
            return s.A != 0;
        }

        public static bool operator false(Square s)
        {
            return s.A == 0;
        }

        public static implicit operator int(Square s)
        {
            return s.A * s.A;
        }
        public static implicit operator Rectangle(Square s)
        {
            return new Rectangle(s.A, s.A + s.A);
        }

        public override bool Equals(object obj)
        {
            return obj is Square square &&
                   A == square.A;
        }

        public override int GetHashCode()
        {
            return -862436692 + A.GetHashCode();
        }
    }


    class Rectangle
    {
        int a;
        public int A
        {
            get { return a; }
            set
            {
                if (value < 1)
                    a = 1;
                else
                    a = value;
            }
        }

        int b;
        public int B
        {
            get { return b; }
            set
            {
                if (value < 1)
                    b = 1;
                else
                    b = value;
            }
        }

        public Rectangle() : this(1, 1) { }
        public Rectangle(int a, int b)
        {
            A = a;
            B = b;
        }

        public static Rectangle operator ++(Rectangle r)
        {
            r.A++;
            r.B++;
            return r;
        }

        public static Rectangle operator --(Rectangle r)
        {
            if (r.A - 1 < 1 || r.B - 1 < 1)
            {
                throw new Exception("Operation is not possible!");
            }
            else
            {
                r.A--;
                r.B--;
            }
            return r;
        }

        public static Rectangle operator +(Rectangle r1, Rectangle r2)
        {
            Rectangle r3 = new Rectangle
            {
                A = r1.A + r2.A,
                B = r1.B + r2.B
            };
            return r3;
        }

        public static Rectangle operator -(Rectangle r1, Rectangle r2)
        {
            Rectangle r3 = new Rectangle
            {
                A = r1.A - r2.A,
                B = r1.B - r2.B
            };

            if (r3.A < 1 || r3.B < 1)
                throw new Exception("Operation is not possible!");
            else
                return r3;
        }

        public static Rectangle operator *(Rectangle r1, Rectangle r2)
        {
            Rectangle r3 = new Rectangle
            {
                A = r1.A * r2.A,
                B = r1.B * r2.B
            };
            return r3;
        }

        public static Rectangle operator /(Rectangle r1, Rectangle r2)
        {
            if (r2.A == 0 || r2.B == 0)
            {
                throw new DivideByZeroException("Second operand = 0");
            }
            else
            {
                Rectangle r3 = new Rectangle
                {
                    A = r1.A / r2.A,
                    B = r1.B / r2.B
                };
                return r3;
            }
        }

        public static bool operator ==(Rectangle r1, Rectangle r2)
        {
            return r1.Equals(r2);
        }

        public static bool operator !=(Rectangle r1, Rectangle r2)
        {
            return !(r1 == r2);
        }

        public static bool operator >(Rectangle r1, Rectangle r2)
        {
            return r1.A + r1.B > r2.A + r2.B;
        }

        public static bool operator <(Rectangle r1, Rectangle r2)
        {
            return !(r1 > r2);
        }


        public static bool operator >=(Rectangle r1, Rectangle r2)
        {
            return r1.A + r1.B > r2.A + r2.B;
        }

        public static bool operator <=(Rectangle r1, Rectangle r2)
        {
            return !(r1 > r2);
        }

        public static bool operator true(Rectangle r)
        {
            return r.A != 0 || r.B != 0;
        }

        public static bool operator false(Rectangle r)
        {
            return r.A == 0 && r.B == 0;
        }

        public static explicit operator int(Rectangle r)
        {
            return r.A + r.B;
        }
        public static explicit operator Square(Rectangle r)
        {
            if (r.A > r.B)
                return new Square(r.A);
            else
                return new Square(r.B);
        }

        public override string ToString()
        {
            return $"Rectangle: A - {A}, B - {B}";
        }

        public override bool Equals(object obj)
        {
            return obj is Rectangle rectangle &&
                   A == rectangle.A &&
                   B == rectangle.B;
        }

        public override int GetHashCode()
        {
            var hashCode = -1817952719;
            hashCode = hashCode * -1521134295 + A.GetHashCode();
            hashCode = hashCode * -1521134295 + B.GetHashCode();
            return hashCode;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square s1 = new Square(5);
            Square s2 = new Square(3);

            Console.WriteLine($"S1: {s1}\nS2: {s2}\n");

            Console.WriteLine($"S1++ : {s1++}\nS1-- : {s1--}\n");
            Console.WriteLine($"S2++ : {s2++}\nS2-- : {s2--}\n");

            Console.WriteLine($"S3=S1+S2 : {s1 + s2}");
            Console.WriteLine($"S4=S1-S2 : {s1 - s2}\n");

            if (s1 > s2)
                Console.WriteLine($"s1>s2\n");
            else
                Console.WriteLine("s2>s1\n");

            Rectangle r1 = new Rectangle(2, 4);
            Rectangle r2 = new Rectangle(5, 2);

            Console.WriteLine($"R1: {r1}\nR2: {r2}\n");
            Console.WriteLine($"R1*R2= {r1 * r2}\n");

            Console.WriteLine($"R1/R2= {r1 / r2}\n");

            if (r1 == r2)
                Console.WriteLine($"R1 = R2\n");
            else

                Console.WriteLine($"R1 != R2\n");

            if(r1)
                Console.WriteLine("TRUE");
            else
                Console.WriteLine("FALSE");

            int a , b;

            a = s1;
            Console.WriteLine($"Square to INT: {a}");
           
            b =(int) r1;
            Console.WriteLine($"Rectangle to INT: {b}");

            Rectangle reqToSq = s1;
            Console.WriteLine($"Square to Rectangle {reqToSq}");

            Square sqToReq = (Square)r1;
            Console.WriteLine($"Rectangle to Square: {sqToReq}");
        }
    }
}
