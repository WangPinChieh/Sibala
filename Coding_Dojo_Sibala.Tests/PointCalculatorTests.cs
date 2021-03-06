using ExpectedObjects;
using NUnit.Framework;

namespace Coding_Dojo_Sibala.Tests
{
    [TestFixture]
    public class PointCalculatorTests
    {
        [SetUp]
        public void SetUp()
        {
            _pointCalculator = new PointCalculator();
        }

        private PointCalculator _pointCalculator;

        [Test]
        public void all_the_same_kind()
        {
            var expected = new PointResult
            {
                Points = 13,
                MaxNumber = 1
            };
            PointResultShouldBe(expected, "1 1 1 1");
        }

        private void PointResultShouldBe(PointResult expected, string sequence)
        {
            expected.ToExpectedObject().ShouldEqual(_pointCalculator.Calculate(sequence));
        }
    }
}