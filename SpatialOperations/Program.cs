using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpatialOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Generating Points...");
            //var pointList = TestData.GetHugePointList(10000000);
            //Console.WriteLine("Points Generated.");
            
            //ExecuteClosestPair(pointList);
            //ExecuteFarthestPair(pointList);
            ExecuteConvexHull(TestData.GetActualPointListConvexHull());
            //ExecuteConvexHull(TestData.GetHugePointList(3000000));

            Console.WriteLine("Execution Complete.");
            Console.ReadLine();      
        }

        static void ExecuteClosestPair(List<Point> pointList)
        {
            var start = DateTime.Now;
            Console.WriteLine("Computing Closest Pair using Divide and Conquer...");
            var closestPair = GeometryClosestPair.GetClosestPair(pointList);
            Console.WriteLine("Point 1 = ({0},{1})", closestPair.P1.X, closestPair.P1.Y);
            Console.WriteLine("Point 2 = ({0},{1})", closestPair.P2.X, closestPair.P2.Y);
            Console.WriteLine("Distance = {0}", closestPair.Distance);
            Console.WriteLine("Time taken to compute closest pair from {0} points : {1}", pointList.Count, DateTime.Now - start);
            if (TestData.TestActualResultClosestPair(closestPair))
                Console.WriteLine("Test Passed !");
            else
                Console.WriteLine("Test Failed !");

            //Console.WriteLine("---------------------------------------------------------");
            //start = DateTime.Now;
            //Console.WriteLine("Computing Closest Pair using Brute Force... ");
            //closestPair = GeometryClosestPair.GetClosestPairByBruteForce(pointList);
            //Console.WriteLine("Point 1 = ({0},{1})", closestPair.P1.X, closestPair.P1.Y);
            //Console.WriteLine("Point 2 = ({0},{1})", closestPair.P2.X, closestPair.P2.Y);
            //Console.WriteLine("Distance = {0}", closestPair.Distance);
            //Console.WriteLine("Time taken to compute closest pair from {0} points : {1}", pointList.Count, DateTime.Now - start);
            //if (TestData.TestActualResultClosestPair(closestPair))
            //    Console.WriteLine("Test Passed !");
            //else
            //    Console.WriteLine("Test Failed !");
        }

        static void ExecuteFarthestPair(List<Point> pointList)
        {
            var start = DateTime.Now;
            Console.WriteLine("Computing Farthest Pair using Divide and Conquer... ");
            var farthestPair = GeometryFarthestPair.GetFarthestPair(pointList);
            Console.WriteLine("Point 1 = ({0},{1})", farthestPair.P1.X, farthestPair.P1.Y);
            Console.WriteLine("Point 2 = ({0},{1})", farthestPair.P2.X, farthestPair.P2.Y);
            Console.WriteLine("Distance = {0}", farthestPair.Distance);
            Console.WriteLine("Time taken to compute farthest pair from {0} points : {1}", pointList.Count, DateTime.Now - start);
            if (TestData.TestActualResultFarthestPair(farthestPair))
                Console.WriteLine("Test Passed !");
            else
                Console.WriteLine("Test Failed !");

            //Console.WriteLine("Computing Farthest Pair using Brute Force... ");
            //farthestPair = GeometryFarthestPair.GetFarthestPairByBruteForce(pointList);
            //Console.WriteLine("Point 1 = ({0},{1})", farthestPair.P1.X, farthestPair.P1.Y);
            //Console.WriteLine("Point 2 = ({0},{1})", farthestPair.P2.X, farthestPair.P2.Y);
            //Console.WriteLine("Distance = {0}", farthestPair.Distance);
            //Console.WriteLine("Time taken to compute farthest pair from {0} points : {1}", pointList.Count, DateTime.Now - start);
            //if (TestData.TestActualResultFarthestPair(farthestPair))
            //    Console.WriteLine("Test Passed !");
            //else
            //    Console.WriteLine("Test Failed !");
        }

        static void ExecuteConvexHull(List<Point> pointList)
        {
            var start = DateTime.Now;
            Console.WriteLine("Computing Convex Hull using Graham Scan...");
            var convexHullPointList = ConvexHull.GetPointsInConvexHull(pointList);
            Console.WriteLine("Points in Hull - "); 
            foreach (var point in convexHullPointList)
                Console.WriteLine("({0},{1})", point.X, point.Y);
            Console.WriteLine("Time taken to compute Convex Hull from {0} points : {1}", pointList.Count, DateTime.Now - start);
            //if (TestData.TestActualResultConvexHull(convexHullPointList))
            //    Console.WriteLine("Test Passed !");
            //else
            //    Console.WriteLine("Test Failed !");
        }
    }

    

    
}
