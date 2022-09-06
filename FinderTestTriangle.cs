using Microsoft.VisualStudio.TestTools.UnitTesting;
using SFLibrary;
using System;

namespace FinderTest
{
    [TestClass]
    public class FinderTestTriangle
    {
        [TestMethod]
        public void TestingTriangle()
        {
            // arrange

            int n = 7;
            double[,] testMas = new double[,] {
                                                { 0, 2, 3 },
                                                { 1, 0, 3 },
                                                { 4, 6, 0 },
                                                { 2, 2, 3 },
                                                { 3, 4, 5 },
                                                { 0.5, 0.4, 0.3 },
                                                { 10, 10, 10 }
            };

            // act

            double[] result = new double[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = Math.Round(Finder.FindSquare(testMas[i, 0], testMas[i, 1], testMas[i, 2]), 4);
            }

            double[] trueResult = { -1, -1, -1, 1.9843, 6, 0.06, 43.3013 };

            // assert            

            for (int i = 0; i < n; i++)
            {
                Assert.AreEqual<double>(trueResult[i], result[i]);
            }

        }
    }
}
