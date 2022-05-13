using System;
using System.Collections.Generic;
using System.Text;

namespace Magnemi.MoneyToEnglishConverter.CommentedStubs
{
    public class MoneyToEnglish
    {

        public MoneyToEnglish(String moneyInNumbers)
        {
            // Constructor
        }

        public bool moneyAsNumbersLengthValidator(String moneyInNumbers)
        {
            // If that length of the moneyInNumbers is no more than 12 characters return true, if its not return false
        }

        public bool leadingCharacterAsDollarSignValidator(String moneyInNumbers)
        {
            // If the leading character of the passed string contains a dollar sign return true. If no return false
        }

        public String removeDollarSignFromtheInputString(String moneyInNumbers)
        {
            // remove Any dollar signs from the passed String then return that String
        }

        public String removeCommasFromtheInputString(String moneyInNumbers)
        {
            // remove Any Commas from the passed String then return that String
        }

        public String moneyInNumbersCointainsCentsValidator(String moneyInNumbers)
        {
            // Confirm that the last three character of the passed String are in cents format. 
        }

        public String addCentsToTheEndOfTheInput(String moneyInNumbers)
        {
            // Add .00 to the end of the String.
        }

        public bool inputContainsCentsIdentifier(String moneyInNumbers)
        {
            // If the length of the passed string to the method is 2 characters and the leading character is a decimal return true, if its not return false. 
        }

        public bool hundredPlaceIdentifier(String moneyInNumbers)
        {
            // If the length of the passed string to the method is five characters return true, if its not return false. 
        }

        public bool thousandsPlaceIdentifier(String moneyInNumbers)
        {
            // If the length of the passed string to the method is six to eight characters return true, if its not return false. 
        }

        public bool millionsPlaceIdentifier(String moneyInNumbers)
        {
            // If the length of the passed string to the method is nine to eleven characters return true, if its not return false.
        }

        public bool billionsPlaceIdentifier(String moneyInNumbers)
        {
            // If the length of the passed string to the method is ten to twelve characters return true, if its not return false.
        }

        public String convertCentsToWords(String moneyInNumbers)
        {
            // Convert the String passed to this method from numeric cents to their counterparts in words/
        }

        public String onesConverter(String moneyInNumbers)
        {
            // Convert the character to is word counterpart in ones
        }

        public String tensConverter(String moneyInNumbers)
        {
            // Convert the character to is word counterpart in tens
        }

        public String teensConverter(String moneyInNumbers)
        {
            // Convert the character to is word counterpart in teens
        }

        public String hundredsConverter(String moneyInNumbers)
        {
            // Convert the character to is word counterpart in hundreds
        }

        public String millionsConverter(String moneyInNumbers)
        {
            // Convert the character to is word counterpart in millions
        }

        public String billionsConverter(String moneyInNumbers)
        {
            // Convert the character to is word counterpart in billions
        }
    }
}