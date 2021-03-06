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

        [Test]
        public void no_point_all_points_different()
        {
            var expected = new PointResult
            {
                Points = 0,
                MaxNumber = 0
            };
            PointResultShouldBe(expected, "1 2 3 4");
        }

        [Test]
        public void no_point_all_points_3_same_1_different()
        {
            var expected = new PointResult
            {
                Points = 0,
                MaxNumber = 0
            };
            PointResultShouldBe(expected, "6 6 6 3");
        }

        [Test]
        public void normal_point_2243()
        {
            var expected = new PointResult
            {
                Points = 7,
                MaxNumber = 4
            };
            PointResultShouldBe(expected, "2 2 4 3");
        }

        [Test]
        public void normal_point_6652()
        {
            var expected = new PointResult
            {
                Points = 7,
                MaxNumber = 5
            };
            PointResultShouldBe(expected, "6 6 5 2");
        }

        [Test]
        public void normal_point_2266()
        {
            var expected = new PointResult
            {
                Points = 12,
                MaxNumber = 6
            };
            PointResultShouldBe(expected, "2 2 6 6");
        }

        private void PointResultShouldBe(PointResult expected, string sequence)
        {
            expected.ToExpectedObject().ShouldEqual(_pointCalculator.Calculate(sequence));
        }
    }
}