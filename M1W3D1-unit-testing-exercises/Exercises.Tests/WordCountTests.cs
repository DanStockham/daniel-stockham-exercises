using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    /// <summary>
    /// Summary description for WordCountTests
    /// </summary>
    [TestClass]
    public class WordCountTests
    {
        public WordCountTests()
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
        public void WordCountTest()
        {
            WordCount newStr = new WordCount();

            CollectionAssert.AreEqual(new Dictionary<string, int> {
                { "b", 1 },
                { "i", 1 },
                { "g", 2 },
                { "e", 1 },
                { "r", 1} }, newStr.GetCount(new string[] { "b", "i", "g", "g", "e", "r"}));
            CollectionAssert.AreEqual(new Dictionary<string, int> {
                { "a", 2 },
                { "b", 1 },
                { "c", 1 },
                { "d", 1 },
                { "f", 2} }, newStr.GetCount(new string[] { "a", "a", "b", "c", "d", "f", "f" }));
            CollectionAssert.AreEquivalent(new Dictionary<string, int> {
                { "x", 2 },
                { "y", 2 },
                { "z", 4 },
                 }, newStr.GetCount(new string[] { "z", "z", "z", "z", "x", "y", "y", "x" }));
        }
    }
}
