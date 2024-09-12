using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    class ConversorMoeda
    {
        public static double Iot = 6.0;

        public static double Converter(double c, double d)
        {
            double conversor = c * d;
            return conversor + conversor * (Iot / 100);

        }
    }
}
