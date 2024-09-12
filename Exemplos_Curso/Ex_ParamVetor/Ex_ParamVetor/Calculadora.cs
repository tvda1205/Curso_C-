using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_ParamVetor
{
    class Calculadora
    {
        public static int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }


        public static void Triple(ref int x)
        {
            x = x * 3;
        }

        public static void Triple2(int origin, out int result)
        {
            result = origin * 3;
        }

    }
}
