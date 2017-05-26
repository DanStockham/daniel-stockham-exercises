using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TollBoothCalculator.Classes;

namespace Exercises.Tests
{
    /// <summary>
    /// Summary description for TollBothTests
    /// </summary>
    [TestClass]
    public class TollBothTests
    {
        public TollBothTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void VehicleTests()
        {
            Car testCar = new Car(false);
            Car testCarTrailer = new Car(true);

            Truck testTruck4 = new Truck(4);
            Truck testTruck6 = new Truck(6);
            Truck testTruck8 = new Truck(8);

            Tank testTank = new Tank();

            Assert.AreEqual(2.00, testCar.CalculateToll(100));
            Assert.AreEqual(3.00, testCarTrailer.CalculateToll(100));

            Assert.AreEqual(6.00, testTruck4.CalculateToll(150));
            Assert.AreEqual(6.75, testTruck6.CalculateToll(150));
            Assert.AreEqual(7.20, testTruck8.CalculateToll(150));

            Assert.AreEqual(0, testTank.CalculateToll(100));
            Assert.AreEqual(0, testTank.CalculateToll(150));
            Assert.AreEqual(0, testTank.CalculateToll(200));


        }
    }
}
