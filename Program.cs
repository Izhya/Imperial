using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Information;
using Conversions;
using InputOutput;

namespace ImperialUnitsConverter
{
    class Program
    {
        static void Main(string[] args) 
        {
            bool keepRunning;

            Console.WriteLine(Messages.onStartup);
            keepRunning = true;
            
            while (keepRunning)
            {    
                Console.WriteLine(Messages.whatConverterToUse);
                Console.WriteLine(Messages.userInput);
                InputVariable.userConverterChoice = Console.ReadLine().ToLower();
                InputValidation.ValidateConverterChoice(InputVariable.userConverterChoice);

                if (InputVariable.validInput)
                {
                    switch (InputVariable.userSwitchState)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine(Messages.formattingExample);
                            Console.WriteLine(Messages.lengthConversion);
                            InputVariable.userCalculation = Console.ReadLine();
                            UserConvert.ConvertLength(InputVariable.userCalculation);
                            Console.WriteLine();
                            Console.WriteLine($"Result:{OutputVariable.resultOutput}");
                            Console.ReadKey();
                            break;

                        default:

                            Console.Clear();
                            Console.WriteLine("\n" + Messages.invalidChoice + "\n");
                            break;
                    }
                }
                else if (InputVariable.userConverterChoice == "q")
                {
                    keepRunning = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n" + Messages.invalidInput + "\n");
                }

            }

            Console.WriteLine(Messages.onExit);
            Console.ReadKey();
        }
    }
}
