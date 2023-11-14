using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint4.TaskReview.V30.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint4.TaskReview.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "684259137159648";
            DataService ds = new DataService();
            double res = ds.Calculate(n, m, str);
            double wait = 73728;

            Assert.AreEqual(wait, res);
        }
    }
}
