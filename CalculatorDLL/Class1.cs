using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDLL
{
    public class Class1
    {
        int resulat;
        enum CALC { SUM = '+', SUB = '-', MUL = '*', DIV = '/', RES = '%' };

        public int Calculation(int num1, int num2, char op)
        {
            switch ((CALC)op)
            {
                case CALC.SUM: resulat = num1 + num2;
                    break;

                case CALC.SUB: resulat = num1 - num2;
                    break;

                case CALC.MUL: resulat = num1 * num2;
                    break;

                case CALC.DIV: resulat = num1 / num2;
                    break;

                case CALC.RES: resulat = num1 % num2;
                    break;
            }
            return resulat;
        }
    }
}
