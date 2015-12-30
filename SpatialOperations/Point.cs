using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpatialOperations
{
    public struct Point
    {
        public double X;
        public double Y;
    }

    public struct PolarAngleForPoint
    {
        public Point Reference;
        public Point P1;
        public double Angle;
    }
}
