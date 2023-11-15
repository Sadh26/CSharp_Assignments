using System;

namespace Consecutive
{   
    /// <summary>
    /// This class will check if the given sequence is consecutive or not.
    /// </summary>
    public class ConsecutiveCheck
    {

        /// <summary>
        /// This is the constructor that will get the user input.
        /// </summary>
        public static void Main()
        {   
            string userInput;

            //Try this block of code. Checks if the user input is valid.
            try
            {
                Console.WriteLine("Enter a string of numbers spaced with - . Example: 5-6-7-8");
                userInput = Console.ReadLine();
                var inputConsecutive = IsConsecutive(userInput);

                if(inputConsecutive)
                {
                    Console.WriteLine("The sequence is consecutive.");
                }
                else
                {
                    Console.WriteLine("The sequence is not consecutive.");
                }
            }
            //Print this in case of exception.
            catch
            {
                Console.WriteLine("Enter a valid input");
            }
            
        }

        /// <summary>
        /// This method will check if the sequence is consecutive and returns true or false.
        /// </summary>
        public static bool IsConsecutive(string userInput)
        {
            var numberString = userInput.Split('-').ToArray(); //splits -
            var numbers = Array.ConvertAll<string, int>(numberString, int.Parse); //converts the string array to type int[]
            int flag=0;
            
            //Correct order else reverse order
            if(numbers[1] > numbers[0]) //(5-6-7-8) => 6 > 5 -> TRUE
            {
                for(int index = 1; index < numbers.Length; index++)
                {
                        if(numbers[index] != numbers[index-1]+1) //numbers[1] != numbers[0] + 1 => 6 != 5+1 -> FALSE
                        {
                            flag = 0;
                            break;
                        }
                        flag = 1;
                }
            }
            else if(numbers[1] < numbers[0]) //(8-7-6-5) => 7 < 8 -> TRUE
            {
                for(int index = 1; index < numbers.Length; index++) 
                {
                    if(numbers[index] != numbers[index-1]-1) //numbers[1] != numbers[0] + 1 => 7 != 8-1 -> FALSE
                    {
                        flag = 0;
                        break;
                    }
                    flag = 1;
                }
            }

            //If flag = 1 it is consecutive.
            if(flag == 1){
                return true;
            }
            else{
                return false;
            }
        }
    }
}
