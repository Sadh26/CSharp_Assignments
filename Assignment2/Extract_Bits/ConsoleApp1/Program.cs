using System;

/// <summary>
/// Extracts the bits and provides the decimal value of it.
/// </summary>
class BitsExtraction{
    static void Main(){
        Console.WriteLine("Enter the input number:");
        var userInput = int.Parse(Console.ReadLine());
        string userInputBinary = Convert.ToString(userInput,2);
        Console.WriteLine("Enter the Start bit:");
        var startBit = int.Parse(Console.ReadLine());
        int stopBit;
        do{
            Console.WriteLine("Enter the Stop bit:");
            stopBit = int.Parse(Console.ReadLine());

            if(stopBit<=startBit){
                Console.WriteLine("Your Stop bit is less than or equal to Start bit. Please enter a greater number");
            }
        }
        while(stopBit<=startBit);
        ExtractBits(userInputBinary, startBit, stopBit);
    }

    /// <summary>
    /// Gets the input from the users and extracts the bits.
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