using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolarSystem;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class SolarSystemTest
    {
        // Singleton
        [TestMethod]
        public void ShouldContainsOnlyOneSun()
        {
            var firstSun = Sun.GetInstance();
            var secondSun = Sun.GetInstance();
            
            Assert.AreEqual(secondSun, firstSun);
        }
    }
}
