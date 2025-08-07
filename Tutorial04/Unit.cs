using System;

namespace Tutorial04
{
    class Unit
    {
        public virtual void Attack()
        {
            Console.WriteLine("Action in Prograss");
        }
    }
    abstract class AbstractUnit //virtual class
    {
        public abstract void Attack(); //virtual function
        public abstract void Defence(); //virtual function
    }

    class Zerg : AbstractUnit
    {
        public override void Attack()
        {
            Console.WriteLine("Zerg in Action");
        }
        public override void Defence()
        {
            Console.WriteLine("Zerg in Defence");
        }
    }
    class Protoss : AbstractUnit
    {
        public override void Attack()
        {
            Console.WriteLine("Protoss in Action");
        }
        public override void Defence()
        {
            Console.WriteLine("Protoss in Defence");
        }
    }
}
