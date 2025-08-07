using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial02
{
    
    class Zerg {}
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part 1
            /*
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine(a.ToString());

            var b = new[] { "hello,", "null", "world" };
            //type change, there no 'ver' in memory (int or ECT..) good at perfomance

            Console.WriteLine(b.ToString());
            //object b = 10; //up_casting, you can find in memory
            object c = "park jun seo";
            object d = 100;
            Console.WriteLine(c.ToString());
            Console.WriteLine(d.ToString());
            */
            #endregion
            #region part 2
            /*
            string[] output = { "what are you doing?", "are you idiot?","count down", "5", "4", "3", "2", "1", "BOOM"};
            //string what = "why are you still here?";
            //string 배열 선언, 각기 다른 타이틀 명
            //for문 생성
            for (int i = 0; i < 9; i++)
            {
                MessageBox.Show(output[i], "MyForm", MessageBoxButtons.OK, MessageBoxIcon.Question);
                //MessageBox.Show(what, "MyForm2", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            */
            #endregion
            #region part 3
            /*
            int[] array = { 10, 20, 30 };

            foreach(int item in array)
            {
                Console.WriteLine(item);
            }
            */
            #endregion
            #region part 4
            /*
            string[] output = { "what are you doing?", "are you idiot?", "count down", "5", "4", "3", "2", "1", "BOOM" };
            ArrayList number = new ArrayList(); //ArrayList can handle float, int, string ect...
            //number.Add(10);
            //number.Add(20);

            for (int i = 0; i < 100; i++)
            {
                number.Add(i);
            }
            for (int i = 0; i < 9; i++)
            {
                number.Add(output[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                number.Add(i * 1.2f);
            }
            for (int i = 0; i < 4; i++)
            {
                number.Add(new Zerg());
            }
            foreach (var item in number)
            {
                Console.WriteLine(item);
            }
            */
            #endregion
            #region part 5
            /*
            Hashtable hash = new Hashtable();

            hash.Add("kurumi", "noah"); //key, value
            hash.Add("shiranami", "ramune");
            hash.Add("kisaragi", "renn");
            hash.Add("tachibana", "hinano");
            hash.Add("aizawa", "ema");
            
            for (int i = 0; i < 5; i++)
            {
                hash.Add(i, "V-spo" + i);
            }
            for (int i = 5; i < 10; i++)
            {
                hash.Add(i, new Zerg());
            }
            foreach (object firstName in hash.Keys)
            {
                Console.WriteLine("{0}, {1}", firstName, hash[firstName]); //string formet set and hashdata
            }
            */
            #endregion
            #region project 1
            /*
            ArrayList number = new ArrayList();
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    number.Add(i * j);
                }
            }
            foreach (int fin in number)
            {
                Console.WriteLine(fin);
            }
            */
            #endregion
            #region project 2
            /*
            ArrayList number = new ArrayList();
            string num1, num2;
            int inum1, inum2;
            Console.WriteLine("type any number what you want");
            num1 = Console.ReadLine();
            inum1 = Int32.Parse(num1);
            Console.WriteLine("also type second number whatever you want");
            num2 = Console.ReadLine();
            inum2 = Int32.Parse(num2);
            for (int i = inum1; i < inum2+1; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    number.Add(i * j);
                }
            }
            foreach (int fin in number)
            {
                Console.WriteLine(fin);
            }
            */
            #endregion
            #region project answer
            Gugudan myGugudan = new Gugudan(); //객체를 생성
            myGugudan.Gugudan_print1(); //객체.함수호출
            Gugudan myGugudan2 = new Gugudan();
            myGugudan2.Gugudan_print2();
            #endregion
        }
    }
}
