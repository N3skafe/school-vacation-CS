using System;
using CalculatorDLL;

namespace Tutorial01
{
    internal class Cal
    {
        //enum CALC { SUM = '+', SUB = '-', MUL = '*', DIV = '/', RES ='%'};
        //enum STATE { IDEL, WORK};
        //TYPE
        static Class1 calClass = new Class1();

        static void Main()
        {
            int num1, num2;
            char op;

            //input system
            Console.Write("number 1: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("number 2: ");
            num2= Int32.Parse(Console.ReadLine()) ;
            Console.WriteLine("Sum (+), Sub (-), Mul (*), Div (/), Res (%)");
            op = (char)Console.Read(); //this one return a string, so we force to 'char'

            //calculating
            /*
            switch ((CALC)op)
            {
                case CALC.SUM:
                    Console.WriteLine(num1 + num2);
                    break;

                case CALC.SUB:
                    Console.WriteLine(num1 - num2);
                    break;

                case CALC.MUL:
                    Console.WriteLine(num1 * num2);
                    break;

                case CALC.DIV:
                    Console.WriteLine(num1 / num2);
                    break;

                case CALC.RES:
                    Console.WriteLine(num1 % num2);
                    break;
            */
            Console.WriteLine(calClass.Calculation(num1, num2, op));
            
        }
    }
}
