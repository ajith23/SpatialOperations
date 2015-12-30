using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpatialOperations
{
    public static class ConvexHull
    {
        public static List<Point> GetPointsInConvexHull(List<Point> pointList)
        {
            var convexHullPointList = new List<Point>();

            var p0 = GetLowestLeftmostPoint(pointList);
            var orderedPointList = OrderByPolarAngle(p0, pointList);

            return ComputeConvexHull(p0, orderedPointList);
        }

        private static List<Point> ComputeConvexHull(Point p0, List<Point> orderedPointList)
        {
            var hull = new Stack<Point>();
            var pointCount = orderedPointList.Count;

            hull.Push(orderedPointList[0]);
            hull.Push(orderedPointList[1]);

            for (var i = 2; i < pointCount; i++)
            {
                var top = hull.Pop();
                while (DetermineTurnType(hull.Peek(), top, orderedPointList[i]) <= 0)
                    top = hull.Pop();
                hull.Push(top);
                hull.Push(orderedPointList[i]);
            }

            return hull.ToList();
        }

        private static double GetPolarAngle(Point referencePoint, Point point)
        {
            var deltaX = point.X - referencePoint.X;
            var deltaY = point.Y - referencePoint.Y;
            var polarAngle = Math.Atan2(deltaY, deltaX) * 180 / Math.PI;
            return polarAngle;
        }

        private static Point GetLowestLeftmostPoint(List<Point> pointList)
        {
            var p0 = new Point();

            var minimumY = pointList.Min(p => p.Y);
            var lowestPoints = pointList.Where(p => p.Y == minimumY).ToList();

            if (lowestPoints.Count == 1)
                p0 = lowestPoints[0];
            else
            {
                var lowestMinimumX = lowestPoints.Min(p => p.X);
                var leftMostPoint = lowestPoints.Where(p => p.X == lowestMinimumX).ToList();
                p0 = leftMostPoint[0];
            }

            return p0;
        }

        private static List<Point> OrderByPolarAngle(Point p0, List<Point> pointList)
        {
            var tempList = new List<PolarAngleForPoint>();
            var orderedPointList = new List<Point>();
            foreach (var point in pointList)
                tempList.Add(new PolarAngleForPoint { P1 = point, Reference = p0, Angle = GetPolarAngle(p0, point) });
            orderedPointList = tempList.OrderBy(p=>p.Angle).Select(p => p.P1).ToList();
            tempList.Clear();
            return orderedPointList;
        }

        private static int DetermineTurnType(Point p1, Point p2, Point p3)
        {
            var area = ((p2.X - p1.X) * (p3.Y - p1.Y)) - ((p2.Y - p1.Y) * (p3.X - p1.X));
            if (area < 0)
                return -1; //clockwise turn
            else if (area > 0)
                return 1; //counter-clockwise turn
            else
                return 0; //no turn, the points are collinear

        }
    }
}
