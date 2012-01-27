using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FancyClockService
{
    public class FancyClockFormatter
    {
        public virtual TimeWords GetTime(TimeSpan Time)
        {
            TimeWords Hour = new TimeWords();
            Hour = GetHour(Time);
            TimeWords Minute = new TimeWords();
            Minute = GetMinute(Time);

            if (Minute.To)
                Hour--;

            return Hour + Minute;
        }

        public virtual TimeWords GetHour(TimeSpan Time)
        {
           
            TimeWords Hour = new TimeWords();

            switch (Time.Hours % 12)
            {
                case 0: Hour.Twelve = true; break;
                case 1: Hour.One = true; break;
                case 2: Hour.Two = true; break;
                case 3: Hour.Three = true; break;
                case 4: Hour.Four = true; break;
                case 5: Hour.Five = true; break;
                case 6: Hour.Six = true; break;
                case 7: Hour.Seven = true; break;
                case 8: Hour.Eight = true; break;
                case 9: Hour.Nine = true; break;
                case 10: Hour.Ten = true; break;
                case 11: Hour.Eleven = true; break;
                case 12: Hour.Twelve = true; break;
                default: throw new NotSupportedException();
            }

            return Hour;
            }

      

        public virtual TimeWords GetMinute(TimeSpan Time)
        {
            TimeWords Minute = new TimeWords();
            switch (Time.Minutes)
            {
                case 58:
                case 59:
                case 0:
                case 1:
                case 2: return Minute;
                case 3:
                case 4:
                case 5:
                case 6:
                case 7: Minute.FiveMinute=true; break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12: Minute.TenMinute = true; break;
                case 13:
                case 14:
                case 15:
                case 16:
                case 17: Minute.Quarter = true; break;
                case 18:
                case 19:
                case 20:
                case 21:
                case 22: Minute.Twenty = true; break;
                case 23: 
                case 24:
                case 25:
                case 26:
                case 27: Minute.Twenty = true; Minute.FiveMinute = true; break;
                case 28:
                case 29:
                case 30:
                case 31:
                case 32: Minute.Half = true; break;
                case 33:
                case 34:
                case 35:
                case 36:
                case 37: Minute.Twenty = true; Minute.FiveMinute = true; break;
                case 38:
                case 39:
                case 40:
                case 41:
                case 42: Minute.Twenty = true; break;
                case 43:
                case 44:
                case 45:
                case 46:
                case 47: Minute.Quarter = true; break;
                case 48:
                case 49:
                case 50:
                case 51:
                case 52: Minute.TenMinute = true; break;
                case 53:
                case 54:
                case 55:
                case 56:
                case 57: Minute.FiveMinute = true; break;
                



                default: throw new NotSupportedException();
            }

            //To: 33-57
            //Past: 3-27
            string Modifier = string.Empty;
            if ((Time.Minutes) >= 33 & (Time.Minutes) <= 57)
                Minute.To = true;
            else if ((Time.Minutes) >= 3 & (Time.Minutes) <= 27)
                Minute.Past = true;


            return Minute;
           
        }

    }
}
