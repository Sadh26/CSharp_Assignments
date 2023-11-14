using System;

/// <summary>
/// Gets the number, start and stop bits then extracts the bits and provides the decimal value of it.
/// </summary>
public class BitsExtraction{

    /// <summary>
    /// This Main method gets the inputs from the user.
    /// </summary>
    public static void Main(){
        int validUserInput;
        bool isUserInputValid;
        string userInputBinary;
        int startBit;
        int stopBit;
        bool isStartBitValid;
        bool isStopBitValid;

        //Gets a valid number for extraction of bits.
        do{
            Console.WriteLine("Enter the input number:");
            isUserInputValid = int.TryParse(Console.ReadLine(), out validUserInput);
            if(!isUserInputValid){
                Console.WriteLine("Please enter a valid numeric value.");
            }
            userInputBinary = Convert.ToString(validUserInput,2);
        }
        while(!isUserInputValid);

        //Gets a valid starting bit
        do{
            Console.WriteLine("Enter the Start bit:");
            isStartBitValid = int.TryParse(Console.ReadLine(), out startBit);
            if(!isStartBitValid){
                Console.WriteLine("Please enter a numeric value.");
            }
            else if(startBit<0){
                Console.WriteLine($"Your Start bit is less than 0. Please enter a value from 0 to {userInputBinary.Length-1}");
            }
            else if(startBit > userInputBinary.Length){
                Console.WriteLine($"Your Start bit is too large. Please enter a value less than {userInputBinary.Length} & greater/equal to 0");
            }
        }
        while(!isStartBitValid || startBit<0 || startBit > userInputBinary.Length);

        //Gets a valid stop bit
        do{
            Console.WriteLine("Enter the Stop bit:");
            isStopBitValid = int.TryParse(Console.ReadLine(), out stopBit);
            if(!isStopBitValid){
                Console.WriteLine("Please enter a numeric value.");
            }
            else if(stopBit<=startBit){
                Console.WriteLine("Your Stop bit is less than or equal to Start bit. Please enter a greater number");
            }
            else if(stopBit > userInputBinary.Length){
                Console.WriteLine($"Your Stop bit is too large. Please enter a value less than {userInputBinary.Length}.");
            }
        }
        while(!isStopBitValid || stopBit<=startBit || stopBit > userInputBinary.Length);
        
        var extractBits = ExtractBits(userInputBinary, startBit, stopBit);
        Console.WriteLine("***** The Extrated Bits and its Decimal value *****");
        Console.WriteLine($"Binary Field Value = {extractBits.Item1}");
        Console.WriteLine($"Decimal Field Value = {extractBits.Item2}");
    }

    /// <summary>
    /// Gets the input and does the extraction of bits operation.
    /// </summary>
    private static (string, string) ExtractBits(string userInput, int startBit, int stopBit){
        string extractedBinaryString = "";
        int lastIndex = userInput.Length - 1;

        //This will add the bits from start bit to stop bit to the extractedBinaryString variable.
        for(int i = lastIndex - stopBit; i <= lastIndex - startBit; i++){
            extractedBinaryString += userInput[i];
        }
        string decimalValue = Convert.ToInt32(extractedBinaryString, 2).ToString();
        //Tuple is used for returning two values from this method.
        return(extractedBinaryString, decimalValue);
    }
}