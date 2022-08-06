using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ASE_Shape_Programming_language
{
    class Rectangle : Shape
    {
        int width, height;

        public Rectangle() : base()
        {
            Console.WriteLine("rect obj created");
            width = 100;
            height = 100;
        }
        public Rectangle(Color colour, int x, int y, int width, int height) : base(colour, x, y)
        {

            this.width = width; //the only thing that is different from shape
            this.height = height;
        }

        
        public override void set(Color colour, params int[] list)
        {

            //list[0] is x, list[1] is y, list[2] is width, list[3] is height
            base.set(colour, list[0], list[1]);
            this.width = list[2];
            this.height = list[3];

        }

       
        override
        public void draw(Graphics g, bool fill)
        {

            Pen p = new Pen(colour);
            SolidBrush b = new SolidBrush(colour);

            Console.WriteLine("I drew a rectangle");

            if (fill)
                g.FillRectangle(b, (x - width / 2), (y - height / 2), width, height);
            else
                g.DrawRectangle(p, (x - width / 2), (y - height / 2), width, height);

            Console.WriteLine("this is the base colour" + base.colour);
        }

        override
        public double calcArea()
        {
            return width * height;
        }

        override
        public double calcPerimeter()
        {
            return 2 * width + 2 * height;
        }
    }
}
