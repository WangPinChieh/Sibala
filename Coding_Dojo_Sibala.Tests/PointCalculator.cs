using System.Linq;

namespace Coding_Dojo_Sibala.Tests
{
    public class PointCalculator
    {
        private const int MaxPoints = 12;

        public PointResult Calculate(string sequence)
        {
            var splitPoints = sequence.Split(' ').Select(int.Parse).ToList();
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

            return new PointResult
            {
                Points = 7,
                MaxNumber = 4
            };
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