using System;

using Xunit;

namespace XunitTestProject
{
    public class XunitTestDemo
    {
        private static readonly Random random = new Random();

        [SkippableFact]
        public void TestMethod01()
        {
            Invoke(threshold: 500);
        }

        [SkippableFact]
        public void TestMethod02()
        {
            Invoke(threshold: 500);
        }

        [SkippableFact]
        public void TestMethod03()
        {
            Invoke(threshold: 500);
        }

        [SkippableFact]
        public void TestMethod04()
        {
            Invoke(threshold: 500);
        }

        [SkippableFact]
        public void TestMethod05()
        {
            Invoke(threshold: 500);
        }

        [SkippableFact]
        public void TestMethod06()
        {
            Invoke(threshold: 500);
        }

        [SkippableFact]
        public void TestMethod07()
        {
            Invoke(threshold: 500);
        }

        [SkippableFact]
        public void TestMethod08()
        {
            Invoke(threshold: 500);
        }

        [SkippableFact]
        public void TestMethod09()
        {
            Invoke(threshold: 500);
        }

        [SkippableFact]
        public void TestMethod10()
        {
            Invoke(threshold: 500);
        }

        [SkippableFact]
        public void TestMethod11()
        {
            Invoke(threshold: 500);
        }

        [SkippableFact]
        public void TestMethod12()
        {
            Invoke(threshold: 500);
        }

        [SkippableFact]
        public void TestMethod13()
        {
            Invoke(threshold: 500);
        }

        [SkippableFact]
        public void TestMethod14()
        {
            Invoke(threshold: 500);
        }

        [SkippableTheory]
        [InlineData(100)]
        [InlineData(200)]
        [InlineData(300)]
        [InlineData(400)]
        [InlineData(500)]
        [InlineData(600)]
        [InlineData(700)]
        [InlineData(800)]
        [InlineData(900)]
        public void TestMethod15(int threshold)
        {
            Invoke(threshold);
        }

        private static void Invoke(int threshold)
        {
            // Generate a random number between 0 and 999 (inclusive)
            var actual = random.Next(minValue: 0, maxValue: 1000);

            // If the actual value falls within a certain range near the threshold, the test result is inconclusive
            Skip.If(
                condition: actual > threshold - 100 && actual < threshold,
                reason: "Actual value falls within a certain range near the threshold. Test result is inconclusive.");

            // Assert that the actual value is greater than the threshold
            Assert.True(
                condition: random.Next(minValue: 0, maxValue: 1000) > threshold,
                userMessage: "Actual value is not greater than the threshold.");
        }
    }
}
