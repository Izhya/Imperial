using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Information
{
    
    public static class Messages
    {    
        
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
