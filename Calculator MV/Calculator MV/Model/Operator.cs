using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_MV.Model
{
     public abstract class Operator
    {
        public abstract double result(double Value1, double Value2);
    }
}

