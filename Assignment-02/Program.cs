namespace MyProjectRoute;

class Program
{
    static void Main(string[] args)
    {
        // 1- Write a program that allows the user to enter a number then print it.
        Console.WriteLine("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("The number you entered: "+num);
        
        
        /* 2- Write C# program that Assigning one value type variable to another
        and modifying the value of one variable and mention what will happen */
        #region Value Type
        
        int X = 10;
        int Y = X;
        Console.WriteLine("The value of X: "+X);
        Console.WriteLine("The value of Y: "+Y);
        Y = 99;
        X++;
        Console.WriteLine("The value of X: "+X);
        Console.WriteLine("The value of Y: "+Y);
        /*
        What will happen ? 
        We allocated X in the stack, and it's value is 10
        then We allocated X in the stack, and it's value is equal to X (10)
        Changing the value of X will not affect on Y and the opposite because 
        we changed the value not the address
        */
        #endregion
        
        
        /* 3- Write C# program that Assigning one reference type variable to another
        and modifying the object through one variable and mention what will happen */
        #region Reference Type

        Point P1;
        P1 = new Point();
        Point P2 = P1;
        
        Console.WriteLine("The value of P1.X: "+P1.X);
        Console.WriteLine("The value of P2.X: "+P1.Y);
        Console.WriteLine("The value of P1.Y: "+P2.X);
        Console.WriteLine("The value of P2.y: "+P2.Y);
        
        P2.X = 5;
        P1.Y = 10;
        
        Console.WriteLine("The value of P1.X: "+P1.X);
        Console.WriteLine("The value of P2.X: "+P1.Y);
        Console.WriteLine("The value of P1.Y: "+P2.X);
        Console.WriteLine("The value of P2.y: "+P2.Y);
        
        /*
        What will happen ? 
        First we created an object called P1 now 4 bytes allocated in stack
        after that line "P1 = new Point();" now 8 bytes allocated in heap "X and Y" , then we created P2 that
        equal P1 , so it will point to P1 , Then any change will happen in P1 it will affect P2 and the opposite
        that changes happened because P2 points on the reference of P1
        */
        #endregion
        
    }
}