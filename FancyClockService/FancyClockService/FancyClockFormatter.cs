using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FancyClockService
{
    public class FancyClockFormatter
    {
        public virtual string GetHour(TimeSpan Time)
        {
            string Hour;
            switch (Time.Hours % 12)
            {
                case 0: Hour = TimeWords.Twelve.ToString(); break;
                case 1: Hour = TimeWords.One.ToString(); break;
                case 2: Hour = TimeWords.Two.ToString(); break;
                case 3: Hour = TimeWords.Three.ToString(); break;
                case 4: Hour = TimeWords.Four.ToString(); break;
                case 5: Hour = TimeWords.Five.ToString(); break;
                case 6: Hour = TimeWords.Six.ToString(); break;
                case 7: Hour = TimeWords.Seven.ToString(); break;
                case 8: Hour = TimeWords.Eight.ToString(); break;
                case 9: Hour = TimeWords.Nine.ToString(); break;
                case 10: Hour = TimeWords.Ten.ToString(); break;
                case 11: Hour = TimeWords.Eleven.ToString(); break;
                case 12: Hour = TimeWords.Twelve.ToString(); break;
                default: throw new NotSupportedException();
            }

            return Hour;
            }

        public virtual int GetHourPhrase(TimeSpan Time)
        {
            int Hour;
            switch (Time.Hours % 12)
            {
                case 0: Hour = TimeWords.Twelve.ToValue(); break;
                case 1: Hour = TimeWords.One.ToValue(); break;
                case 2: Hour = TimeWords.Two.ToValue(); break;
                case 3: Hour = TimeWords.Three.ToValue(); break;
                case 4: Hour = TimeWords.Four.ToValue(); break;
                case 5: Hour = TimeWords.Five.ToValue(); break;
                case 6: Hour = TimeWords.Six.ToValue(); break;
                case 7: Hour = TimeWords.Seven.ToValue(); break;
                case 8: Hour = TimeWords.Eight.ToValue(); break;
                case 9: Hour = TimeWords.Nine.ToValue(); break;
                case 10: Hour = TimeWords.Ten.ToValue(); break;
                case 11: Hour = TimeWords.Eleven.ToValue(); break;
                case 12: Hour = TimeWords.Twelve.ToValue(); break;
                default: throw new NotSupportedException();
            }

            return Hour;
        }

        public virtual string GetMinute(TimeSpan Time)
        {
            string Minute;
            switch (Time.Minutes)
            {
                case 58:
                case 59:
                case 0:
                case 1:
                case 2: return null;
                case 3:
                case 4:
                case 5:
                case 6:
                case 7: Minute = TimeWords.FiveMinute.ToString(); break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12: Minute = TimeWords.TenMinute.ToString(); break;
                case 13:
                case 14:
                case 15:
                case 16:
                case 17: Minute = TimeWords.Quarter.ToString(); break;
                case 18:
                case 19:
                case 20:
                case 21:
                case 22: Minute = TimeWords.Twenty.ToString(); break;
                case 23: 
                case 24:
                case 25:
                case 26:
                case 27: Minute = TimeWords.Twenty.ToString() + " " + TimeWords.FiveMinute.ToString(); break;
                case 28:
                case 29:
                case 30:
                case 31:
                case 32: Minute = TimeWords.Half.ToString(); break;
                case 33:
                case 34:
                case 35:
                case 36:
                case 37: Minute = TimeWords.Twenty.ToString() + " " + TimeWords.FiveMinute.ToString(); break;
                case 38:
                case 39:
                case 40:
                case 41:
                case 42: Minute = TimeWords.Twenty.ToString(); break;
                case 43:
                case 44:
                case 45:
                case 46:
                case 47: Minute = TimeWords.Quarter.ToString(); break;
                case 48:
                case 49:
                case 50:
                case 51:
                case 52: Minute = TimeWords.TenMinute.ToString(); break;
                case 53:
                case 54:
                case 55:
                case 56:
                case 57: Minute = TimeWords.FiveMinute.ToString(); break;
                



                default: throw new NotSupportedException();
            }

            //To: 33-57
            //Past: 3-27
            string Modifier = string.Empty;
            if ((Time.Minutes) >= 33 & (Time.Minutes) <= 57)
                Modifier=TimeWords.To.ToString();
            else if ((Time.Minutes) >= 3 & (Time.Minutes) <= 27)
                Modifier = TimeWords.Past.ToString();


            return Minute + " " + Modifier;
           
        }

        public virtual int GetMinutePhrase(TimeSpan Time)
        {
            int MinutePhrase;
            switch (Time.Minutes)
            {
                case 58:
                case 59:
                case 0:
                case 1:
                case 2: return 0;
                case 3:
                case 4:
                case 5:
                case 6:
                case 7: MinutePhrase = TimeWords.FiveMinute.ToValue(); break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12: MinutePhrase = TimeWords.TenMinute.ToValue(); break;
                case 13:
                case 14:
                case 15:
                case 16:
                case 17: MinutePhrase = TimeWords.Quarter.ToValue(); break;
                case 18:
                case 19:
                case 20:
                case 21:
                case 22: MinutePhrase = TimeWords.Twenty.ToValue(); break;
                case 23:
                case 24:
                case 25:
                case 26:
                case 27: MinutePhrase = TimeWords.Twenty.ToValue() + TimeWords.FiveMinute.ToValue(); break;
                case 28:
                case 29:
                case 30:
                case 31:
                case 32: MinutePhrase = TimeWords.Half.ToValue(); break;
                case 33:
                case 34:
                case 35:
                case 36:
                case 37: MinutePhrase = TimeWords.Twenty.ToValue() + TimeWords.FiveMinute.ToValue(); break;
                case 38:
                case 39:
                case 40:
                case 41:
                case 42: MinutePhrase = TimeWords.Twenty.ToValue(); break;
                case 43:
                case 44:
                case 45:
                case 46:
                case 47: MinutePhrase = TimeWords.Quarter.ToValue(); break;
                case 48:
                case 49:
                case 50:
                case 51:
                case 52: MinutePhrase = TimeWords.TenMinute.ToValue(); break;
                case 53:
                case 54:
                case 55:
                case 56:
                case 57: MinutePhrase = TimeWords.FiveMinute.ToValue(); break;




                default: throw new NotSupportedException();
            }

            //To: 33-57
            //Past: 3-27
            int Modifier = 0;
            if ((Time.Minutes) >= 33 & (Time.Minutes) <= 57)
                Modifier = TimeWords.To.ToValue();
            else if ((Time.Minutes) >= 3 & (Time.Minutes) <= 27)
                Modifier = TimeWords.Past.ToValue();


            return MinutePhrase + Modifier;

        }
    }
}
