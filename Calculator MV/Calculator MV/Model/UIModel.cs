using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_MV.Model
{
    public class UIModel
    {
        public string Value1;
        public string Value2;
        public string operate;
        public double parseValue1;
        public double parseValue2;
        public double answer;
        Operator myOp;

        public UIModel(string Value1, string Value2, string operate)
        {
            this.Value1 = Value1;
            this.Value2 = Value2;
            this.operate = operate;
        }
        public bool operateValid(string operate)
        {
            if (operate == "+"|| operate == "-" || operate == "*" || operate == "/")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double inputParse(string value)
        {
            return Double.Parse(value);
        }
        public double parseAndReturn()
        {
            this.parseValue1 = inputParse(Value1);
            this.parseValue2 = inputParse(Value2);
            myOp = Factory.myOperator(operate);
            double answer = myOp.result(parseValue1, parseValue2);
            return answer;
        }
    }
}
