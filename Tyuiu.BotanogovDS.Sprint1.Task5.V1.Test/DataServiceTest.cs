using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.BotanogovDS.Sprint1.Task5.V1.Lib;

namespace Tyuiu.BotanogovDS.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestDistanceBetweenDots()
        {
            DataService dataService = new DataService();
            double x1 = 1;
            double y1 = 1;
            double x2 = 4;
            double y2 = 5;

            int distance = dataService.DistanceBetweenDots(x1, y1, x2, y2);

            Assert.AreEqual(5, distance);
        }
    }
}
