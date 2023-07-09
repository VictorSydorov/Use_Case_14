namespace Use_Case_14.Helpers
{
    using System;
    using System.Globalization;
     
public static class DateTimeHelper
    {
        public static string FormatShortDate(this DateTime dateTime, CultureInfo culture)
        {
            
            DateTimeFormatInfo formatInfo = culture.DateTimeFormat;
            return dateTime.ToString(formatInfo.ShortDatePattern, culture);
        }

        public static string FormatLongDate(this DateTime dateTime, CultureInfo culture) => dateTime.ToString("dddd, dd MMMM yyyy", culture);

        public static string FormatShortTime(this DateTime dateTime, CultureInfo culture)
        {               
            DateTimeFormatInfo formatInfo = culture.DateTimeFormat;
            return dateTime.ToString(formatInfo.ShortTimePattern, culture);
        }

        public static string FormatLongTime(this DateTime dateTime, CultureInfo culture) => dateTime.ToString("hh:mm:ss tt", culture);
    }

}


