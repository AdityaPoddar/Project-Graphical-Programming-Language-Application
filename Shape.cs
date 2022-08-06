using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ASE_Shape_Programming_language
{
    abstract class Shape : InterfaceShapes
    {
        public Color colour; //shape's colour
        protected int x, y;

        /// <summary>
        /// Initializes Positions and colour of the instance variables.
        /// </summary>
        public Shape()
        {
            colour = Color.Red;
            x = y = 100;
        }
        /// <summary>
        /// Sets the colour and positin of the instance vairable by overloading the constructor.
        /// </summary>
        /// <param name="colour"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Shape(Color colour, int x, int y)
        {
            this.colour = colour;
            this.x = x;
            this.y = y;
        }
        public abstract double calcArea();
        public abstract double calcPerimeter();
        public abstract void draw(Graphics g, bool fill);

        /// <summary>
        /// Seter for the colours, size and positino of shape
        /// </summary>
        /// <param name="colour">Colour of the shape as an object of Color class</param>
        /// <param name="list">Size and position of the shape</param>
        public virtual void set(Color colour, params int[] list)
        {

            this.x = list[0];
            this.y = list[1];
            this.colour = colour;
        }

        public override string ToString()
        {
            return base.ToString() + "    " + this.x + "," + this.y + " : ";
        }

        /// <summary>
        /// Setter for the colour instance variable.
        /// </summary>
        /// <param name="colour">Colour object used for coloring, made from Color class</param>
        public virtual void setColour(Color colour)
        {
            this.colour = colour;
        }


        /// <summary>
        /// Set the starting position for the shape to be drawn from.
        /// </summary>
        /// <param name="list"></param>
        public virtual void setStartPoint(params int[] list)
        {
            this.x = list[0];
            this.y = list[1];
        }
    }
}
