using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace Information
{
    
    public static class Messages
    {
        //Gör till const. Static string kan användas om man vill kunna ändra värdet. Const kompileras direkt.
        //Dessutom bör inte memberfields vara public. Då gör man de allmänt som properties
        //public static string OnStartUp => "Welcome to this Imperial units converter!"; Denna har bara en get, så den ändras aldrig;
        //Eller public static string OnStartUp {get;} = "Welcome to this Imperial units converter!"; Denna sätter initialt värde på property.
        //Const kan skrivas i PascalCasing enligt Microsoft, men traditionellt i UPPER_CASE.

        public static string onStartup = "Welcome to this Imperial units converter!";
        public static string onExit = "Thank you for using this software, welcome back!";
        
        public static string formattingExample = "Example input:\n1 ft in y.\n1 feet in yards.";
        
        public static string invalidChoice = "Invalid choice, please retry:";
        public static string invalidInput = "Invalid input, try again.";
        
        public static string lengthConversion = "Please enter what to convert:";
        
        //Needs updating with more conversions as they are implemented.
        public static string userInput = "Please make a selection:\n1: Convert length.";
        
        //Remember to update once more converters are implemented.
        public static string whatConverterToUse = "Unfortunately, length is the only converter so far, so we will use the length-converter.";


    }
}
