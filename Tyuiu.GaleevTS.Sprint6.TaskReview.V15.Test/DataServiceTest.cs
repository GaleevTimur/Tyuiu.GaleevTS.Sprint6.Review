using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GaleevTS.Sprint6.TaskReview.V15.Lib;

namespace Tyuiu.GaleevTS.Sprint6.TaskReview.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            int k = 1;
            int l = 4;
            int c = 0;
            int n = 5;
            int m = 5;
            int n1 = 3;
            int n2 = 9;

            int[,] array = ds.GetMatrix(n, m, n1, n2);

            int res = ds.GetMult(array, c, k, l);
            int wait = 12;

            Assert.AreEqual(wait, res);
        }
    }

}