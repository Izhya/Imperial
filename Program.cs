using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Information;
using Conversions;

namespace ImperialUnitsConverter
{
    class Program
    {

        // TODO: Implement more converters and remove 0 to allow choice.
        static string userCaseInput = "0";
        static int userChoiceSwitch;
        static string userCalculation;

        static bool keepRunning = true;
        static bool validInput;

        static void Main(string[] args) 
        {
            Console.WriteLine(Messages.onStartup);
            
            while (keepRunning)
            {    
                Console.WriteLine(Messages.whatConverterToUse);
                validInput = int.TryParse(userCaseInput, out userChoiceSwitch);

                if (validInput)
                {
                    switch (userChoiceSwitch)
                    {
                        case 1:
                            Console.WriteLine(Messages.formattingExample);
                            Console.WriteLine(Messages.lengthConversion);
                            userCalculation = Console.ReadLine();
                            return;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, try again.");
                }
                

            }
           
        }
    }
}
