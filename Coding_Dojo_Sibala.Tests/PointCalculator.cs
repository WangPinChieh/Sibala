using System.Collections.Generic;
using System.Linq;

namespace Coding_Dojo_Sibala.Tests
{
    public class PointCalculator
    {
        private const int MaxPoints = 12;

        public PointResult Calculate(string sequence)
        {
            var splitPoints = ToSplitPoints(sequence);
            var pointKindsCount = splitPoints.Distinct().Count();
            if (pointKindsCount == 2 || pointKindsCount == 4)
            {
                return NoPoint();
            }

            if (AllTheSameKind(pointKindsCount))
            {
                return new PointResult
                {
                    Points = MaxPoints + splitPoints[0],
                    MaxNumber = splitPoints[0]
                };
            }

            var pointGroups = from d in splitPoints
                group d by d
                into groupSplitPoints
                select new
                {
                    Point = groupSplitPoints.Key,
                    Count = groupSplitPoints.Count()
                };

            var resultPoints = pointGroups.Where(m => m.Count == 1);


            return new PointResult
            {
                Points = resultPoints.Sum(m => m.Point),
                MaxNumber = resultPoints.Max(m => m.Point)
            };
        }

        private static List<int> ToSplitPoints(string sequence)
        {
            var splitPoints = sequence.Split(' ').Select(int.Parse).ToList();
            return splitPoints;
        }

        private static PointResult NoPoint()
        {
            return new PointResult
            {
                Points = 0,
                MaxNumber = 0
            };
        }

        private static bool AllTheSameKind(int pointKindsCount)
        {
            return pointKindsCount == 1;
        }
    }
}