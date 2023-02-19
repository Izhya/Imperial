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
        public static decimal
                    unitThou = 1,
                    unitInch = unitThou / 1000,
                    unitFeet = unitInch / 15,
                    unitYard = unitFeet / 3,
                    unitFurlong = unitYard / 220;
        //double har dålig presicion. Använd decimal istället Roten ur 2 upphöjt till 2 blir inte 2 med double, men det blir det med decimal.
        //Ange oxå alltid Modifier även när det inte krävs. Tydligare att läsa. Alltså ner bör private läggas till först.
        static decimal userConvertedToThou, calcConverted;
        public static decimal userAmount;
        public static string unitOne, unitTwo;        

        public static void ConvertLength(string input) 
        {
            InputSeparation.stringSeparationForLength(input);
            unitOne = InputSeparation.strlist[1];
            unitTwo = InputSeparation.strlist[2];

            if (decimal.TryParse(InputSeparation.strlist[0], out userAmount))
            {
                //Saknar kontroll på korrekt enhet. Man kan göra en klass för en enhet, t.ex. med Name, Abbreviation och UnitInThou.
                //Sedan kan man leta i listan för att se att man hittar enheten. Om den inte hittas kan man kasta ett fel.
                //Dessutom blir du av med dessa switch-satser.

                //Nåt är fel i konverteringen då 3 ft blir 9 yd.
                switch (unitOne)
                {
                    //Du kan slå ihop flera case som ger samma resultat genom att bara ha dem efter varandra.
                    //Tog bort beräkning för "thou" nedan för att visa hur
                    case "thou":
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
                        userConvertedToThou = userAmount = unitYard;
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
