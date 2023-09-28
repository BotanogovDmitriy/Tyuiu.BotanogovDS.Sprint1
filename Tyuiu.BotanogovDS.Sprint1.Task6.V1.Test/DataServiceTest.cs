using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BotanogovDS.Sprint1.Task6.V1.Lib;


namespace Tyuiu.BotanogovDS.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSymbolCode()
        {
            DataService dataService = new DataService();
            string value = "A";
            string expected = "Символ: A\nКод: 65";

            string result = dataService.SymbolCode(value);

            Assert.AreEqual(expected, result);
        }
    }
}
