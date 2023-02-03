using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Conversions;

namespace InputOutput
{
    public static class InputVariable
    {
        // TODO: Implement more converters and remove 0 to allow choice.
        public static string userCalculation;
        public static string userConverterChoice;

        public static int userSwitchState;
        
        public static bool validInput;
    }

    public static class OutputVariable
    {
        public static double conversionResult;
        public static string resultOutput = $"{UserConvert.userAmount} {UserConvert.unitOne} equals {conversionResult} {UserConvert.unitTwo}";

    }

    public static class InputValidation
    {
        public static void ValidateConverterChoice(string input)
        {
            InputVariable.validInput = int.TryParse(input, out InputVariable.userSwitchState);
        }
    }

    public static class InputSeparation
    {
        public static String[] strlist;

        public static void stringSeparationForLength(string input)
        {
            int count = 3;
            string[] lengthseparator = { "", " ", "," , "in"};

            //TODO: Remove later { "thou", "th", "foot", "ft", "yards", "yd", "furlong", "fur" };

            strlist = input.Split(lengthseparator, count,
               StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
