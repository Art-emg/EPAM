using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void IsTriangleEquilateralTest()
        {
            Assert.AreEqual(Triangles.Triangle.IsTriangle(1, 1, 1), true);
        }

        [Test]
        public void IsTriangleRightTest()
        {
            Assert.AreEqual(Triangles.Triangle.IsTriangle(5, 8, 10), true);
        }

        [Test]
        public void IsTriangleIsoscelesTest()
        {
            Assert.AreEqual(Triangles.Triangle.IsTriangle(2, 2, 3), true);
        }

        [Test]
        public void IsTriangleAllSidesNullTest()
        {
            Assert.AreEqual(Triangles.Triangle.IsTriangle(0, 0, 0), false);
        }

        [Test]
        public void IsTriangleBadTest()
        {
            Assert.AreEqual(Triangles.Triangle.IsTriangle(1, 4, 7), false);
        }

        [Test]
        public void IsTriangleGoodTest()
        {
            Assert.AreEqual(Triangles.Triangle.IsTriangle(4, 5, 6), true);
        }

        [Test]
        public void IsTriangleOneBadSideTest()
        {
            Assert.AreEqual(Triangles.Triangle.IsTriangle(4, -5, 6), false);
        }

        [Test]
        public void IsTriangleTwoBadSidesGoodTest()
        {
            Assert.AreEqual(Triangles.Triangle.IsTriangle(-4, -5, 6), false);
        }

        [Test]
        public void IsTriangleThreeBadSidesGoodTest()
        {
            Assert.AreEqual(Triangles.Triangle.IsTriangle(-4, -5, -6), false);
        }

        [Test]
        public void IsTriangleDoubleGoodTest()
        {
            Assert.AreEqual(Triangles.Triangle.IsTriangle(2.5, 3.5, 4.5), true);
        }
    }
}