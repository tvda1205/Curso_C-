﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv_Composicao.Entities
{
    class Department
    {
        public string Name { get; set; }

        public Department()
        {
        }

        public Department(string name)
        {
            this.Name = name;
        }
    }
}
