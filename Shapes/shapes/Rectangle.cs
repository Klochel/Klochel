﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    namespace shapes
    {
        class Rectangle
        {
            // Fields
            private double _hypotenuse;
            private double _area;
            private double _perimeter;
            private int _count;

            // Constructor
            public Rectangle()
            {
                _area = 0;
                _perimeter = 0;
                _count = 0;
            }

            public double Area { get; set; }

            public double Perimeter { get; set; }

            public double Count { get; set; }

            // ToString override
            public override string ToString()
            {
                return "Hypotenuse: " + decimal.Round((decimal)
     2, MidpointRounding.AwayFromZero) + " Area: " + decimal.Round((decimal)Area,
     2, MidpointRounding.AwayFromZero) + " Perimeter: " + decimal.Round(
         (decimal)Perimeter, 2, MidpointRounding.AwayFromZero);

            }
        }
    }
}
