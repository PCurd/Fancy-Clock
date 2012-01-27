using FancyClockService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FancyClockServiceTests
{


    /// <summary>
    ///This is a test class for FancyClockFormatterTest and is intended
    ///to contain all FancyClockFormatterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FancyClockFormatterTest
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

        public TimeWords RunGetHourTest(TimeSpan Time)
        {
            FancyClockFormatter target = new FancyClockFormatter();
            return target.GetHour(Time);
        }

        public TimeWords RunGetMinuteTest(TimeSpan Time)
        {
            FancyClockFormatter target = new FancyClockFormatter();
            return target.GetMinute(Time);
        }


        #region GetHour
        
        [TestMethod()]
        public void GetHour_Returns_One()
        {
            TimeWords expected = new TimeWords();
            expected.One = true;
            var actual = RunGetHourTest(new TimeSpan(1, 2, 3));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetHour_Returns_Five()
        {
            TimeWords expected = new TimeWords();
            expected.Five = true;
            var actual = RunGetHourTest(new TimeSpan(5, 2, 3));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetHour_Returns_Eleven_At_Twenty_Three()
        {
            TimeWords expected = new TimeWords();
            expected.Eleven = true;
            var actual = RunGetHourTest(new TimeSpan(23, 2, 3));
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void GetHour_Returns_Twelve()
        {
            TimeWords expected = new TimeWords();
            expected.Twelve = true;
            var actual = RunGetHourTest(new TimeSpan(12, 2, 3));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetHour_Returns_Twelve_at_Midnight()
        {
            TimeWords expected = new TimeWords();
            expected.Twelve = true;
            var actual = RunGetHourTest(new TimeSpan(0, 2, 3));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetHour_Does_Not_Return_Twelve_at_One()
        {
            TimeWords expected = new TimeWords();
            expected.Twelve = true;
            var actual = RunGetHourTest(new TimeSpan(1, 2, 3));
            Assert.AreNotEqual(expected, actual);
        }
        #endregion

  


       #region GetMinute
        [TestMethod()]
        public void GetMinute_Returns_Null_For_Low_Numbers()
        {
            TimeWords expected = new TimeWords();
            var actual = RunGetMinuteTest(new TimeSpan(1, 2, 3));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetMinute_Returns_Null_For_High_Numbers()
        {
            TimeWords expected = new TimeWords();
            var actual = RunGetMinuteTest(new TimeSpan(1, 59, 3));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetMinute_Returns_Five_Past()
        {
            TimeWords expected = new TimeWords();
            expected.FiveMinute = true; expected.Past = true;
            var actual = RunGetMinuteTest(new TimeSpan(1, 4, 3));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetMinute_Returns_Five_To_On_Fifty_Five()
        {
            TimeWords expected = new TimeWords();
            expected.FiveMinute = true; expected.To = true;
            var actual = RunGetMinuteTest(new TimeSpan(1, 55, 3));
            Assert.AreEqual(expected, actual);
        }
#endregion


        [TestMethod()]
        public void GetTime_Returns_Five_To_Two_On_One_Fifty_Five()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(1, 55, 3);
            TimeWords expected = new TimeWords();
            expected.Two = true; expected.FiveMinute = true; expected.To = true;
            var actual = target.GetTime(Time);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTime_Returns_Five_To_One_On_Twelve_Fifty_Five()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(12, 55, 3);
            TimeWords expected = new TimeWords();
            expected.One = true; expected.FiveMinute = true; expected.To = true;
            var actual = target.GetTime(Time);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTime_Returns_Five_Past_Two_On_Two_Five()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(2, 5, 3);
            TimeWords expected = new TimeWords();
            expected.Two = true; expected.FiveMinute = true; expected.Past = true;
            var actual = target.GetTime(Time);
            Assert.AreEqual(expected, actual);
        }
    }
}
