﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_MV.Model
{
    public class Subtract : Operator
    {
        public override double result(double Value1, double Value2)
        {
            return Value1 - Value2;
        }
    }
}
