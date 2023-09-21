using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BotanogovDS.Sprint1.Task1.V29.Lib;

namespace Tyuiu.BotanogovDS.Sprint1.Task1.V29.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 1;
            double b = 2;
            double c = 3;
            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(1, res); 
        }
    }
}
