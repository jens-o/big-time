using System;

namespace BigLib
{
    public class BigTime
    {
        private DateTime _dateTime;

        #region Constructors

        public BigTime()
        {
            _dateTime = new DateTime();
        }

        public BigTime(DateTime utcDateTime)
        {
            _dateTime = utcDateTime;
        }

        public BigTime(long time, TimeFormat format)
        {
            switch (format)
            {
                case TimeFormat.InternetTime:
                    if (time < 0 || time > 999)
                        throw new FormatException("Not a valid internet time.");

                    // Internet Time (Today + the specified Internet Time, convert BMT to UTC 
                    _dateTime = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, DateTime.UtcNow.Day) + TimeSpan.FromSeconds(time * 86.4) - new TimeSpan(1, 0, 0);
                    break;
                case TimeFormat.UnixTime:
                    if (time < 0)
                        throw new FormatException("Not a valid UNIX time.");

                    _dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(time);
                    break;
                default:
                    throw new FormatException("Format is not a valid TimeFormat for numeric time representation.");
            }
        }

        public BigTime(string time) : this(time, TimeZoneInfo.Utc)
        {
        }

        public BigTime(string time, TimeZoneInfo timeZoneInfo)
        {
            long lngTime;
            
            if (time.StartsWith("@"))
            {
                time = time.Replace("@", "");

                if (long.TryParse(time, out lngTime))
                    _dateTime = BigTime.Parse(lngTime, TimeFormat.InternetTime)._dateTime;
                else
                    throw new FormatException("Not a valid internet time.");
            }
            else
            {
                if (long.TryParse(time, out lngTime))
                {
                    _dateTime = BigTime.Parse(lngTime, TimeFormat.UnixTime)._dateTime;
                }
                else
                {
                    DateTime dateTime = DateTime.Parse(time);
                    _dateTime = dateTime - timeZoneInfo.GetUtcOffset(dateTime);
                }
            }
        }

        #endregion

        #region Converters
        public long ToUnixTime()
        {
            return (long)(_dateTime.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }

        public int ToInternetTime()
        {
            // Convert to BMT
            DateTime bmtTime = _dateTime + new TimeSpan(1, 0, 0);

            return (int)Math.Round((bmtTime.Hour * 41.666) + (bmtTime.Minute * 0.6944) + (bmtTime.Second * 0.01157));
        }

        public string ToInternetTimeString()
        {
            return String.Format("@{0}", ToInternetTime().ToString("000"));
        }

        public DateTime ToLocalTime()
        {
            return _dateTime.ToLocalTime();
        }

        public DateTime ToLocalTime(TimeSpan utcOffset)
        {
            return _dateTime + utcOffset;
        }

        public override string ToString()
        {
            return _dateTime.ToString();
        }

        public string ToString(IFormatProvider formatProvider)
        {
            return _dateTime.ToString(formatProvider);
        }

        public string ToString(string format)
        {
            return _dateTime.ToString(format);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return _dateTime.ToString(format, formatProvider);
        }

        #endregion

        #region Parsers

        public static BigTime Parse(string dateTime)
        {
            return new BigTime(dateTime);
        }

        public static BigTime Parse(string dateTime, TimeZoneInfo timeZoneInfo)
        {
            return new BigTime(dateTime, timeZoneInfo);
        }

        public static BigTime Parse(long time, TimeFormat format)
        {
            return new BigTime(time, format);
        }

        #endregion

        #region Properties
        public static BigTime UtcNow
        {
            get
            {
                return new BigTime(DateTime.UtcNow);
            }
        }

        #endregion

        #region Operators

        public static implicit operator BigTime(DateTime utcDateTime)
        {
            return new BigTime(utcDateTime);
        }

        #endregion

        public enum TimeFormat
        {
            UtcTime,
            LocalTime,
            UnixTime,
            InternetTime
        }
    }
}
