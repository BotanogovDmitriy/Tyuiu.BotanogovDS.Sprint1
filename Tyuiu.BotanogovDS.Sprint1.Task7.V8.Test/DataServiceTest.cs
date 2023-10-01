using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BotanogovDS.Sprint1.Task7.V8.Lib;

namespace Tyuiu.BotanogovDS.Sprint1.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 3.702;
            var res = ds.Calculate(x, y);
            Assert.IsTrue(Math.Abs(wait - res) < 0.001);
        }
    }
}
