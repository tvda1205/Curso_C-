﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv_Composicao.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValueHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valueHour, int hours)
        {
            Date = date;
            ValueHour = valueHour;
            Hours = hours;
        }


        public double TotalValue ()
        {
            return Hours * ValueHour;
        }
    }
}
