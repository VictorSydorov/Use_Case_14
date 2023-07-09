namespace Use_Case_14.Helpers
{
    using System.Globalization;

    public static class NumberHelper
    {
        public static string FormatNumber(this int number, CultureInfo culture)
        {            
           
            string formattedNumber = number.ToString("N0", culture); // Default format with no decimal places

            if (number >= 1000000000)
            {
                formattedNumber = number.ToString("0.##E+0", culture); // Scientific notation for billion and above
            }
            else if (number >= 1000000)
            {
                formattedNumber = number.ToString("#,##0,,M", culture); // Millions format
            }
            else if (number >= 1000)
            {
                formattedNumber = number.ToString("#,##0,K", culture); // Thousands format
            }

            return formattedNumber;
        }
    }

}
