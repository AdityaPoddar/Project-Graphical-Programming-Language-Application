using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Shape_Programming_language
{
    class ShapeFactory
    {
        public Shape getShape(String shapeType)
        {
            shapeType = shapeType.ToUpper().Trim();


            if (shapeType.Equals("CIRCLE"))
            {
                return new Circle();

            }
            if (shapeType.Equals("RECTANGLE"))
            {
                return new Rectangle();

            }
            else if (shapeType.Equals("TRIANGLE"))
            {
                return new Triangle();
            }
            else
            {
                return null;

            }


        }

    }
}
