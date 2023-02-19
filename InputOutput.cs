using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Conversions;

namespace InputOutput
{
    //En klass per fil där filen heter samma som klassen. Man kan ha nästlade klasser alltså.
    //Då döps filen till A i detta fall och för att nå klassen B får man skriva A.B
    //public class A
    //{
    //    public class B
    //    {

    //    }
    //}
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
        public static decimal conversionResult;
        //Denna sträng definieras vid uppstart då den är static. Då saknar alla variabler värden
        //public static string resultOutput = $"{UserConvert.userAmount} {UserConvert.unitOne} equals {conversionResult} {UserConvert.unitTwo}";
        public static string ResultOutput() => $"{UserConvert.userAmount} {UserConvert.unitOne} equals {conversionResult} {UserConvert.unitTwo}";

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
            //in är förkortning av inch, så den kan vi inte ta bort utan får räkna med att de ska bli fyra sträkngar varav tredje är "in"
            string[] lengthseparator = { " ", "," , "in"}; 

            //TODO: Remove later { "thou", "th", "foot", "ft", "yards", "yd", "furlong", "fur" };
            //Varför count? Är det inte bättre att dela hela strängen och sedan kolla om det är rätt antal
            //Nu kommer den sista strängen kanske bli fel för att vi inte splittat mer än tre. Felet är alltså att inmatningen var fel från början.
            strlist = input.Split(lengthseparator, count,
               StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
