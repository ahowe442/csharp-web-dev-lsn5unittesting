using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;
using System; 

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }
        
        //TODO: constructor sets gasTankLevel properly
        [TestMethod]
        public void TestInitialGasTank()
        {
            //Arragnge.
            //Instantiate a test_car (creates a variable that we'll use in testing.  
            Car test_car = new Car("Toyota", "Prius", 10, 50);

            //Act

            //Assert
            Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }

        Car test_car;
        [TestInitialize]
        public void CreateObject()
        {
            test_car = new Car("Toyota", "Prius", 10, 50);
        }

        [TestMethod]
        public void TestInitialGasTank2()
        {
            Assert.IsFalse(test_car.GasTankLevel == 0);
        }

        [TestMethod]
        public void TestInitialGasTank3()
        {
            Assert.IsTrue(test_car.GasTankLevel == 10);
        }

        //TODO: gasTankLevel is accurate after driving within tank range
        [TestMethod]
        public void TestGasTankLevelAfterDrivingWithinTankRange()
        {
            //Arrange
            test_car.Drive(50);
            //Act
            //Assert
            Assert.AreEqual(9, test_car.GasTankLevel, .001);
        }
        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        [TestMethod]
        public void TestGasTankAfterExceedingTankRange()
        {
            //Arrange
            test_car.Drive(550);
            //Act
            //Assert
            Assert.AreEqual(0, test_car.GasTankLevel, .001);
        }

        //TODO: can't have more gas than tank size, expect an exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        {
            test_car.AddGas(5);
            Assert.Fail("Shouldn't get here, car cannot have more gas in the tank than the ize of the tank.");
        }

    }
}
