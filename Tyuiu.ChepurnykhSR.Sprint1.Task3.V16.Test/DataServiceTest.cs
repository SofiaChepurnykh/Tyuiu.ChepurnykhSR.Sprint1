using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChepurnykhSR.Sprint1.Task3.V16.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint1.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = -5;
            var res = ds.CoeffOfQuadraticEquation(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
