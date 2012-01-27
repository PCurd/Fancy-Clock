using FancyClockService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FancyClockServiceTests
{
    
    
    /// <summary>
    ///This is a test class for TimeWordsTest and is intended
    ///to contain all TimeWordsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TimeWordsTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for op_Addition
        ///</summary>
        [TestMethod()]
        public void op_AdditionTest()
        {
            TimeWords c1 = new TimeWords();
            TimeWords c2 = new TimeWords();
            TimeWords expected = new TimeWords();

            c1.Eight = true;
            c2.FiveMinute = true;
            c2.To = true;

            expected.Eight = true;
            expected.FiveMinute = true;
            expected.To = true;
            TimeWords actual;
            actual = (c1 + c2);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void op_Decrement_Reduces_Hour()
        {
            TimeWords c1 = new TimeWords(); 
            TimeWords expected = new TimeWords();

            c1.Eight = true;
            c1.FiveMinute = true;
            c1.To = true;

            expected.Seven = true;
            expected.FiveMinute = true;
            expected.To = true;

            TimeWords actual;
            actual = --(c1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void op_Decrement_Reduces_Hour_From_One_To_Twelve()
        {
            TimeWords c1 = new TimeWords();
            TimeWords expected = new TimeWords();

            c1.One = true;
            c1.FiveMinute = true;
            c1.To = true;

            expected.Twelve = true;
            expected.FiveMinute = true;
            expected.To = true;

            TimeWords actual;
            actual = --(c1);
            Assert.AreEqual(expected, actual);
        }
    }
}
