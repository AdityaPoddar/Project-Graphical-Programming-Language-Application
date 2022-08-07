using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ASE_Shape_Programming_language
{
    interface InterfaceShapes
    {
        void set(Color colour, params int[] list);
        
        void setStartPoint(params int[] list);
        
        void setColour(Color colour);
        
        void draw(Graphics g, bool fill);
        double calcArea();
        double calcPerimeter();
    }
}
