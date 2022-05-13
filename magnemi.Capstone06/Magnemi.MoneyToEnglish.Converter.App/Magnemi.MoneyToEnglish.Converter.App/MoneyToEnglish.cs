using System;

namespace Magnemi.MoneyToEnglish.Converter.App
{
    public class MoneyToEnglish
    {
        private String _convertedNumber = null;
        private String _currencyType = null;

        public MoneyToEnglish(String moneyInNumbers, String currencyType)
        {
            moneyInNumbers = removeCommasFromTheInputString(moneyInNumbers);

            moneyInNumbers = removeDollarSignFromtheInputString(moneyInNumbers);

            moneyInNumbers = removeLeadingZeroes(moneyInNumbers);

            exitProgramIdentifier(moneyInNumbers);

            if (!invalidInputIdentifier(moneyInNumbers) && centsInCorrectFormatValidator(moneyInNumbers))
            {
                if (moneyInNumbers.Contains('.'))
                {
                    moneyInNumbers = addZerosToCentsAtTheEndOfTheInput(moneyInNumbers);
                }
                else
                {
                    moneyInNumbers = addCentsIfInputDoesNotContainCents(moneyInNumbers);
                }

                if (Convert.ToDouble(moneyInNumbers) >= 1.00)
                {
                    moneyIsOneDollarIdentifier(moneyInNumbers);
                }

                if (billionsPlaceIdentifier(moneyInNumbers))
                {
                    moneyInNumbers = numberToWordConverter(" billion", moneyInNumbers);
                }

                if (millionsPlaceIdentifier(moneyInNumbers))
                {
                    moneyInNumbers = numberToWordConverter(" million", moneyInNumbers);
                }

                if (thousandsPlaceIdentifier(moneyInNumbers))
                {
                    moneyInNumbers = numberToWordConverter(" thousand", moneyInNumbers);
                }

                if (hundredsPlaceIdentifier(moneyInNumbers))
                {
                    moneyInNumbers = numberToWordConverter("", moneyInNumbers);
                }

                if (!get_convertedNumber().Equals(null))
                {
                    set_convertedNumber(_convertedNumber + " " + _currencyType);
                }

                if (numberContainsCentsIdentifier(moneyInNumbers) && !moneyInNumbers.EndsWith(".00"))
                {
                    moneyInNumbers = numberToWordConverter(greaterThanOneCentWordConverter("cents", moneyInNumbers), moneyInNumbers);
                }
            }
        }

        public bool set_convertedNumber(String a)
        {
            if (a != null)
            {
                _convertedNumber = a;
                return true;
            }
            return false;
        }

        public string get_convertedNumber()
        {
            if (_convertedNumber != null)
            {
                return _convertedNumber.Trim();
            }
            return "The input was not in the correct format please enter again";
        }

        public bool set_currencyType(String a)
        {
            InputValidation validWord = new InputValidation();

            if (a != null && !validWord.containsNoNumbers(a))
            {
                _currencyType = a;
                return true;
            }
            return false;
        }

        public String greaterThanOneDollarWordConverter(String dollars, String moneyInNumbers)
        {
            if (Convert.ToDouble(moneyInNumbers) > 2.00 && Convert.ToDouble(moneyInNumbers) >= 0)
            {
                return " dollars";
            }
            else if (Convert.ToDouble(moneyInNumbers) <= 2.00 && Convert.ToDouble(moneyInNumbers) >= 0)
            {
                return " dollar";
            }
            return dollars;
        }

        public String greaterThanOneCentWordConverter(String cents, String moneyInNumbers)
        {
            if (Convert.ToDouble(moneyInNumbers) > .01 && Convert.ToDouble(moneyInNumbers) >= 0)
            {
                return " cents";
            }
            else if (Convert.ToDouble(moneyInNumbers) < .02 && Convert.ToDouble(moneyInNumbers) >= 0)
            {
                return " cent";
            }
            return cents;
        }

        public String get_currencyType()
        {
            if (_currencyType != null)
            {
                return _currencyType;
            }
            return "Invalid currency type";
        }

        public String convertHundredsDigitToWord(String moneyInNumbersWorkingString)
        {
            if (moneyInNumbersWorkingString[0] == '.' && !get_convertedNumber().Equals(""))
            {
                set_convertedNumber(_convertedNumber + " and");
                return moneyInNumbersWorkingString = moneyInNumbersWorkingString.Remove(0, 1);
            }
            else if (moneyInNumbersWorkingString[0] == '.' && get_convertedNumber().Equals(""))
            {
                return moneyInNumbersWorkingString = moneyInNumbersWorkingString.Remove(0, 1);
            }
            else if (moneyInNumbersWorkingString.Length % 3 == 0 && moneyInNumbersWorkingString[0] != '0')
            {
                set_convertedNumber(_convertedNumber + hundredsConverter(moneyInNumbersWorkingString));
                return moneyInNumbersWorkingString = moneyInNumbersWorkingString.Remove(0, 1);
            }
            else if (moneyInNumbersWorkingString.Length % 3 == 0 && moneyInNumbersWorkingString[0] == '0')
            {
                return moneyInNumbersWorkingString = moneyInNumbersWorkingString.Remove(0, 1);
            }
            else
            {
                return moneyInNumbersWorkingString;
            }
        }

