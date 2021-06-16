using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FromAtoBTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetDistance()
        {
            double x1_1 = 10.1;
            double y1_1 = 30.1;
            
            double x2_1 = 20.5;
            double y2_1 = 50.5;

            double x1_2 = 20.63;
            double y1_2 = 50.63;

            double x2_2 = 30.52;
            double y2_2 = 60.62;

            double x1_3 = 50.151;
            double y1_3 = 80.151;

            double x2_3 = 70.511;
            double y2_3 = 100.511;


            Assert.AreEqual(22.90, Math.Round(FromAtoB.Program.GetDistance(x1_1, y1_1, x2_1, y2_1), 2, MidpointRounding.AwayFromZero));
            Assert.AreEqual(14.06, Math.Round(FromAtoB.Program.GetDistance(x1_2, y1_2, x2_2, y2_2), 2, MidpointRounding.AwayFromZero));
            Assert.AreEqual(28.79, Math.Round(FromAtoB.Program.GetDistance(x1_3, y1_3, x2_3, y2_3), 2, MidpointRounding.AwayFromZero));
        }
    }
}
