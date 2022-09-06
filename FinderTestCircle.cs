using Microsoft.VisualStudio.TestTools.UnitTesting;
using SFLibrary;
using System;

namespace FinderTest
{
    [TestClass]
    public class FinderTestCircle
    {
        [TestMethod]
        public void TestingCircle()
        {
            // arrange

            int n = 5;
            double[] testMas = { -2, 0, 3, 2, 0.01};

            // act

            double[] result = new double[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = Math.Round(Finder.FindSquare(testMas[i]), 4);
            }

            double[] trueResult = { -1, -1, 28.2743, 12.5664, 0.0003 };

            // assert            

            for (int i = 0; i < n; i++)
            {
                Assert.AreEqual<double>(trueResult[i], result[i]);
            }

        }
    }
}
