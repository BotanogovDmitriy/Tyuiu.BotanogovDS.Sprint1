using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BotanogovDS.Sprint1.Task2.V30.Lib;

namespace Tyuiu.BotanogovDS.Sprint1.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            var res = ds.ConvertKmToMetre(x);
            Assert.AreEqual(1000.0, res);
        }
    }
}
