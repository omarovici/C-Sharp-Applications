namespace Assignment_02;

class Program
{
    static void Main(string[] args)
    {
        /* 1- Write a program that takes a number from the user then print yes if
        that number can be divided by 3 and 4 otherwise print no.*/
        
        #region Problem-1
        //
        // Console.WriteLine("Enter The Number: ");
        // int x1 = int.Parse(Console.ReadLine());
        // if(x1%3==0&&x1%4==0) Console.WriteLine("Yes");
        // else Console.WriteLine("No");
        //
        #endregion
        
        /* 2- Write a program that allows the user to insert an integer then print
           negative if it is negative number otherwise print positive. */
        
        #region Problem-2
        //
        // Console.WriteLine("Enter The Number: ");
        // int x2 = int.Parse(Console.ReadLine());
        // if(x2<0) Console.WriteLine("Negative");
        // else Console.WriteLine("Positive");
        //
        #endregion
        
        /* 3- Write a program that takes 3 integers from the user then prints the max
           element and the min element. */
        
        #region Problem-3
        //
        // int a, b, c;
        // Console.WriteLine("Enter The 3 Numbers: ");
        // a = int.Parse(Console.ReadLine());
        // b = int.Parse(Console.ReadLine());
        // c = int.Parse(Console.ReadLine());
        // Console.WriteLine("Max: " + Math.Max(a,Math.Max(b,c)));
        // Console.WriteLine("Min: " + Math.Min(a,Math.Min(b,c)));
        //
        #endregion
        
        /* 4- Write a program that allows the user to insert an integer number then
           check If a number is even or odd. */
        
        #region Problem-4
        //
        // Console.WriteLine("Enter The Number: ");
        // int x = int.Parse(Console.ReadLine());
        // if(x%2==0) Console.WriteLine("Even");
        // else Console.WriteLine("Odd");
        //
        #endregion
        
        /* 5- Write a program that takes character from the user then if it is a
           vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant). */
        
        #region Problem-5
        //
        // Console.WriteLine("Enter The Letter: ");
        // char a = char.ToLower(char.Parse(Console.ReadLine()));
        // if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
        //    Console.WriteLine("Vowel");
        // else Console.WriteLine("Consonant");
        //
        #endregion
        
        /* 6- Write a program that allows the user to insert an integer then print
           all numbers between 1 to that number. */
        
        #region Problem-6
        //
        // Console.Write("Enter The Number: ");
        // int x = int.Parse(Console.ReadLine());
        // for (int i = 1; i <= x; i++)
        // {
        //    Console.Write(i+" ");
        // }
        //
        #endregion
        
        /* 7- Write a program that allows the user to insert an integer then
           print a multiplication table up to 12. */
        
        #region Problem-7
        //
        // Console.Write("Enter The Number: ");
        // int x = int.Parse(Console.ReadLine());
        // for (int i = 1; i <= 12; i++)
        // {
        //    Console.Write(i*x+" ");
        // }
        //
        #endregion
        
        /* 8- Write a program that allows to user to insert number then print all
           even numbers between 1 to this number */
        
        #region Problem-8
        //
        // Console.Write("Enter The Number: ");
        // int x = int.Parse(Console.ReadLine());
        // for (int i = 1; i <= x; i++)
        // {
        //    if(i%2==0) Console.Write(i + " ");
        // }
        //
        #endregion
        
        // 9- Write a program that takes two integers then prints the power.
        
        #region Problem-9
        //
        // Console.Write("Enter The 2 Numbers: ");
        // int x = int.Parse(Console.ReadLine());
        // int y = int.Parse(Console.ReadLine());
        // Console.Write("The Power = "+Math.Pow(x,y));
        #endregion
        
        // 10- Write a program to enter marks of five subjects and calculate total,
        //    average and percentage.
        
        #region Problem-10
        //
        // Console.Write("Enter The Marks: ");
        // int x , sum = 0;
        // for (int i = 0; i < 5; i++)
        // {
        //    x = int.Parse(Console.ReadLine());
        //    sum += x;
        // }
        // Console.WriteLine("Total Marks = "+sum);
        // int avg = sum/5;
        // Console.WriteLine("Average Marks = "+avg);
        // double per = ((double)sum / 500) * 100;
        // Console.WriteLine("Percentage = "+(int)per);
        //
        #endregion
        
        // 11- Write a program to input the month number and print the number of days
        //    in that month.

        #region Problem-11
        //
        // Console.Write("Enter The Number: ");
        // int x = int.Parse(Console.ReadLine());
        // int day = DateTime.DaysInMonth(DateTime.Now.Year, x);
        // Console.WriteLine(day);
        //
        #endregion

        // 12- Write a program to create a Simple Calculator.
        
        #region Problem-12
        //
        // Console.Write("Enter The 2 Numbers: ");
        // int x = int.Parse(Console.ReadLine());
        // int y = int.Parse(Console.ReadLine());
        // Console.Write("Choose the arithmetic operation (+) (-) (*) (/) : ");
        // char c = char.Parse(Console.ReadLine());
        // switch (c)
        // {
        //    case '+':
        //       Console.WriteLine("Addition = "+(x+y));
        //       break;
        //    case '-':
        //       Console.WriteLine("Subtraction = "+(x-y));
        //       break;
        //    case '*':
        //       Console.WriteLine("Multiplication = "+(x*y));
        //       break;
        //    case '/':
        //       Console.WriteLine("Division = "+(x/y));
        //       break;
        //    default:
        //       Console.WriteLine("Wrong Symbol");
        //       break;
        // }
        #endregion
        
        // 13- Write a program to allow the user to enter a string and print the
        // REVERSE of it.
        
        #region Problem-13
        //
        // Console.Write("Enter The String: ");
        // string s = Console.ReadLine();
        // for (int i = s.Length-1; i >= 0; i--)
        // {
        //    Console.Write(s[i]);
        // }
        //
        #endregion
        
        // 14- Write a program to allow the user to enter int and print the REVERSED
        //    of it.
        
        #region Problem-14
        //
        // Console.Write("Enter The Number: ");
        // int x = int.Parse(Console.ReadLine());
        // string s = x.ToString();
        // for (int i = s.Length-1; i >= 0; i--)
        // {
        //    Console.Write(s[i]);
        // }
        //
        #endregion
        
        // 15- Write a program in C# Sharp to find prime numbers within a range of
        // numbers.
        
        #region Problem-15
        //
        // Console.Write("Input starting number of range: ");
        // int x = int.Parse(Console.ReadLine());
        // Console.Write("Input ending number of range : ");
        // int y = int.Parse(Console.ReadLine());
        // for (int i = x; i < y; i++)
        // {
        //    if (isPrime(i)) Console.Write(i + " ");
        // }
        //
        #endregion
        
        // 16- . Write a program in C# Sharp to convert a decimal number into binary
        // without using an array.

        #region Problem-16
        //
        // Console.Write("Enter a number to convert : ");
        // int x = int.Parse(Console.ReadLine());
        // string binary = Convert.ToString(x, 2);
        // Console.WriteLine(binary);
        //
        #endregion
        
        // 17- Create a program that asks the user to input three points (x1, y1),
        // (x2, y2), and (x3, y3), and determines whether these points lie on a
        // single straight line.

        #region Problem-17
        //
        // Point a = new Point();
        // Point b = new Point();
        // Point c = new Point();
        // Console.Write("Enter X1 & Y1 : ");
        // a.X = int.Parse(Console.ReadLine());
        // a.Y = int.Parse(Console.ReadLine());
        //
        // Console.Write("Enter X2 & Y2 : ");
        // b.X = int.Parse(Console.ReadLine());
        // b.Y = int.Parse(Console.ReadLine());
        //
        // Console.Write("Enter X3 & Y3 : ");
        // c.X = int.Parse(Console.ReadLine());
        // c.Y = int.Parse(Console.ReadLine());
        //
        // if((c.Y-b.Y)*(b.X-a.X)==(b.Y-a.Y)*(c.X-b.X)) Console.WriteLine("All 3 points lie on the same line");
        // else Console.WriteLine("All 3 points do not lie on the same line");
        //
        #endregion
        
        // 18- Within a company, the efficiency of workers is evaluated based on the
        // duration required to complete a specific task. A worker's efficiency level
        //    is determined as follows:
        // - If the worker completes the job within 2 to 3 hours, they are considered
        //    highly efficient.
        // - If the worker takes 3 to 4 hours, they are instructed to increase their
        // speed.
        // - If the worker takes 4 to 5 hours, they are provided with training to
        // enhance their speed.
        // - If the worker takes more than 5 hours, they are required to leave the
        // company.
        //    To calculate the efficiency of a worker, the time taken for the task is
        //    obtained via user input from the keyboard.

        #region Problem-18
        //
        // Console.Write("Enter the time taken to complete the task : ");
        // double t = double.Parse(Console.ReadLine());
        //
        // if (t >= 2 && t <= 3)  Console.WriteLine("Highly efficient");
        // else if (t > 3 && t <= 4) Console.WriteLine("Increase your speed");
        // else if (t > 4 && t <= 5) Console.WriteLine("Training to enhance your speed");
        // else if (t > 5) Console.WriteLine("Leave the company");
        // else Console.WriteLine("Invalid input");
        //
        #endregion


    }

    static bool isPrime(int x)
    {
       if (x <= 1)
          return false;
       for (int i = 2; i <= x/2; i++)
       {
          if (x % i == 0)
             return false;
       }
       return true;
    }
    
    public class Point
    {
       public int X;
       public int Y;
    }
}