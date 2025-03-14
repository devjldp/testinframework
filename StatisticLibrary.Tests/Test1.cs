
using StatisticLibrary.Methods;

namespace StatisticLibrary.Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMean1()
        {
            List<double> numbersTest = new List<double>{4, 9, 12, 27, 2,  24, 6, 26, 16, 23};
            // Expected value
            double expectedValue = 14.9;

            // Actual value
            double actualValue = MySatistic.Mean(numbersTest);
            Assert.AreEqual(expectedValue, actualValue,$"Test Failed: The mean should be {expectedValue} instead of {actualValue}");
        }
    
        [TestMethod]
        public void TestMedian1()
        {
            // Data to test
            List<double> numbersTest = new List<double>{4, 9, 12, 27, 2,  24, 6, 26, 16, 23};

            // Expected value
            double expectedValue = 14;

            // Actual value
            double actualValue = MySatistic.Median(numbersTest);

            Assert.AreEqual(expectedValue, actualValue,$"Test failed: The median should be {expectedValue} instead of {actualValue}");

        }
    
    }

    [TestClass]
    public sealed class Test2
    {
        // property: datat test
        public List<double> dataTest;
        [TestInitialize]
        public void Initialize()
        {
            dataTest = new List<double> {10.25, 15.75, 20.125, 25.875, 30.5};
        }

        [TestMethod]
        public void TestMean2()
        {
            // Expected value
            double expectedValue = 20.5;

            // Actual value
            double actualValue = MySatistic.Mean(dataTest);

            Assert.AreEqual(expectedValue, actualValue,$"Test Failed: The mean should be {expectedValue} instead of {actualValue}"); 
        }

            [TestMethod]
            public void TestMedian2()
            {
                // Expected value
                double expectedValue = 20.125;

                // Actual value
                double actualValue = MySatistic.Median(dataTest);

                Assert.AreEqual(expectedValue, actualValue,$"Test Failed: The mean should be {expectedValue} instead of {actualValue}"); 
            }

            [TestCleanup]
            public void Cleanup(){}



    }
}

