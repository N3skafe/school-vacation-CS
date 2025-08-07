using System;
using System.Drawing;

namespace PolygonDLL
{
    public interface ISize
    {


        int sizeWidth();
        int sizeHeight();
    }

    abstract public class Polygon : ISize
    {
        private string PolygonName;
        protected double PI = 3.141592;
        public Color color;
        //맴버 변수
        protected int x1, y1, x2, y2;
        public int width, height;

        //프로퍼티 (변수의 대용하기 위한 기능)
        public int X
        {
            set //쓰기모드
            {
                x1 = value;
            }
            get //읽기모드
            {
                return x1;
            }
        }
        public int Y
        {
            set
            {
                y1 = value;
            }
            get
            {
                return y1;
            }
        }
        //생성자
        public Polygon(int x1, int y1, int x2, int y2, string polygonName)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.PolygonName = polygonName;
        }

        //인터페이스 함수 구현
        public int sizeWidth()
        {
            width = x2 - x1;
            return width;
        }
        public int sizeHeight()
        {
            height = y2 - y1;
            return height;
        }
        //추상함수
        public abstract int GetArea();
    }
}
