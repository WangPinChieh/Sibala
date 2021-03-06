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
        public void all_the_same_kind_1111()
        {
            var expected = new PointResult
            {
                Points = 13,
                MaxNumber = 1
            };
            PointResultShouldBe(expected, "1 1 1 1");
        }

        [Test]
        public void all_the_same_kind_6666()
        {
            var expected = new PointResult
            {
                Points = 18,
                MaxNumber = 6
            };
            PointResultShouldBe(expected, "6 6 6 6");
        }

        private void PointResultShouldBe(PointResult expected, string sequence)
        {
            expected.ToExpectedObject().ShouldEqual(_pointCalculator.Calculate(sequence));
        }
    }
}