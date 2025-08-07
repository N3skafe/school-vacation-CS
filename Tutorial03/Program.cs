using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial03
{ 
    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }
    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }
    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Moew()");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1
            /*
            //일반 함수
            Calculator cal = new Calculator(); //객체 생성
            int result = cal.Add(10, 20); //일반 함수
            Console.WriteLine(result);

            //정적 함수
            int result2 =Calculator.Add2(20, 30);
            Console.WriteLine(result2);
            
            //pass by value
            int x1 = 3;
            int y1 = 4;
            Calculator.swap(x1, y1);
            Console.WriteLine("pass by value : {0}, {1}", x1, y1);
            //pass by reference
            Calculator.swap2(ref x1, ref y1);
            Console.WriteLine("pass by reference : {0}, {1}", x1, y1);

            ref int result = ref x1;
            Console.WriteLine(result);
            */
            #endregion
            #region part2
            /*
            Point myPoint = new Point(10, 15);

            int x = 0; //to use 'ref' or 'out' need to clear a value
            int y = 0;
            myPoint.GetPoint(out x, out y);
            Console.WriteLine("My point {0}, {1}", x, y);
            */
            #endregion
            #region part3
            /*
            long x =List.AddList(63, 21, 84); //v.Length = [3]
            Console.WriteLine(x);

            List.AddList2("try", "what", "the", "fuck");

            Zerg z1 = new Zerg();
            Zerg z2 = new Zerg();
            Zerg z3 = new Zerg();

            List.AddList4(z1, z2, z3);
            */
            #endregion
            #region part4
            /*
            List<object> list = new List<object>();
            list.Add(50);
            list.Add(100);
            list.Add(123);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==================================");
            list.Remove(50);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==================================");
            List<Zerg> list2 = new List<Zerg>();
            list2.Add(new Zerg());
            list2.Add(new Zerg());
            list2.Add(new Zerg());
            foreach (var item2 in list2)
            {
                item2.Attack();
            }
            Console.WriteLine("==================================");
            List<Protoss> list3 = new List<Protoss>();
            list3.Add(new Protoss());
            list3.Add(new Protoss());
            foreach (var item3 in list3)
            {
                item3.Attack();
            }
            Console.WriteLine("==================================");
            List<object> list4 = new List<object>();
            list4.Add(new Zerg());
            list4.Add(new Zerg());
            list4.Add(new Zerg());
            list4.Add(new Protoss());
            list4.Add(new Protoss());
            foreach (var item4 in list4)
            {
                if (item4 is Tutorial03.Zerg)
                {
                    ((Zerg)item4).Attack();
                }
                else if (item4 is Tutorial03.Protoss)
                {
                    ((Protoss)item4).Attack();
                }
            }
            */
            #endregion
            #region part5
            /*
            Mammal mammal = new Dog();
            if (mammal is Dog)
            {
                Dog dog = (Dog)mammal;
                dog.Bark();
            }
            Mammal mammal2 = new Cat();
            if (mammal2 is Cat)
            {
                Cat cat = (Cat)mammal2;
                cat.Meow();
            }
            */
            #endregion

        }
    }
}
