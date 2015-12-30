using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpatialOperations
{
    public static class GeometryClosestPair
    {
        public static PointPair GetClosestPair(List<Point> pointList)
        {
            var closestPair = new PointPair();
            var sortedPointList = GetSortedPoints(pointList, Axis.X);
            closestPair = GetClosestPointPair(sortedPointList);
            return closestPair;
        }
        public static PointPair GetClosestPointPair(List<Point> sortedPointList)
        {
            var closestPair = new PointPair();
            var pointCount = sortedPointList.Count;

            if (pointCount <= 4)
                return GetClosestPairByBruteForce(sortedPointList);

            //var sortedPointList = GetSortedPoints(pointList, Axis.X);
            var pointList1 = new List<Point>();
            var pointList2 = new List<Point>();
            var xMedian = 0.0;

            SplitPointListWithMedian(sortedPointList, Axis.X, out xMedian, out pointList1, out pointList2);
            var pointList1ClosestPair = GetClosestPointPair(pointList1);
            var pointList2ClosestPair = GetClosestPointPair(pointList2);

            var currentClosestPair = pointList1ClosestPair.Distance < pointList2ClosestPair.Distance ? pointList1ClosestPair : pointList2ClosestPair;

            var delta = currentClosestPair.Distance;
            var pointsInCenter = sortedPointList.Where(p => Math.Abs(xMedian - p.X) <= delta).ToList();
            var sortedPointsInCenter = GetSortedPoints(pointsInCenter, Axis.Y);

            for(var i = 0; i < sortedPointsInCenter.Count - 1; i++)
            {
                for (var j = i + 1; j < sortedPointsInCenter.Count; j++)
                {
                    if ((sortedPointsInCenter[j].Y - sortedPointsInCenter[i].Y) >= currentClosestPair.Distance)
                        break;

                    if (Utility.ComputeDistance(sortedPointsInCenter[i], sortedPointsInCenter[j]) < currentClosestPair.Distance)
                    {
                        currentClosestPair.P1 = sortedPointsInCenter[i];
                        currentClosestPair.P2 = sortedPointsInCenter[j];
                    }
                }
            }

            closestPair = currentClosestPair;
            return closestPair;
        }
        private static List<Point> GetSortedPoints(List<Point> pointList, Axis axis)
        {
            var sortedPointList = new List<Point>();
            switch (axis)
            {
                case Axis.Y:
                    sortedPointList = pointList.OrderBy(p => p.Y).ToList();
                    break;
                default:
                    sortedPointList = pointList.OrderBy(p => p.X).ToList();
                    break;
            }

            return sortedPointList;
        }

        private static void SplitPointListWithMedian(List<Point> sortedPointList, Axis axis, out double xMedian, out List<Point> pointList1, out List<Point> pointList2)
        {
            var medianXPoint = 0.0;
            if (sortedPointList.Count % 2 != 0)
                medianXPoint = sortedPointList[(sortedPointList.Count / 2)].X;
            else
                medianXPoint = (sortedPointList[(sortedPointList.Count / 2) - 1].X + sortedPointList[(sortedPointList.Count / 2)].X) / 2;

            xMedian = medianXPoint;
            pointList1 = sortedPointList.Where(p => p.X <= medianXPoint).ToList();
            pointList2 = sortedPointList.Where(p => p.X > medianXPoint).ToList();
        }

        public static PointPair GetClosestPairByBruteForce(List<Point> pointList)
        {
            var minimumDistance = 2312432524352345.0;
            var closestPair = new PointPair();
            for (var i = 0; i < pointList.Count; i++)
            {
                for (var j = i + 1; j < pointList.Count; j++)
                {
                    var currentDistance = Utility.ComputeDistance(pointList[i], pointList[j]);
                    if (currentDistance < minimumDistance)
                    {
                        minimumDistance = currentDistance;
                        closestPair.P1 = pointList[i];
                        closestPair.P2 = pointList[j];
                    }
                }
            }

            return closestPair;
        }
    }
}
