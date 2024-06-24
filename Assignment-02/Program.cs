namespace Assignment_02;

class Program
{
    static void Main(string[] args)
    {
        /* 1- Write a program that takes a number from the user then print yes if
        that number can be divided by 3 and 4 otherwise print no.*/
        
        // #region Problem-1
        //
        // Console.WriteLine("Enter The Number: ");
        // int x1 = int.Parse(Console.ReadLine());
        // if(x1%3==0&&x1%4==0) Console.WriteLine("Yes");
        // else Console.WriteLine("No");
        //
        // #endregion
        
        /* 2- Write a program that allows the user to insert an integer then print
           negative if it is negative number otherwise print positive. */
        
        // #region Problem-2
        //
        // Console.WriteLine("Enter The Number: ");
        // int x2 = int.Parse(Console.ReadLine());
        // if(x2<0) Console.WriteLine("Negative");
        // else Console.WriteLine("Positive");
        //
        // #endregion
        
        /* 3- Write a program that takes 3 integers from the user then prints the max
           element and the min element. */
        
        // #region Problem-3
        //
        // int a, b, c;
        // Console.WriteLine("Enter The 3 Numbers: ");
        // a = int.Parse(Console.ReadLine());
        // b = int.Parse(Console.ReadLine());
        // c = int.Parse(Console.ReadLine());
        // Console.WriteLine("Max: " + Math.Max(a,Math.Max(b,c)));
        // Console.WriteLine("Min: " + Math.Min(a,Math.Min(b,c)));
        //
        // #endregion
        
        /* 4- Write a program that allows the user to insert an integer number then
           check If a number is even or odd. */
        
        // #region Problem-4
        //
        // Console.WriteLine("Enter The Number: ");
        // int x = int.Parse(Console.ReadLine());
        // if(x%2==0) Console.WriteLine("Even");
        // else Console.WriteLine("Odd");
        //
        // #endregion
        
        /* 5- Write a program that takes character from the user then if it is a
           vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant). */
        
        // #region Problem-5
        //
        // Console.WriteLine("Enter The Letter: ");
        // char a = char.ToLower(char.Parse(Console.ReadLine()));
        // if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
        //    Console.WriteLine("Vowel");
        // else Console.WriteLine("Consonant");
        //
        // #endregion
        
        /* 6- Write a program that allows the user to insert an integer then print
           all numbers between 1 to that number. */
        
        // #region Problem-6
        //
        // Console.Write("Enter The Number: ");
        // int x = int.Parse(Console.ReadLine());
        // for (int i = 1; i <= x; i++)
        // {
        //    Console.Write(i+" ");
        // }
        //
        // #endregion
        
        /* 7- Write a program that allows the user to insert an integer then
           print a multiplication table up to 12. */
        
        // #region Problem-7
        //
        // Console.Write("Enter The Number: ");
        // int x = int.Parse(Console.ReadLine());
        // for (int i = 1; i <= 12; i++)
        // {
        //    Console.Write(i*x+" ");
        // }
        //
        // #endregion
        
        /* 8- Write a program that allows to user to insert number then print all
           even numbers between 1 to this number */
        
        // #region Problem-8
        //
        // Console.Write("Enter The Number: ");
        // int x = int.Parse(Console.ReadLine());
        // for (int i = 1; i <= x; i++)
        // {
        //    if(i%2==0) Console.Write(i + " ");
        // }
        //
        // #endregion
        
        // 9- Write a program that takes two integers then prints the power.
        
        // #region Problem-9
        //
        // Console.Write("Enter The 2 Numbers: ");
        // int x = int.Parse(Console.ReadLine());
        // int y = int.Parse(Console.ReadLine());
        // Console.Write("The Power = "+Math.Pow(x,y));
        // #endregion
        
        // 10- Write a program to enter marks of five subjects and calculate total,
        //    average and percentage.
        
        // #region Problem-10
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
        // #endregion
        
        // 12- Write a program to create a Simple Calculator.
        
        // #region Problem-12
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
        // #endregion
        
        // 13- Write a program to allow the user to enter a string and print the
        // REVERSE of it.
        
        // #region Problem-13
        //
        // Console.Write("Enter The String: ");
        // string s = Console.ReadLine();
        // for (int i = s.Length-1; i >= 0; i--)
        // {
        //    Console.Write(s[i]);
        // }
        //
        // #endregion
        
        // 14- Write a program to allow the user to enter int and print the REVERSED
        //    of it.
        
        // #region Problem-14
        //
        // Console.Write("Enter The Number: ");
        // int x = int.Parse(Console.ReadLine());
        // string s = x.ToString();
        // for (int i = s.Length-1; i >= 0; i--)
        // {
        //    Console.Write(s[i]);
        // }
        //
        // #endregion
        
        // 15- Write a program in C# Sharp to find prime numbers within a range of
        // numbers.
        
        // #region Problem-15
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
        // #endregion
        
        // 16- . Write a program in C# Sharp to convert a decimal number into binary
        // without using an array.

        // #region Problem-16
        //
        // Console.Write("Enter a number to convert : ");
        // int x = int.Parse(Console.ReadLine());
        // string binary = Convert.ToString(x, 2);
        // Console.WriteLine(binary);
        //
        // #endregion

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
}