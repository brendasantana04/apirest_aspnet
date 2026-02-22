namespace RESTWithASPNET10.Helper
{
    public class ConvertHelper
    {
        public static decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalNumber;
            if (decimal.TryParse(strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out decimalNumber))
            {
                return decimalNumber;
            }
            return 0;
        }
        public static double ConvertToDouble(string strNumber)
        {
            double doubleNumber;
            if (double.TryParse(strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out doubleNumber))
            {
                return doubleNumber;
            }
            return 0;
        }
        public static bool IsNumeric(string strNumber)
        {
            decimal decimalNumber;
            bool isNumber = decimal.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out decimalNumber);
            {
                return isNumber;
            }
        }
    }
}
