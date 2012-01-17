using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FancyClockService;
using Moq;

namespace FancyClockServiceTests
{
    [TestClass]
    public class ClassTests
    {
        Mock<FancyClockFormatter> mockFancyClockFormatter;
        [TestInitialize]
        public void SetupTests()
        {
            mockFancyClockFormatter = new Mock<FancyClockFormatter>();
        }

        [TestMethod]
        public void Can_Create_FancyClock()
        {
            
            
            var clock = new FancyClock(mockFancyClockFormatter.Object);
            Assert.IsNotNull(clock);
        }

        [TestMethod]
        public void When_Given_Time_Keeps_Time()
        {
            var Expected = new TimeSpan(1, 2, 3);
            var clock = new FancyClock(mockFancyClockFormatter.Object);
            clock.Time = Expected;
            var Actual = clock.Time;
            Assert.AreEqual(Expected, Actual);

        }

        [TestMethod]
        public void Calls_GetHour_To_Round_Hour()
        {
            var Time = new TimeSpan(1, 35, 0);//01:35:00
            mockFancyClockFormatter.Setup(x => x.GetHour(Time)).Returns("2");
            var Expected = "2";
            var clock = new FancyClock(mockFancyClockFormatter.Object);
            clock.Time = Time;
            var Actual = clock.Hour;
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void Calls_GetHour_To_Round_Minute()
        {
            var Time = new TimeSpan(1, 35, 0);//01:35:00
            mockFancyClockFormatter.Setup(x => x.GetMinute(Time)).Returns("30");
            var Expected = "30";
            var clock = new FancyClock(mockFancyClockFormatter.Object);
            clock.Time = Time;
            var Actual = clock.Minute;
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void Can_Create_FancyClockFormatter()
        {
            var formatter = new FancyClockFormatter();
        }
    }
}