        public String convertTeensDigitToWord(String moneyInNumbersWorkingString)
        {
            if (currentNumberIsATeenIdentifier(moneyInNumbersWorkingString))
            {
                set_convertedNumber(_convertedNumber + tensConverter(moneyInNumbersWorkingString));
                return moneyInNumbersWorkingString = moneyInNumbersWorkingString.Remove(0, 2);
            }
            return moneyInNumbersWorkingString;
        }

        public String convertTensDigitToWord(String moneyInNumbersWorkingString)
        {
            if (moneyInNumbersWorkingString.Length % 3 == 2 && moneyInNumbersWorkingString[0] != '1')
            {
                set_convertedNumber(_convertedNumber + tensConverter(moneyInNumbersWorkingString));
                return moneyInNumbersWorkingString = moneyInNumbersWorkingString.Remove(0, 1);
            }
            return moneyInNumbersWorkingString;
        }

        public String convertOnesDigitToWord(String moneyInNumbersWorkingString)
        {
            if (moneyInNumbersWorkingString.Length % 3 == 1 && moneyInNumbersWorkingString[0] != '0')
            {
                set_convertedNumber(_convertedNumber + onesConverter(moneyInNumbersWorkingString));
                return moneyInNumbersWorkingString = moneyInNumbersWorkingString.Remove(0, 1);
            }
            else if (moneyInNumbersWorkingString.Length % 3 == 1 && moneyInNumbersWorkingString[0] == '0')
            {
                return moneyInNumbersWorkingString = moneyInNumbersWorkingString.Remove(0, 1);
            }
            return moneyInNumbersWorkingString;
        }

        public String numberToWordConverter(String largeNumberName, String moneyInNumbers)
        {
            String moneyInNumbersWorkingString = moneyInNumbers;

            if (!moneyInNumbersWorkingString.StartsWith("000"))
            {
                moneyInNumbersWorkingString = convertHundredsDigitToWord(moneyInNumbersWorkingString);

                moneyInNumbersWorkingString = convertTeensDigitToWord(moneyInNumbersWorkingString);

                moneyInNumbersWorkingString = convertTensDigitToWord(moneyInNumbersWorkingString);

                moneyInNumbersWorkingString = convertOnesDigitToWord(moneyInNumbersWorkingString);

                set_convertedNumber(_convertedNumber + largeNumberName);

                return moneyInNumbersWorkingString;
            }
            else
            {
                return moneyInNumbersWorkingString = moneyInNumbersWorkingString.Remove(0, 3);
            }
        }

        public void moneyIsOneDollarIdentifier(String moneyInNumbers)
        {
            InputValidation validInput = new InputValidation();

            if (validInput.stringToDouble(moneyInNumbers))
            {
                if (Convert.ToDouble(moneyInNumbers) < 2.00)
                {
                    set_currencyType("dollars".TrimEnd('s'));
                }
                else if (Convert.ToDouble(moneyInNumbers) >= 2.00)
                {
                    set_currencyType("dollars");
                }
            }
        }

        public String removeLeadingZeroes(String moneyInNumbers)
        {
            if (moneyInNumbers.StartsWith('0'))
            {
                return moneyInNumbers = removeLeadingZeroes(moneyInNumbers.Trim('0'));
            }
            else
            {
                return moneyInNumbers;
            }
        }

        public bool centsInCorrectFormatValidator(String moneyInNumbers)
        {
            if (moneyInNumbers.Contains('.'))
            {
                if ((moneyInNumbers.Substring(moneyInNumbers.IndexOf('.')).Length > 3))
                    return false;
            }
            return true;
        }

        public bool invalidInputIdentifier(String moneyInNumbers)
        {
            InputValidation validNumber = new InputValidation();

            if (!validNumber.stringToDouble(moneyInNumbers) || moneyInNumbers == null || moneyAsNumbersLengthisTooLongValidator(moneyInNumbers) || moneyInNumbers.Contains('-') || Convert.ToDouble(moneyInNumbers) < 0 || Convert.ToDouble(moneyInNumbers) >= 1000000000.01)
            {
                return true;
            }
            return false;
        }

        public string invalidInputDisplay()
        {
            return "Input you have entered is Invalid Please enter again";
        }

        public bool moneyAsNumbersLengthisTooLongValidator(String moneyInNumbers)
        {
            if (moneyInNumbers.Length > 13)
            {
                return true;
            }
            return false;
        }

