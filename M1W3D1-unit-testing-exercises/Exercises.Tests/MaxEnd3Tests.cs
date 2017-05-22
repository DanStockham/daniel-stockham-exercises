using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    /// <summary>
    /// Summary description for MaxEnd3Tests
    /// </summary>
    [TestClass]
    public class MaxEnd3Tests
    {
        public MaxEnd3Tests()
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
        public void MaxEnd3Test()
        {
            MaxEnd3 newMax = new MaxEnd3();

            CollectionAssert.AreEqual(new int[] { 3, 3, 3, 3 }, newMax.MakeArray(new int[] { 0, 2, 2, 3 }));
            CollectionAssert.AreEqual(new int[] { 5, 5 }, newMax.MakeArray(new int[] { 2, 5 }));
            CollectionAssert.AreEqual(new int[] { 10, 10, 10, 10, 10 }, newMax.MakeArray(new int[] { 8, 3, 2, 4, 10 }));
        }
    }
}
