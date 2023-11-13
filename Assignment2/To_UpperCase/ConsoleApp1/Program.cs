using System;

/// <summary>
/// This will convert the text provided to Upper Case.
/// </summary>
class ToUpperCase{

    /// <summary>
    /// This Main method will get the user input and converts to Upper case.
    /// </summary>
    static void Main(){
        Console.WriteLine("***** TO UPPER CASE *****");
        bool end = false;

        while(!end){
            Console.WriteLine("Enter a string:");
            string userInputString = Console.ReadLine();
            string userInputUpperCase = userInputString.ToUpper();
    
            if(userInputUpperCase == "STOP"){
                Console.WriteLine("*** END ***");
                end = true;
            }
            else{
                Console.WriteLine($"Case converted string is {userInputUpperCase}.");
            }
        }
    }
}