using System;

/// <summary>
/// This will print the star pattern.
/// </summary>
public class PrintStar{

    /// <summary>
    /// The Main method gets the number of rows from the user.
    /// </summary>
    public static void Main(){
        int userRows;
        bool isUserRowsValid;
        
        //This will check if the user input rows are NUMERIC and from 0 to 10. If not will ask the user to enter a valid input.
        do{
            Console.WriteLine("Enter the number of rows:");
            isUserRowsValid = int.TryParse(Console.ReadLine(), out userRows);

            if(!isUserRowsValid){
                Console.WriteLine("Please enter a numeric value");
            } 
            else if(userRows < 0 || userRows > 10){
                Console.WriteLine("Please enter a value from 0 to 10");
            }     
        }
        while(!isUserRowsValid || userRows < 0 || userRows > 10);
        PrintPattern(userRows);
    }

    /// <summary>
    /// This method will print the star pattern.
    /// </summary>
    private static void PrintPattern(int userRow){
        //Loop for rows
        for(int rows=1; rows<=userRow; rows++){
            //Loop for spaces
            for(int spaces=1; spaces<=(userRow-rows); spaces++){
                Console.Write(" ");
            }
            //Loop for stars
            for(int stars=1; stars<=rows; stars++){
                Console.Write("* ");
            }
            Console.WriteLine("\n");
        }
    }
}