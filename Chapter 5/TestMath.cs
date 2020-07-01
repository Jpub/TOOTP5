using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestMath
{
    public class Math
    {

        public int swap(int a, int b)
        {

            int temp = 0;

            temp = a;
            a = b;
            b = temp;

            return temp;

        }

    }
    class TestMath
    {


        public static void Main()
        {
            Math myMath = new Math();
            myMath.swap(2, 3);
        }
    }

}
