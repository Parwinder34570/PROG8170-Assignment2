using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProject
{
    internal class Rectangle
    {

        private int width;
        private int length;

        Rectangle()
        {
            this.width = 1;
            this.length = 1;
        }

        Rectangle(int width, int length)
        {
            this.width = width;
            this.length = length;
        }

        public int GetCurrentLength()
        {
            return this.length;
        }

        public int SetNewLength(int length)
        {
            this.length = length;
            return GetCurrentLength();
        }
        public int GetCurrentWidth()
        {
            return this.width;
        }
        public int SetNewWidth(int width)
        {
            this.width = width;
            return GetCurrentWidth();
        }
        public int GetPerimeter()
        {
            return 2 * GetCurrentWidth() + 2 * GetCurrentLength();
        }
        public int GetArea()
        {
            return GetCurrentWidth() * GetCurrentLength();
        }
    }
}
