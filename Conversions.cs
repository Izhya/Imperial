using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Information;
using InputOutput;

namespace Conversions
{
    public static class UserConvert
    {
        public static int
                    unitThou = 1,
                    unitInch = unitThou / 1000,
                    unitFeet = unitInch / 15,
                    unitYard = unitFeet / 3,
                    unitFurlong = unitYard / 220;
        static double userConvertedToThou, calcConverted;
        public static int userAmount;
        public static string unitOne, unitTwo;

        public static double conversionResult;
        

        public static void ConvertLength(string input) 
        {
            InputSeparation.stringSeparationForLength(input);
            unitOne = InputSeparation.strlist[1];
            unitTwo = InputSeparation.strlist[2];

            if (int.TryParse(InputSeparation.strlist[0], out userAmount))
            {
                switch (unitOne)
                {
                    case "thou":
                        userConvertedToThou = userAmount * unitThou;
                        break;

                    case "th":
                        userConvertedToThou = userAmount * unitThou;
                        break;

                    case "inch":
                        userConvertedToThou = userAmount * unitInch;
                        break;

                    case "in":
                        userConvertedToThou = userAmount * unitInch;
                        break;

                    case "feet":
                        userConvertedToThou = userAmount * unitFeet;
                        break;

                    case "ft":
                        userConvertedToThou = userAmount * unitFeet;
                        break;

                    case "yard":
                        userConvertedToThou = userAmount * unitYard;
                        break;

                    case "yd":
                        userConvertedToThou = userAmount * unitYard;
                        break;

                    case "furlong":
                        userConvertedToThou = userAmount * unitFurlong;
                        break;

                    case "fur":
                        userConvertedToThou = userAmount * unitFurlong;
                        break;
                }

                switch (unitTwo)
                {
                    case "thou":
                        calcConverted = unitThou;
                        break;

                    case "th":
                        calcConverted = unitThou;
                        break;

                    case "inch":
                        calcConverted = unitInch;
                        break;

                    case "in":
                        calcConverted = unitInch;
                        break;

                    case "feet":
                        calcConverted = unitFeet;
                        break;

                    case "ft":
                        calcConverted = unitFeet;
                        break;

                    case "yards":
                        calcConverted = unitYard;
                        break;

                    case "yd":
                        calcConverted = unitYard;
                        break;

                    case "furlong":
                        calcConverted = unitFurlong;
                        break;

                    case "fur":
                        calcConverted = unitFurlong;
                        break;
                }

                OutputVariable.conversionResult = userConvertedToThou / calcConverted;

            }

            else 
            {
                Console.WriteLine(Messages.invalidInput);
            }
        }
    }

}
