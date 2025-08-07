using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Tutotial05.CoreTemMonitor2;

namespace Tutotial05
{
    class ZergAtt //ZergAtt
    {
        public void ZergAttakc()
        {
            Console.WriteLine("Zerg engage Attacking");
        }

    }
    class ProtossAtt //ProtossAtt
    {
        public void ProtossAttack()
        {
            Console.WriteLine("Protoss engage Attacking");
        }

    }

    class ATTEvent
    {
        public delegate void Attack();
        public event Attack att;

        ZergAtt z1 = new ZergAtt();
        ProtossAtt p1 =new ProtossAtt();

        public ATTEvent()
        {
            att += new Attack(z1.ZergAttakc);
            att += new Attack(p1.ProtossAttack);
        }

        public void EventStart()
        {
            att();
        }
        private ArrayList AttackConsole = new ArrayList();

        public void Add(Attack attacking)
        {
            AttackConsole.Add(attacking);
        }
        public void AttackEngage()
        {
            foreach (Attack attack in AttackConsole)
            {
                attack();
            }
        }
    }

    class Starcraft
    {
        static void Main2(string[] args)
        {
            Random random = new Random();
            int PlayerX = random.Next(1, 50);
            int PlayerY = random.Next(1, 50);

            Console.WriteLine("enter any X :");
            int EnemyX = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter any Y :");
            int EnemyY = Int32.Parse(Console.ReadLine());

            ATTEvent EnemyAtt = new ATTEvent();

            float distance = (float)Math.Sqrt(Math.Pow(PlayerX - EnemyX, 2) + Math.Pow(PlayerY - EnemyY, 2));
            if (distance < 25)
            {
                EnemyAtt.EventStart();
            }
            else
            {
                Console.WriteLine("you are safe");
            }
        }
    }
}
