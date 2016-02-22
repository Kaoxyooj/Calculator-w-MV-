using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_MV.Model
{
    class Factory
    {
        public static Operator myOperator(string theOperator)
        {
            switch (theOperator)
            {
                case "+":
                    return new Addition();
                case "-":
                    return new Subtract();
                case "*":
                    return new Multiply();
                case "/":
                    return new Divide();
                default:
                    return null;
            }
        }
    }
}
