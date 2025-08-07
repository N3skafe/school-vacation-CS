using System;

namespace Tutorial03
{
    class Zerg
    {
        public void Attack()
        {
            Console.WriteLine("Zerg in Action");
        }
    }

    class Protoss
    {
        public void Attack()
        {
            Console.WriteLine("Protoss in Action");
        }
    }

    class Calculator
    {
        public static void swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        public static void swap2(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
    }

    class Point
    {
        int x;
        int y;

        public Point(int x, int y)
        {
            this.x = x; //맴버 변수와 매개 변수를 구분하기 위한 this 사용
            this.y = y;
        }
        public void GetPoint(out int x, out int y)
        {
            x = this.x;
            y = this.y;
        }
    }

    class List
    {
        public static long AddList(params long[] v)
        {
            long total, i;
            for (i = 0, total = 0; i < v.Length; ++i)
            {
                total += v[i];
            }
            return total;
        }

        public static void AddList2(params string[] v)
        {
            for (int i = 0; i < v.Length; ++i)
            {
                Console.WriteLine(v[i]);
            }
        }
        public static void AddList4(params object[] v)
        {
            for (int i = 0; i < v.Length; ++i)
            {
                //if (v[i].GetType().ToString == "Tutorial03.Zerg")
                //{
                //    Console.WriteLine(v[i]);
                //}
                //else
                //{
                //    ((Zerg)v[i]).Attack(); //downcasting

                //}
                ((Zerg)v[i]).Attack(); //downcasting
            }
    }
}
