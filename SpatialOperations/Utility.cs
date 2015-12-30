using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpatialOperations
{
    public static class Utility
    {
        public static double ComputeDistance(Point p1, Point p2)
        {
            var distance = Math.Sqrt(((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y)));
            //Console.WriteLine("Distance between ({0},{1}) and ({2},{3}) is : ({4})", p1.X, p1.Y, p2.X, p2.Y , distance);
            return distance;
        }
    }
}
