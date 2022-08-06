using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ASE_Shape_Programming_language
{
    class Circle : Shape
    {
        int radius;
        public Circle() : base()
        {
            radius = 100;
        }
        public Circle(Color colour, int x, int y, int radius) : base(colour, x, y)
        {

            this.radius = radius;
        }

        /// <summary>
        /// Seter for the colours, size and positino of shape circle
        /// </summary>
        /// <param name="colour">Colour of the shape as an object of Color class</param>
        /// <param name="list">Size and position of the shape</param>
        public override void set(Color colour, params int[] list)
        {
            //list[0] is x, list[1] is y, list[2] is width, list[3] is height
            base.set(colour, list[0], list[1]);
            this.radius = list[2];

        }

        /// <summary>
        /// Draw the shape
        /// </summary>
        /// <param name="g">Graphic object where it's drawn</param>
        /// <param name="fill">Fill or no Fill for the shape</param>
        override
        public void draw(Graphics g, bool fill)
        {

            Pen p = new Pen(colour);
            SolidBrush b = new SolidBrush(colour);

            if (fill)
                g.FillEllipse(b, x - radius, y - radius, 2 * radius, 2 * radius);
            else
                g.DrawEllipse(p, x - radius, y - radius, 2 * radius, 2 * radius);
        }

        override
        public double calcArea()
        {
            return 3.14 * radius * radius;
        }

        override
        public double calcPerimeter()
        {
            return 2 * 3.14 * radius;
        }
    }
}
