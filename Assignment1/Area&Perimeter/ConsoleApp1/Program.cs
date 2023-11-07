using System;

class AreaPerimeter{
    static void Main(){
        Console.WriteLine("Calculate the Area and Perimeter");
        Console.WriteLine(" 1.Square \n 2.Recatngle \n 3.Circle \n 4.Triangle \n");
        Console.WriteLine("Type the name of the shape you want to calculate:");
        string choice = Console.ReadLine().ToLower();

        if(choice == "square"){
            SquareAreaPerimeter();
        }
        else if(choice == "rectangle"){
            RecatngleAreaPerimeter();
        }
        else if(choice == "circle"){
            CircleAreaPerimeter();
        }
        else if(choice == "triangle"){
            TriangleAreaPerimeter();
        }
        else{
            Console.WriteLine("Please enter a valid Shape name.");
        }
    }

    static void SquareAreaPerimeter(){
        Console.WriteLine("Enter the value of the side:");
        int squareSide = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The Perimeter of Square is: {0}", 4*squareSide);
        Console.WriteLine("The Area of Square is: {0}", squareSide*squareSide);
    }

    static void RecatngleAreaPerimeter(){
        Console.WriteLine("Enter the value of length:");
        int length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of breadth:");
        int breadth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The Perimeter of Rectangle is: {0}", 2*(length + breadth));
        Console.WriteLine("The Area of Rectangle is: {0}", length*breadth);
    }
    
    static void CircleAreaPerimeter(){
        const double pi = 3.14;
        Console.WriteLine("Enter the value of the radius:");
        int radius = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The Perimeter of Circle is: {0}", 2*pi*radius);
        Console.WriteLine("The Area of Circle is: {0}", pi*radius*radius);
    }

    static void TriangleAreaPerimeter(){
        Console.WriteLine("Enter the value of the side A (base):");
        int sideA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of the side B (height):");
        int sideB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of the side C:");
        int sideC = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The Perimeter of Square is: {0}", 0.5*sideA*sideB);
        Console.WriteLine("The Area of Square is: {0}", sideA+sideB+sideC);
    }
    
}

