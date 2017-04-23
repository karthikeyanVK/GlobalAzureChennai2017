using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiveUnitTestSample;

namespace LiveUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Athlete athlete = new Athlete();
            Assert.IsFalse(athlete.IsAthlete());
        }
        [TestMethod]
        public void TestMethod2()
        {
            Athlete athlete = new Athlete();
            var biker = athlete.GetBikerDetails();
           
            if (biker.BikerName.Length == 10)
            {
                Console.WriteLine("not null");
            }
            Assert.Equals(biker.MaxDistanceRode, 10);
        }
    }
}
