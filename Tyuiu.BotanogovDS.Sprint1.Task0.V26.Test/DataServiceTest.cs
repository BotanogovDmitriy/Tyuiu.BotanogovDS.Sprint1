using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BotanogovDS.Sprint1.Task0.V26.Lib;

namespace Tyuiu.BotanogovDS.Sprint1.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(7, res);

        }
    }
}
