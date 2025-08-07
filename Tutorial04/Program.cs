using System;
using System.Collections.Generic;

namespace Tutorial04
{
    class VolumeManager
    {
        public void Volume(IVolume vol)
        {
            vol.volumeUp();
            vol.volumeDown();
        }
    }

    abstract class AbstractBase //추상 클래스
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }
        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }
        //추상 클래스 안에서만 정의될 수 있음.
        public abstract void AbstractMethosA(); //추상 메서드 (구현 없이 선언만 함)
    }
    class Derrived : AbstractBase
    {
        public override void AbstractMethosA() //추상 메서드를 구현
        {
            Console.WriteLine("Derrived.AbstractMethodA()");
            PrivateMethodA();
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            #region starcraft
            /*
            List<Unit> units = new List<Unit>();


            Console.WriteLine("how many 'zerg' do you need? : ");
            int zergCount = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < zergCount; i++)
            {
                units.Add(new Zerg());
            }

            Console.WriteLine("how many 'protoss' do you need? : ");
            int protossCount = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < protossCount; i++)
            {
                units.Add(new Protoss());
            }


            foreach (Unit o in units)
            {
                if (o is Zerg)
                {
                    o.Attack();
                }
                //o.Attack();
            }
            //Unit u1 = new Zerg();
            //u1.Attack();
            //((Zerg)u1).Attack();
                    */
            #endregion
            #region interface
            /*
            Tv tv = new Tv();
            Radio radio = new Radio();

            VolumeManager vm = new VolumeManager();
            vm.Volume(tv);
            */

            #endregion
            #region abstract
            /*
            //추상 클래스--------자식  -->템플릿
            AbstractBase obj = new Derrived();
            obj.AbstractMethosA();
            */

            #endregion
            #region Abstract starcragt

            AbstractUnit zerg = new Zerg();
            zerg.Attack();
            zerg.Defence();

            AbstractUnit protoss = new Protoss();
            protoss.Attack();
            protoss.Defence();


            #endregion
        }
    }
}
