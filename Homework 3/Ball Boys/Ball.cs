using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.Ball_Boys
{
    public class Ball
    {
        private int size { get; set; }
        private Color color { get; set; }
        private int throws { get; set; }

        public Ball(int size, Color color)
        {
            this.size = size;
            this.color = color;
            throws = 0;
        }

        public void throwBall()
        {
            if (size != 0)
            {
                throws++;
                size--;
            }
        }

        public int getThrows() { return throws; }
        public int getSize() { return size; }
        public Color getColor() { return color; }


    }
}
