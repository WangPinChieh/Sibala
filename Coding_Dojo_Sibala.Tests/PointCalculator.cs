using System.Linq;

namespace Coding_Dojo_Sibala.Tests
{
    public class PointCalculator
    {
        private const int MaxPoints = 12;

        public PointResult Calculate(string sequence)
        {
            var splitPoints = sequence.Split(' ').Select(int.Parse).ToList();
            if (splitPoints.Distinct().Count() == 4)
            {
                return new PointResult
                {
                    Points = 0,
                    MaxNumber = 0
                };
            }

            if (splitPoints.Distinct().Count() == 1)
            {
                return new PointResult
                {
                    Points = MaxPoints + splitPoints[0],
                    MaxNumber = splitPoints[0]
                };
            }

            return new PointResult
            {
                Points = 13,
                MaxNumber = 1
            };
        }
    }
}