using System;
using Maths.Matrixes;
using System.Collections;
using System.Collections.Generic;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(3, 3);

            m1.InsertAt(2,0,0);
            m1.InsertAt(5, 0, 1);
            m1.InsertAt(3, 0, 2);

            m1.InsertAt(1, 1, 0);
            m1.InsertAt(2, 1, 1);
            m1.InsertAt(4, 1, 2);

            m1.InsertAt(4, 2, 0);
            m1.InsertAt(1, 2, 1);
            m1.InsertAt(1, 2, 2);


            Matrix m2 = new Matrix(3, 2);
            m2.InsertAt(1,0,0);
            m2.InsertAt(2,1,0);
            m2.InsertAt(3,2,0);

            m2.InsertAt(4, 0, 1);
            m2.InsertAt(3, 1, 1);
            m2.InsertAt(2, 2, 1);


            Matrix m3 = new Matrix(2, 2, new List<int>() { 1,2,3,4 });


            Console.WriteLine(m1*m2);
            Console.WriteLine(m1-1);
            Console.WriteLine(m3);



        }
    }
}
