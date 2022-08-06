using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ASE_Shape_Programming_language
{
    class Triangle : Shape
    {
        int width, height;
        public Triangle() : base()
        {
            Console.WriteLine("rect obj created");
            width = 100;
            height = 100;
        }
        public Triangle(Color colour, int x, int y, int width, int height) : base(colour, x, y)
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
            Pen p = new Pen(base.colour, 2);
            SolidBrush b = new SolidBrush(base.colour);
            int xPos = x - width / 2;
            int yPos = y + height / 2;

            if (fill)
                g.FillPolygon(b, new Point[] { new Point(xPos, yPos), new Point(x + width / 2, yPos), new Point(x, y - height / 2) });
            else
                g.DrawPolygon(p, new Point[] { new Point(xPos, yPos), new Point(x + width / 2, yPos), new Point(x, y - height / 2) });

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
