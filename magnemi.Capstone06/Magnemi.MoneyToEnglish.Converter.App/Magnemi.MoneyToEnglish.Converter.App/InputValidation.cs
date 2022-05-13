using System;

namespace Magnemi.MoneyToEnglish.Converter.App
{
    public class InputValidation
    {
        public bool stringToInt(string a)
        {
            try
            {
                Convert.ToInt32(a);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool stringToDouble(string a)
        {
            try
            {
                Convert.ToDouble(a);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool containsNoNumbers(string a)
        {
            for (int count = 0; count <= a.Length - 1; count++)
            {
                if (Char.IsNumber(a[count]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}