using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpatialOperations
{
    public static class TestData
    {

        public static List<Point> GetActualPointList()
        {
            var pointList = new List<Point>();

            pointList.Add(new Point { X = 0.321534855, Y = 0.036295831 });
            pointList.Add(new Point { X = 0.024023581, Y = -0.23567288 });
            pointList.Add(new Point { X = 0.045908512, Y = -0.415640992 });
            pointList.Add(new Point { X = 0.3218384, Y = 0.13798507 });
            pointList.Add(new Point { X = 0.115064798, Y = -0.105952147 });
            pointList.Add(new Point { X = 0.262254, Y = -0.297028733 });
            pointList.Add(new Point { X = -0.161920957, Y = -0.405533972 });
            pointList.Add(new Point { X = 0.190537863, Y = 0.369860101 });
            pointList.Add(new Point { X = 0.238709092, Y = -0.016298271 });
            pointList.Add(new Point { X = 0.074958887, Y = -0.165982511 });
            pointList.Add(new Point { X = 0.331934184, Y = -0.18218141 });
            pointList.Add(new Point { X = 0.077036358, Y = -0.249943064 });
            pointList.Add(new Point { X = 0.2069243, Y = -0.223297076 });
            pointList.Add(new Point { X = 0.046040795, Y = -0.192357319 });
            pointList.Add(new Point { X = 0.050542958, Y = 0.475492946 });
            pointList.Add(new Point { X = -0.390058917, Y = 0.279782952 });
            pointList.Add(new Point { X = 0.312069339, Y = -0.050632987 });
            pointList.Add(new Point { X = 0.011388127, Y = 0.40025047 });
            pointList.Add(new Point { X = 0.00964515, Y = 0.10602511 });
            pointList.Add(new Point { X = -0.035979332, Y = 0.295363946 });

            return pointList;
        }

        public static List<Point> GetActualPointListConvexHull()
        {
            var pointList = new List<Point>();
            pointList.Add(new Point { X = 0.321534855, Y = 0.036295831 });
            pointList.Add(new Point { X = 0.024023581, Y = -0.23567288 });
            pointList.Add(new Point { X = 0.045908512, Y = -0.415640992 });
            pointList.Add(new Point { X = 0.3218384, Y = 0.13798507 });
            pointList.Add(new Point { X = 0.115064798, Y = -0.105952147 });
            pointList.Add(new Point { X = 0.262254, Y = -0.297028733 });
            pointList.Add(new Point { X = -0.161920957, Y = -0.405533972 });
            pointList.Add(new Point { X = 0.190537863, Y = 0.369860101 });
            pointList.Add(new Point { X = 0.238709092, Y = -0.016298271 });
            pointList.Add(new Point { X = 0.074958887, Y = -0.165982511 });
            pointList.Add(new Point { X = 0.331934184, Y = -0.18218141 });
            pointList.Add(new Point { X = 0.077036358, Y = -0.249943064 });
            pointList.Add(new Point { X = 0.2069243, Y = -0.223297076 });
            pointList.Add(new Point { X = 0.046040795, Y = -0.192357319 });
            pointList.Add(new Point { X = 0.050542958, Y = 0.475492946 });
            pointList.Add(new Point { X = -0.390058917, Y = 0.279782952 });
            pointList.Add(new Point { X = 0.312069339, Y = -0.050632987 });
            pointList.Add(new Point { X = 0.011388127, Y = 0.40025047 });
            pointList.Add(new Point { X = 0.00964515, Y = 0.10602511 });
            pointList.Add(new Point { X = -0.035979332, Y = 0.295363946 });
            pointList.Add(new Point { X = 0.181829087, Y = 0.001454398 });
            pointList.Add(new Point { X = 0.444056063, Y = 0.250249717 });
            pointList.Add(new Point { X = -0.053017525, Y = -0.065539216 });
            pointList.Add(new Point { X = 0.482389623, Y = -0.477617 });
            pointList.Add(new Point { X = -0.308922685, Y = -0.063561122 });
            pointList.Add(new Point { X = -0.271780741, Y = 0.18108106 });
            pointList.Add(new Point { X = 0.429362652, Y = 0.298089796 });
            pointList.Add(new Point { X = -0.004796652, Y = 0.382663813 });
            pointList.Add(new Point { X = 0.430695573, Y = -0.29950735 });
            pointList.Add(new Point { X = 0.179966839, Y = -0.297346747 });
            pointList.Add(new Point { X = 0.493216685, Y = 0.492809416 });
            pointList.Add(new Point { X = -0.352148791, Y = 0.43526562 });
            pointList.Add(new Point { X = -0.490736801, Y = 0.186582687 });
            pointList.Add(new Point { X = -0.104792472, Y = -0.247073392 });
            pointList.Add(new Point { X = 0.437496186, Y = -0.00160628 });
            pointList.Add(new Point { X = 0.003256208, Y = -0.272919432 });
            pointList.Add(new Point { X = 0.043103782, Y = 0.445260405 });
            pointList.Add(new Point { X = 0.491619838, Y = -0.345391701 });
            pointList.Add(new Point { X = 0.001675087, Y = 0.153183767 });
            pointList.Add(new Point { X = -0.440428957, Y = -0.289485599 });

            return pointList;
        }

        public static bool TestActualResultClosestPair(PointPair closestPair)
        {
            if (closestPair.P1.X == 0.074958887 && closestPair.P1.Y == -0.165982511 && closestPair.P2.X == 0.046040795 && closestPair.P2.Y == -0.192357319)
                return true;
            else if (closestPair.P2.X == 0.074958887 && closestPair.P2.Y == -0.165982511 && closestPair.P1.X == 0.046040795 && closestPair.P1.Y == -0.192357319)
                return true;
            else return false;
        }

        public static bool TestActualResultFarthestPair(PointPair farthestPair)
        {
            if (farthestPair.P1.X == -0.161920957 && farthestPair.P1.Y == -0.405533972 && farthestPair.P2.X == 0.050542958 && farthestPair.P2.Y == 0.475492946)
                return true;
            else if (farthestPair.P2.X == -0.161920957 && farthestPair.P2.Y == -0.405533972 && farthestPair.P1.X == 0.050542958 && farthestPair.P1.Y == 0.475492946)
                return true;
            else return false;
        }

        public static bool TestActualResultConvexHull(List<Point> hullPointList)
        {
            return false;
        }

        public static List<Point> GetHugePointList(int pointsCount)
        {
            var randomizer = new Random(10);
            var pointList = Enumerable.Range(1, pointsCount).Select(i => new Point { X = randomizer.NextDouble(), Y = randomizer.NextDouble() }).ToList();

            return pointList;
        }
    }
}
