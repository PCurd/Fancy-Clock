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


        #region GetHour
        
        [TestMethod()]
        public void GetHour_Returns_One()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(1, 2, 3);
            string expected = TimeWords.One.ToString();
            var actual = target.GetHour(Time);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetHour_Returns_Five()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(5, 2, 3);
            string expected = TimeWords.Five.ToString();
            var actual = target.GetHour(Time);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetHour_Returns_Eleven_At_Twenty_Three()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(23, 2, 3);
            string expected = TimeWords.Eleven.ToString();
            var actual = target.GetHour(Time);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void GetHour_Returns_Twelve()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(12, 2, 3);
            string expected = TimeWords.Twelve.ToString();
            var actual = target.GetHour(Time);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetHour_Returns_Twelve_at_Midnight()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(0, 2, 3);
            string expected = TimeWords.Twelve.ToString();
            var actual = target.GetHour(Time);
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region GetHourPhrase

        [TestMethod()]
        public void GetHourPhrase_Returns_One()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(1, 2, 3);
            int expected = TimeWords.One.ToValue();
            var actual = target.GetHourPhrase(Time);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetHourPhrase_Returns_Five()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(5, 2, 3);
            int expected = TimeWords.Five.ToValue();
            var actual = target.GetHourPhrase(Time);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetHourPhrase_Returns_Eleven_At_Twenty_Three()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(23, 2, 3);
            int expected = TimeWords.Eleven.ToValue();
            var actual = target.GetHourPhrase(Time);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void GetHourPhrase_Returns_Twelve()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(12, 2, 3);
            int expected = TimeWords.Twelve.ToValue();
            var actual = target.GetHourPhrase(Time);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetHourPhrase_Returns_Twelve_at_Midnight()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(0, 2, 3);
            int expected = TimeWords.Twelve.ToValue();
            var actual = target.GetHourPhrase(Time);
            Assert.AreEqual(expected, actual);
        }
        #endregion


        #region GetMinute
        [TestMethod()]
        public void GetMinute_Returns_Null_For_Low_Numbers()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(1, 2, 3);
            string expected = null;
            var actual = target.GetMinute(Time);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetMinute_Returns_Null_For_High_Numbers()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(1, 59, 3);
            string expected = null;
            var actual = target.GetMinute(Time);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetMinute_Returns_Five_Past()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(1, 4, 3);
            string expected = TimeWords.Five.ToString() + " " + TimeWords.Past.ToString();
            var actual = target.GetMinute(Time);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetMinute_Returns_Five_To_On_Fifty_Five()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(1, 55, 3);
            string expected = TimeWords.Five.ToString() + " " + TimeWords.To.ToString();
            var actual = target.GetMinute(Time);
            Assert.AreEqual(expected, actual);
        }
#endregion

        #region GetMinutePhrase

        [TestMethod()]
        public void GetMinutePhrase_Returns_Null_For_Low_Numbers()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(1, 2, 3);
            int expected = 0;
            var actual = target.GetMinutePhrase(Time);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetMinutePhrase_Returns_Null_For_High_Numbers()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(1, 59, 3);
            int expected = 0;
            var actual = target.GetMinutePhrase(Time);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetMinutePhrase_Returns_Five_Past()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(1, 4, 3);
            int expected = TimeWords.FiveMinute.ToValue() + TimeWords.Past.ToValue();
            var actual = target.GetMinutePhrase(Time);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetMinutePhrase_Returns_Five_To_On_Fifty_Five()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(1, 55, 3);
            int expected = TimeWords.FiveMinute.ToValue() + TimeWords.To.ToValue();
            var actual = target.GetMinutePhrase(Time);
            Assert.AreEqual(expected, actual);
        }

        #endregion GetMinutePhrase

        [TestMethod()]
        public void GetTime_Returns_Five_To_Two_On_One_Fifty_Five()
        {
            FancyClockFormatter target = new FancyClockFormatter();
            TimeSpan Time = new TimeSpan(1, 55, 3);

            string expected = TimeWords.Five.ToString() + " " + TimeWords.To.ToString();
            var actual = target.GetMinute(Time);
            Assert.AreEqual(expected, actual);
        }
    }
}
