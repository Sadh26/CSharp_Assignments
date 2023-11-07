using System;

class FindComplement{
    static void Main(){
        Console.WriteLine("******ONE'S AND TWO'S COMPLEMENT******");
        Console.WriteLine("Enter a number:");
        int userIp = Convert.ToInt32(Console.ReadLine()); //Converts the user input to integer
        string userIpBinary = Convert.ToString(userIp, 2); //Converts to binary string
        //Calculation of 1's and 2's compliment
        int onesComp = ~ userIp;
        int twosComp =  onesComp + 1;
        //Conversion of 1's and 2's compliment to Binary
        string onesCompBinary = Convert.ToString(onesComp, 2);
        string twosCompBinary = Convert.ToString(twosComp, 2);

        Console.WriteLine("The binary is: {0}", userIpBinary);
        Console.WriteLine("******1's COMPLIMENT******");
        Console.WriteLine("The one's Compliment in decimal is: {0}", onesComp);
        Console.WriteLine("The one's Compliment in binary is: {0}", onesCompBinary);
        Console.WriteLine('\n');
        Console.WriteLine("******2's COMPLIMENT******");
        Console.WriteLine("The two's Compliment in decimal is: {0}", twosComp);
        Console.WriteLine("The two's Compliment in binary is: {0}", twosCompBinary);
    }
}

