using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FancyClockService
{
    public class FancyClock
    {
        FancyClockFormatter formatter;

        public FancyClock(FancyClockFormatter formatter)
        {
            this.formatter = formatter;
        }

        public TimeSpan Time { get; set; }
        public TimeWords Hour { get { return formatter.GetHour(Time); } }
        public TimeWords Minute { get { return formatter.GetMinute(Time); } }
    }
}
