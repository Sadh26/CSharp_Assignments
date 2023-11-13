using System;

/// <summary>
/// Gets the number, start and stop bits then extracts the bits and provides the decimal value of it.
/// </summary>
class BitsExtraction{

    /// <summary>
    /// This Main method gets the inputs from the user.
    /// </summary>
    static void Main(){
        Console.WriteLine("Enter the input number:");
        var userInput = int.Parse(Console.ReadLine());
        string userInputBinary = Convert.ToString(userInput,2);
        //Gets a valid starting bit
        int startBit;
        do{
            Console.WriteLine("Enter the Start bit:");
            startBit = int.Parse(Console.ReadLine());

            if(startBit<0){
                Console.WriteLine($"Your Start bit is less than 0. Please enter a value from 0 to {userInputBinary.Length-1}");
            }
            else if(startBit > userInputBinary.Length){
                Console.WriteLine($"Your Start bit is too large. Please enter a value less than {userInputBinary.Length} & greater/equal to 0");
            }
        }
        while(startBit<0 || startBit > userInputBinary.Length);
        //Gets a valid stop bit
        int stopBit;
        do{
            Console.WriteLine("Enter the Stop bit:");
            stopBit = int.Parse(Console.ReadLine());

            if(stopBit<=startBit){
                Console.WriteLine("Your Stop bit is less than or equal to Start bit. Please enter a greater number");
            }
            else if(stopBit > userInputBinary.Length){
                Console.WriteLine($"Your Stop bit is too large. Please enter a value less than {userInputBinary.Length}.");
            }
        }
        while(stopBit<=startBit || stopBit > userInputBinary.Length);
        ExtractBits(userInputBinary, startBit, stopBit);
    }

    /// <summary>
    /// Gets the input and does the extraction of bits operation.
    /// </summary>
    private static void ExtractBits(string userInput, int startBit, int stopBit){
        string extractedBinaryString = "";
        int lastIndex = userInput.Length - 1;
        for(int i = lastIndex - stopBit; i <= lastIndex - startBit; i++){
            extractedBinaryString += userInput[i];
        }
        Console.WriteLine("***** The Extrated Bits and its Decimal value *****");
        Console.WriteLine($"Binary Field Value = {extractedBinaryString}");
        Console.WriteLine($"Decimal Field Value = {Convert.ToInt32(extractedBinaryString, 2).ToString()}");
    }
}