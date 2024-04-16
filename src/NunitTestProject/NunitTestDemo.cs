using NUnit.Framework;

using System;

namespace NunitTestProject
{
    [TestFixture]
    public class NunitTestDemo
    {
        private static readonly Random random = new Random();

        [Test]
        public void TestMethod01()
        {
            Invoke(threshold: 500);
        }

        [Test]
        public void TestMethod02()
        {
            Invoke(threshold: 500);
        }

        [Test]
        public void TestMethod03()
        {
            Invoke(threshold: 500);
        }

        [Test]
        public void TestMethod04()
        {
            Invoke(threshold: 500);
        }

        [Test]
        public void TestMethod05()
        {
            Invoke(threshold: 500);
        }

        [Test]
        public void TestMethod06()
        {
            Invoke(threshold: 500);
        }

        [Test]
        public void TestMethod07()
        {
            Invoke(threshold: 500);
        }

        [Test]
        public void TestMethod08()
        {
            Invoke(threshold: 500);
        }

        [Test]
        public void TestMethod09()
        {
            Invoke(threshold: 500);
        }

        [Test]
        public void TestMethod10()
        {
            Invoke(threshold: 500);
        }

        [Test]
        public void TestMethod11()
        {
            Invoke(threshold: 500);
        }

        [Test]
        public void TestMethod12()
        {
            Invoke(threshold: 500);
        }

        [Test]
        public void TestMethod13()
        {
            Invoke(threshold: 500);
        }

        [Test]
        public void TestMethod14()
        {
            Invoke(threshold: 500);
        }

        [Test]
        [TestCase(100)]
        [TestCase(200)]
        [TestCase(300)]
        [TestCase(400)]
        [TestCase(500)]
        [TestCase(600)]
        [TestCase(700)]
        [TestCase(800)]
        [TestCase(900)]
        public void TestMethod15(int threshold)
        {
            Invoke(threshold);
        }

        private static void Invoke(int threshold)
        {
            // Generate a random number between 0 and 999 (inclusive)
            var actual = random.Next(minValue: 0, maxValue: 1000);

            // If the actual value falls within a certain range near the threshold, the test result is inconclusive
            if (actual > threshold - 100 && actual < threshold)
            {
                Assert.Inconclusive("Actual value falls within a certain range near the threshold. " +
                    "Test result is inconclusive.");
            }

            // Assert that the actual value is greater than the threshold
            Assert.That(
                actual: random.Next(minValue: 0, maxValue: 1000),
                expression: Is.GreaterThan(threshold),
                message: "Actual value is not greater than the threshold.");
        }
    }
}
