using System;
using System.Collections.Generic;
using System.Text;

namespace Shaiya.Domain
{
    public struct Position
    {
        public float? X { get; set; }
        public float? Y { get; set; }
        public float? Z { get; set; }

        public Position(float? setX, float? setY, float? setZ)
        {
            X = setX;
            Y = setY;
            Z = setZ;
        }
    }
}
