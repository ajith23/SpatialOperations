using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpatialOperations
{
    public struct PointPair
    {
        public Point P1;
        public Point P2;
        public double Distance
        {
            get
            {
                return Utility.ComputeDistance(P1, P2);
            }
        }
    }
}
