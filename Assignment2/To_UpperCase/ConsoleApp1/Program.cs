using System;

/// <summary>
/// This will convert the text provided to Upper Case.
/// </summary>
public class ToUpperCase{

    /// <summary>
    /// This Main method will get the user input and converts to Upper case.
    /// </summary>
    public static void Main(){
        Console.WriteLine("***** TO UPPER CASE *****");
        bool end = false;

        // Until the user types STOP this loop will run and end = false else end = true.
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