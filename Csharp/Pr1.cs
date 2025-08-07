using System;
using System.Text;
using System.Collections;

namespace Tutorial01
{
    /// <summary>
    /// Program Class : Main Class
    /// </summary>
    internal class Pr1 { }
    class StringApp
    {
        static void Main2(string[] args)
        {
            #region part1,2
            Console.WriteLine("what's up bro, welcome to our world.");
            #endregion
            #region part 3
            /*
            //변수 선언
            string strNum1, strNum2;
            int intNum1, intNum2, sum;

            //입력 처리
            Console.WriteLine("type any number what you want");
            strNum1 = Console.ReadLine();
            Console.WriteLine("also type second number whatever you want");
            strNum2 = Console.ReadLine();

            //계산 처리
            intNum1=Int32.Parse(strNum1);
            //System.Convert.ToInt32(intNum1);
            intNum2 =Int32.Parse(strNum2);
            sum = intNum1 + intNum2;

            //출력 처리
            Console.WriteLine("\n Sum is :{0}", sum);*/
            #endregion
            #region part 4
            /*
            StringApp obj =new StringApp();
            string str = "class name is ";
            Console.WriteLine(str + obj.ToString());

            StringBuilder sb = new StringBuilder();
            sb.Append(str);
            sb.Append(obj.ToString());
            Console.WriteLine(sb);

            Console.WriteLine("String type : " + obj.GetType().ToString());
            */
            #endregion
            #region part 5
            /*
            // 산술연산자 : +, -, *, /, %
            int a = 10, b = 3;
            Console.WriteLine(a + b);  // 13
            Console.WriteLine(a - b);  // 7
            Console.WriteLine(a * b);  // 30
            Console.WriteLine(a / b);  // 3
            Console.WriteLine(a % b);  // 1

            // 할당 연산자 (+=, -=, *=, /=, %=)
            int x = 5;
            Console.WriteLine(x += 3); // x = x + 3 => 8
            Console.WriteLine(x -= 2); // x = x - 2 => 6
            Console.WriteLine(x *= 4); // x = x * 4 => 24
            Console.WriteLine(x /= 2); // x = x / 2 => 12
            Console.WriteLine(x %= 5); // x = x % 5 => 2 

            // 증감연산자 (y++, ++y, y--, --y)
            int y = 10;
            Console.WriteLine(y++);    // 10 (후위 증가, 나중에 +1)
            Console.WriteLine(++y);    // 12 (전위 증가, 먼저 +1)
            Console.WriteLine(y--);    // 12 (후위 감소)
            Console.WriteLine(--y);    // 10 (전위 감소)

            // 비교연산자 (==, !=, <, >, <=, >=)
            int c = 10, d = 20;
            Console.WriteLine(c == d); // false
            Console.WriteLine(c != d); // true
            Console.WriteLine(c < d);  // true
            Console.WriteLine(c > d);  // false
            Console.WriteLine(c >= d); // false
            Console.WriteLine(c <= d); // true

            // 논리연산자 (&&, ||, !)
            bool t = true, f = false;
            Console.WriteLine(t && f); // false (AND)
            Console.WriteLine(t || f); // true (OR)
            Console.WriteLine(!t);     // false (NOT)

            // 비트연산자 (&, |, ^, ~, <<, >>)
            int i = 6; // 0110
            int j = 3; // 0011
            Console.WriteLine(i & j);  // 2 (AND) -> 0010
            Console.WriteLine(i | j);  // 7 (OR) -> 0111
            Console.WriteLine(i ^ j);  // 5 (XOR) -> 0101
            Console.WriteLine(~i);     // -7 (NOT, 보수)
            Console.WriteLine(i << 1); // 12 (왼쪽 시프트)
            Console.WriteLine(i >> 1); // 3 (오른쪽 시프트)

            // 조건연산자 (?:) ->삼항연산자
            int score = 85;
            string result = (score >= 60) ? "Pass" : "Fail";
            Console.WriteLine(result); // Pass

            // 널 병합 연산자
            string name = null;
            string displayName = name ?? "Unknown";
            Console.WriteLine(displayName); // Unknown

            // 형 변환 연산자( () ) -> Type Casting 
            double pi = 3.14;
            int intPi = (int)pi;
            Console.WriteLine(intPi); // 3

            // is / as 연산자 
            object obj = "hello";
            //object myint = 30;
            //object myobject = new StringApp();
            //object myhashtable = new Hashtable();
            if (obj is string)
            {
                Console.WriteLine("문자열입니다");
                Console.WriteLine(obj); //hello
            }
            string str = obj as string;
            // strign str = (string)obj
            Console.WriteLine(str);   // hello
            */
            #endregion
        }
    }
}