        public String removeDollarSignFromtheInputString(String moneyInNumbers)
        {
            if (moneyInNumbers.StartsWith('$'))
            {
                return moneyInNumbers.Remove(0, 1);
            }
            return moneyInNumbers;
        }

        public String removeCommasFromTheInputString(String moneyInNumbers)
        {
            if (moneyInNumbers.Contains(','))
            {
                return moneyInNumbers = moneyInNumbers.Replace(",", "");
            }
            return moneyInNumbers;
        }

        public String addCentsIfInputDoesNotContainCents(String moneyInNumbers)
        {

            if (!moneyInNumbers.Contains('.') && moneyInNumbers.Length <= 10)
            {
                return moneyInNumbers + ".00";
            }

            return moneyInNumbers;
        }

        public String addZerosToCentsAtTheEndOfTheInput(String moneyInNumbers)
        {
            String oldCents = moneyInNumbers.Substring(moneyInNumbers.IndexOf('.'));
            String newCents = oldCents;

            if (newCents.Length < 3)
            {
                while (newCents.Length < 3)
                {
                    newCents = newCents + '0';
                }
                return moneyInNumbers.Replace(oldCents, "") + newCents;
            }
            else if (newCents.Length > 3)
            {
                return "Cents are not in the correct format";
            }
            return moneyInNumbers;
        }

        public bool currentNumberIsATeenIdentifier(String moneyInNumbers)
        {
            if (moneyInNumbers.Length % 3 == 2)
            {
                if (moneyInNumbers[0] == '1')
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool numberContainsCentsIdentifier(String moneyInNumbers)
        {
            if (moneyInNumbers.Length >= 0 && moneyInNumbers.Length <= 3)
            {
                return true;
            }
            return false;
        }

        public bool hundredsPlaceIdentifier(String moneyInNumbers)
        {
            if (moneyInNumbers.Length >= 4 && moneyInNumbers.Length <= 6)
            {
                return true;
            }
            return false;
        }

        public bool thousandsPlaceIdentifier(String moneyInNumbers)
        {
            if (moneyInNumbers.Length >= 7 && moneyInNumbers.Length <= 9)
            {
                return true;
            }
            return false;
        }

        public bool millionsPlaceIdentifier(String moneyInNumbers)
        {
            if (moneyInNumbers.Length >= 10 && moneyInNumbers.Length <= 12)
            {
                return true;
            }
            return false;
        }

        public bool billionsPlaceIdentifier(String moneyInNumbers)
        {
            if (moneyInNumbers.Length >= 13 && moneyInNumbers.Length <= 15)
            {
                return true;
            }
            return false;
        }

        public String onesConverter(String moneyInNumbers)
        {
            char charInMoneyInNumbers;

            charInMoneyInNumbers = moneyInNumbers[0];

            switch (charInMoneyInNumbers)
            {
                case '0':
                    return "zero";
                case '1':
                    return " one";
                case '2':
                    return " two";
                case '3':
                    return " three";
                case '4':
                    return " four";
                case '5':
                    return " five";
                case '6':
                    return " six";
                case '7':
                    return " seven";
                case '8':
                    return " eight";
                case '9':
                    return " nine";
                default:
                    return " error";
            }
        }

        public String tensConverter(String moneyInNumbers)
        {
            char charInMoneyInNumbers;

            charInMoneyInNumbers = moneyInNumbers[0];

            switch (charInMoneyInNumbers)
            {
                case '0':
                    return "";
                case '1':
                    return teensConverter(moneyInNumbers);
                case '2':
                    return " twenty";
                case '3':
                    return " thirty";
                case '4':
                    return " forty";
                case '5':
                    return " fifty";
                case '6':
                    return " sixty";
                case '7':
                    return " seventy";
                case '8':
                    return " eighty";
                case '9':
                    return " ninety";
                default:
                    return " error";
            }
        }

        public String teensConverter(String moneyInNumbers)
        {
            char charInMoneyInNumbers;

            charInMoneyInNumbers = moneyInNumbers[1];

            switch (charInMoneyInNumbers)
            {
                case '0':
                    return " ten";
                case '1':
                    return " eleven";
                case '2':
                    return " twelve";
                case '3':
                    return " thirteen";
                case '4':
                    return " fourteen";
                case '5':
                    return " fifteen";
                case '6':
                    return " sixteen";
                case '7':
                    return " seventeen";
                case '8':
                    return " eighteen";
                case '9':
                    return " nineteen";
                default:
                    return " error";
            }
        }

        public String hundredsConverter(String moneyInNumbers)
        {
            return onesConverter(moneyInNumbers) + " hundred";
        }

        public String billionsConverter(String moneyInNumbers)
        {
            return onesConverter(moneyInNumbers) + " billion";
        }

        public bool exitProgramIdentifier(String moneyInNumbers)
        {
            if (moneyInNumbers.ToUpper().Equals("Exit Program"))
            {
                Environment.Exit(0);
            }
            return false;
        }
    }
}


