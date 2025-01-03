using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestDemo
    {
        private static readonly Random random = new Random();

        [TestMethod]
        public void TestMethod01()
        {
            Invoke(threshold: 500);
        }

        [TestMethod]
        public void TestMethod02()
        {
            Invoke(threshold: 500);
        }

        [TestMethod]
        public void TestMethod03()
        {
            Invoke(threshold: 500);
        }

        [TestMethod]
        public void TestMethod04()
        {
            Invoke(threshold: 500);
        }

        [TestMethod]
        public void TestMethod05()
        {
            Invoke(threshold: 500);
        }

        [TestMethod]
        public void TestMethod06()
        {
            Invoke(threshold: 500);
        }

        [TestMethod]
        public void TestMethod07()
        {
            Invoke(threshold: 500);
        }

        [TestMethod]
        public void TestMethod08()
        {
            Invoke(threshold: 500);
        }

        [TestMethod]
        public void TestMethod09()
        {
            Invoke(threshold: 500);
        }

        [TestMethod]
        public void TestMethod10()
        {
            Invoke(threshold: 500);
        }

        [TestMethod]
        public void TestMethod11()
        {
            Invoke(threshold: 500);
        }

        [TestMethod]
        public void TestMethod12()
        {
            Invoke(threshold: 500);
        }

        [TestMethod]
        public void TestMethod13()
        {
            Invoke(threshold: 500);
        }

        [TestMethod]
        public void TestMethod14()
        {
            Invoke(threshold: 500);
        }

        [TestMethod]
        [DataRow(100)]
        [DataRow(200)]
        [DataRow(300)]
        [DataRow(400)]
        [DataRow(500)]
        [DataRow(600)]
        [DataRow(700)]
        [DataRow(800)]
        [DataRow(900)]
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
            Assert.IsTrue(
                condition: random.Next(minValue: 0, maxValue: 1000) > threshold,
                message: "Actual value is not greater than the threshold.");
        }
    }
}
