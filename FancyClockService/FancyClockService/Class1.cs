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

    public struct TimeWords
    {
        public bool Half { get; set; }
        public bool TenMinute { get; set; }
        public bool Quarter { get; set; }
        public bool Twenty { get; set; }
        public bool FiveMinute { get; set; }
        public bool Minutes { get; set; }
        public bool To { get; set; }
        public bool Past { get; set; }
        public bool One { get; set; }
        public bool Two { get; set; }
        public bool Three { get; set; }
        public bool Four { get; set; }
        public bool Five { get; set; }
        public bool Six { get; set; }
        public bool Seven { get; set; }
        public bool Eight { get; set; }
        public bool Nine { get; set; }
        public bool Ten { get; set; }
        public bool Eleven { get; set; }
        public bool Twelve { get; set; }
        public bool OClock { get; set; }

    }

   
    //public sealed class TimeWords
    //{

    //    private readonly String name;
    //    private readonly int value;

    //    //private static readonly Dictionary<string, TimeWords> instance;

    //    public static readonly TimeWords Half                = new TimeWords(1, "Half");
    //    public static readonly TimeWords TenMinute           = new TimeWords(2, "Ten");
    //    public static readonly TimeWords Quarter             = new TimeWords(4, "Quarter");
    //    public static readonly TimeWords Twenty              = new TimeWords(8, "Twenty");
    //    public static readonly TimeWords FiveMinute          = new TimeWords(16, "Five");
    //    public static readonly TimeWords Minutes             = new TimeWords(32, "Minutes");
    //    public static readonly TimeWords To                  = new TimeWords(64, "To");
    //    public static readonly TimeWords Past                = new TimeWords(128, "Past");
    //    public static readonly TimeWords One                 = new TimeWords(256, "One");
    //    public static readonly TimeWords Two                 = new TimeWords(512, "Two");
    //    public static readonly TimeWords Three               = new TimeWords(1024, "Three");
    //    public static readonly TimeWords Four                = new TimeWords(2048, "Four");
    //    public static readonly TimeWords Five                = new TimeWords(4096, "Five");
    //    public static readonly TimeWords Six                 = new TimeWords(8192, "Six");
    //    public static readonly TimeWords Seven               = new TimeWords(16384, "Seven");
    //    public static readonly TimeWords Eight               = new TimeWords(32768, "Eight");
    //    public static readonly TimeWords Nine                = new TimeWords(65536, "Nine");
    //    public static readonly TimeWords Ten                 = new TimeWords(2131072, "Ten");
    //    public static readonly TimeWords Eleven              = new TimeWords(262144, "Eleven");
    //    public static readonly TimeWords Twelve              = new TimeWords(524288, "Twelve");
    //    public static readonly TimeWords OClock              = new TimeWords(1048576, "O'Clock");

    //    private TimeWords(int value, String name)
    //    {
    //        this.name = name;
    //        this.value = value;
    //        //instance[name] = value;

    //    }

    //    public override String ToString()
    //    {
    //        return name;
    //    }

    //    public int ToValue()
    //    {
    //        return value;
    //    }


    //    //public static explicit operator TimeWords(string str)
    //    //{
    //    //    TimeWords result;
    //    //    if (instance.TryGet(str, out result))
    //    //        return result;
    //    //    else
    //    //        throw new InvalidCastException();
    //    //}
    //}
}
