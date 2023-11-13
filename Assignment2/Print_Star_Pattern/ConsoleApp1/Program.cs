using System;

/// <summary>
/// This will print the star pattern.
/// </summary>
class PrintStar{

    /// <summary>
    /// The Main method gets the number of rows from the user.
    /// </summary>
    static void Main(){
        int userRows;
        do{
            Console.WriteLine("Enter the number of rows:");
            userRows = int.Parse(Console.ReadLine());
            if(userRows <= 0 || userRows > 10){
                Console.WriteLine("Please enter a value between 0 and 10");
            }      
        }
        while(userRows <= 0 || userRows > 10);
        PrintPattern(userRows);
    }

    /// <summary>
    /// This method will print the stars.
    /// </summary>
    private static void PrintPattern(int userRows){
        for(int rows=1; rows<=userRows; rows++){
            for(int spaces=1; spaces<=(userRows-rows); spaces++){
                Console.Write(" ");
            }
            for(int stars=1; stars<=rows; stars++){
                Console.Write("* ");
            }
            Console.WriteLine("\n");
        }
    }
}