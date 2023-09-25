using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BotanogovDS.Sprint1.Task3.V8.Lib;

namespace Tyuiu.BotanogovDS.Sprint1.Task3.V8.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 30;
            double y = 20;
            double wait = 41.10;
            var res = ds.IncomeAmount(x, y);
            Assert.AreEqual(wait, Math.Round(res, 2));
        }
    }
}
