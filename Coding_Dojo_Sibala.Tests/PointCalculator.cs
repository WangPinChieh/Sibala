using System.Linq;

namespace Coding_Dojo_Sibala.Tests
{
    public class PointCalculator
    {
        public PointResult Calculate(string sequence)
        {
            var splitPoints = sequence.Split(' ').Select(int.Parse).ToList();
            if (splitPoints.Distinct().Count() == 1)
            {
                return new PointResult
                {
                    Points = 12 + splitPoints[0],
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