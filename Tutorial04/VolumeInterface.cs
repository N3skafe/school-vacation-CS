using System;

namespace Tutorial04
{
    public interface IVolume //this is no a 'virtual function' and 'override' this is 'interface'!!
    {
        void volumeUp();
        void volumeDown();
    }
    class Tv : IVolume
    {
        public void volumeUp()
        {
            Console.WriteLine("TV Volume UP");
        }
        public void volumeDown()
        {
            Console.WriteLine("TV Volume Down");
        }
    }
    class Radio : IVolume
    {
        public void volumeUp()
        {
            Console.WriteLine("Radio Volume UP");
        }
        public void volumeDown()
        {
            Console.WriteLine("Radio Volume Down");
        }
    }
}
