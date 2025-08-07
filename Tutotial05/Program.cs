using System;
using System.Collections;
using System.Collections.Specialized;
using System.Threading;

namespace Tutotial05
{
    class ElectronicPumpDriver
    {
        public void StartElectronicPumpRunning()
        {
            Console.WriteLine("Main Pump activate");
        }
    }
    class PneumaticPumpDriver
    {
        public void SwitchOn()
        {
            Console.WriteLine("Naumatic Pump Activate");
        }
    }
    class CoreTemMonitor
    {
        private ArrayList pumps = new ArrayList(); //멤버 변수
        public void Add(Object pump)
        {
            pumps.Add(pump); //ArrayList 배열에 들어온 객체를 저장
        }
        public void SwitchOnAllPump() //모든 펌프 스위치를 구동
        {
            foreach (Object pump in pumps)
            {
                if (pump is ElectronicPumpDriver) //클래스 타입이 같으냐?
                {
                    ((ElectronicPumpDriver)pump).StartElectronicPumpRunning();
                }
                if (pump is PneumaticPumpDriver)
                {
                    ((PneumaticPumpDriver)pump).SwitchOn();
                }
            }
        }
    }

    class CoreTemMonitor2
    {
        public delegate void StartPumpCallback(); //델리게이트 선언
        public event StartPumpCallback PumpEvent; //이벤트 선언


        ElectronicPumpDriver ed1 = new ElectronicPumpDriver(); //각각의 회사 드라이버 객체를 인스턴스
        PneumaticPumpDriver pd1 = new PneumaticPumpDriver();
        public CoreTemMonitor2() //생성자 객체가 인스턴스 될때 자동으로 생성
        {
            //이벤트에다가 델리게이트 (함수 포인터를 가지고 있음) 객체 저장
            PumpEvent += new StartPumpCallback(ed1.StartElectronicPumpRunning);
            PumpEvent += new StartPumpCallback(pd1.SwitchOn);
        }
        public void EventStart()
        {
            PumpEvent(); //이벤트 발생
        }
        private ArrayList callbacks = new ArrayList();

        public void Add(StartPumpCallback callback)
        {
            callbacks.Add(callback);
        }
        public void SwitchOnAllPumps()
        {
            foreach (StartPumpCallback callback in callbacks)
            {
                callback(); //함수 호출 (한줄로 끝냄)
            }
        }
    }
    class ThreadClass
    {
        public void First()
        {
            for (int i = 0; i < 10000; i++)
            //while (true)
            {
                Console.WriteLine("First1");
                Console.WriteLine("First2");
            }
        }
        public void Second()
        {
            for (int i = 0; i < 10000; i++)
            //while(true)
            {
                Console.WriteLine("Second1");
                Console.WriteLine("Second2");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region part 1
            /*
            CoreTemMonitor ctm = new CoreTemMonitor(); //모든 냉각장치를 구동할 수 있는 함수 호출 SwitchOnAllPumps() 를 호출하기 위해서 객체를 인스턴스 함
            ElectronicPumpDriver ed1=new ElectronicPumpDriver(); //A 회사 객체를 인스턴스
            PneumaticPumpDriver pd1=new PneumaticPumpDriver(); //B 회사 객체를 인스턴스
            ctm.Add(ed1); //객체들을 배열에 저장
            ctm.Add(pd1);

            //모든 장비를 구동할 수 있는 함수 호출
            ctm.SwitchOnAllPump();
            
            CoreTemMonitor2 ctm=new CoreTemMonitor2(); //매니저 클래스 인스턴스

            ElectronicPumpDriver ed1 = new ElectronicPumpDriver(); //각각의 회사 드라이버 객체를 인스턴스
            PneumaticPumpDriver pd1 = new PneumaticPumpDriver();

            //아래에서는 delegate 정의
            //ctm.Add(new StartPumpCallback(ed1.StartElectronicPumpRunning));
            //ctm.Add(new StartPumpCallback(pd1.SwitchOn));


            //장비 구동
            //ctm.SwitchOnAllPumps();
            ctm.EventStart();
            */
            #endregion
            #region Threading
            ThreadClass tc = new ThreadClass();

            Thread myFirst = new Thread(new ThreadStart(tc.First));
            Thread mySecond =new Thread(new ThreadStart(tc.Second));

            myFirst.Start();
            mySecond.Start();
            #endregion
        }
    }
}
