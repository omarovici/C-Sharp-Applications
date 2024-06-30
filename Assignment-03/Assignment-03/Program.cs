namespace Assignment_03;

class Program
{
    static void Main(string[] args)
    {
        // 1- . Write a program that prints an identity matrix using for 
        //     loop, in other words, takes a value n from the user and shows the 
        // identity table of size n * n.
        #region Problem 1

        // Console.WriteLine("Enter the size of identity matrix: ");
        // int n = int.Parse(Console.ReadLine());
        // for (int i = 0; i < n; i++)
        // {
        //     for (int j = 0; j < n; j++)
        //     {
        //         if (i == j)
        //         {
        //             Console.Write("1 ");
        //         }
        //         else
        //         {
        //             Console.Write("0 ");
        //         }
        //     }
        //     Console.WriteLine();
        // }
        
        #endregion
        
        // 2- Write a program in C# Sharp to find the sum of all elements 
        // of the array.
        #region Problem 2

        // int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // Console.WriteLine("The Sum = "+arr.Sum());
        
        #endregion
        
        // 3- Write a program in C# Sharp to merge two arrays of the same 
        // size sorted in ascending order.
        #region Problem 3
        
        // int[] arr1 = { 5, 3, 9 };
        // int[] arr2 = { 2, 1, 6 };
        // int[] merge = arr1.Union(arr2).ToArray();
        // Array.Sort(merge);
        // foreach (var i in merge)
        // {
        //     Console.Write(i+" ");
        // }
        
        #endregion
        
        // 4- Write a program in C# Sharp to count the frequency of each 
        //     element of an array. 
        #region Problem 4

        // int[] arr = { 1, 9, 8, 5, 6, 2, 4, 6, 8, 2, 1, 5, 7, 9, 9, 8, 7, 2, 2, 2, 6, 9, 3, 6, 0, 1, 2, 3 ,70,101};
        // int[] dub = new int[arr.Length];
        //
        // for (int i = 0; i < arr.Length; i++)
        // {
        //     if (dub[i] == 0)
        //     {
        //         int cnt = 1;
        //         for (int j = i + 1; j < arr.Length; j++)
        //         {
        //             if (arr[i] == arr[j])
        //             {
        //                 cnt++;
        //                 dub[j] = -1;
        //             }
        //         }
        //         dub[i] = cnt;
        //     }
        // }
        //
        // for (int i = 0; i < arr.Length; i++)
        // {
        //     if (dub[i] != -1)
        //     {
        //         Console.Write("The number {0} appears {1} times\n",arr[i],dub[i]);
        //     }
        // }
        
        #endregion
        
        // 5- Write a program in C# Sharp to find a maximum and minimum 
        // element in an array
        #region Problem 5

        // int[] arr = { 1, 7, 4, 2, 99, -8 };
        // int max = arr.Max();
        // int min = arr.Min();
        // Console.WriteLine("The maximum element = {0}\nThe minimum element = {1}",max,min);

        #endregion
        
        // 7- Write a program in C# Sharp to find the second largest element 
        //     in an array.
        #region Problem 7

        // int[] arr = {9,8,7};
        // Array.Sort(arr);
        // Array.Reverse(arr);
        // if(arr.Length==0) Console.WriteLine("The array is empty");
        // else if (arr.Length==1) Console.WriteLine(arr[0]);
        // else Console.WriteLine(arr[1]);

        #endregion

        // 8-. Consider an Array of Integer values with size N, having 
        // values as in 
        // this Example
        // 7 0 0 0 5 6 7 5 0 7 5 3
        // write a program to find the longest distance between Two equal 
        // cells. In this example. The distance is measured by the number Of 
        // cells - for example, the distance between the first and the fourth 
        // cell is 2 (cell 2 and cell 3).
        // In the example above, the longest distance is between the first 7 
        // and the
        // 10th 7, with a distance of 8 cells, i.e., the number of cells 
        // between the 1st 
        //     And the 10th 7s.
        //     Note:
        // - Array values will be taken from the user
        //     - If you have input like 1111111 then the distance is the number 
        // of cells between the first and the last cell.
        #region Problem 8
        
        // Console.WriteLine("Enter the n value:");
        // int n = int.Parse(Console.ReadLine());
        // int[] arr = new int[n];
        // for (int i = 0; i < n; i++)
        // {
        //     Console.Write($"Enter value for element [{i}]: ");
        //     arr[i] = int.Parse(Console.ReadLine());
        // }
        //
        // int max = 0;
        //
        // for (int i = 0; i < arr.Length; i++)
        // {
        //     for (int j = i + 1; j < arr.Length; j++)
        //     {
        //         if (arr[i] == arr[j])
        //         {
        //             int dist = j - i;
        //             if (dist > max)
        //             {
        //                 max = dist;
        //             }
        //         }
        //     }
        // }
        //
        // Console.WriteLine($"The longest distance between two cells is: {--max}");

        #endregion
        
        // 9- Given a list of space separated words, reverse the order of 
        //     the words.
        // Input: this is a test Output: test an is this
        // Input: all your base Output: base you're all
        // Input: Word Output: Word
        // Note: 
        // - Check the Split Function (Member in String Class) Output will 
        // be a Single Console.WriteLine Statement
        #region Problem 9

        // Console.WriteLine("Enter the sentence that you want to reverse it: ");
        // string s = Console.ReadLine();
        // string[] spilt = s.Split(' ');
        // Array.Reverse(spilt);
        // Console.WriteLine(string.Join(" ",spilt));

        #endregion
        
        // 10- Write a program to create two multidimensional arrays of the 
        //     same size. Accept value from the user and store them in the first 
        // array. Now copy all the elements of the first array onto the 
        //     second array and print the second array.
        #region Problem 10

        // Console.WriteLine("Enter the row: ");
        // int r = int.Parse(Console.ReadLine());
        // Console.WriteLine("Enter the coloumn: ");
        // int c = int.Parse(Console.ReadLine());
        //
        // int[,] arr1 = new int[r, c];
        // int[,] arr2 = new int[r, c];
        //
        // Console.WriteLine("Input elements in the matrix :");
        //
        // for (int i = 0; i < r; i++)
        // {
        //     for (int j = 0; j < c; j++)
        //     {
        //         Console.Write($"Element [{i},{j}]: ");
        //         arr1[i, j] = int.Parse(Console.ReadLine());
        //     }
        // }
        //
        // for (int i = 0; i < r; i++)
        // {
        //     for (int j = 0; j < c; j++)
        //     {
        //         arr2[i, j] = arr1[i, j];
        //     }
        // }
        //
        // Console.WriteLine("Elements in the second matrix are:");
        // for (int i = 0; i < r; i++)
        // {
        //     for (int j = 0; j < c; j++)
        //     {
        //         Console.Write(arr2[i, j] + " ");
        //     }
        //     Console.WriteLine();
        // }
        
        #endregion
        
        // 11- Write a Program to Print One Dimensional Array in Reverse Order
        #region Problem 11

        // int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // Array.Reverse(arr);
        // Console.WriteLine("The reversed array of One Dimensional Array:");
        // foreach (var i in arr)
        // {
        //     Console.Write(i+" ");
        // }

        #endregion
        
        // ------------------------- GENERAL -------------------------
        // 1-Write a program that calculates the simple interest given the 
        // principal amount, rate of interest, and time. The formula for 
        // simple interest is Interest = (principal * rate * time ) /100
        #region General Problem 1

        // Console.WriteLine("Enter the principal amount: ");
        // double principal = double.Parse(Console.ReadLine());
        //
        // Console.WriteLine("Enter the interest: ");
        // double rate = double.Parse(Console.ReadLine());
        //
        // Console.WriteLine("Enter the time: ");
        // int time = int.Parse(Console.ReadLine());
        //
        // Console.WriteLine("The simple interest is: "+CalculateSimpleInterest(principal, rate, time));

        #endregion
        
        // 2- Write a program 
        // that calculates the Body Mass Index (BMI) given a person's 
        // weight in kilograms and height in meters. The formula for BMI 
        // is BMI = (Weight)/(Height*Height)
        #region General Problem 2

        // Console.WriteLine("Enter your weight in kilograms: ");
        // double weight = double.Parse(Console.ReadLine());
        //
        // Console.WriteLine("Enter your height in meters: ");
        // double height = double.Parse(Console.ReadLine());
        //
        // Console.WriteLine("BMI = "+CalculateBMI(weight,height));

        #endregion
        
        // 3- Write a program that uses the ternary operator to check if 
        // the temperature is too hot, too cold, or just good. Assign the 
        // result in a variable then display the result. Assume that below 
        // 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good"
        #region General Problem 3

        // Console.WriteLine("Enter the temperature: ");
        // int temp = int.Parse(Console.ReadLine());
        // string ans = temp < 10 ? "Just Cold" : temp > 30 ? "Just Hot" : "Just Good";
        // Console.WriteLine(ans);

        #endregion

        // 4- Write a program that takes the date from the user and 
        // displays it in various formats using string interpolation.
        // Note:
        // Today’s date : 20 , 11 , 2001
        // Today's date : 20 / 11 / 2001
        // Today's date : 20 – 11 – 2001
        #region General Problem 4

        // Console.WriteLine("Enter the day:");
        // int day = int.Parse(Console.ReadLine());
        // Console.WriteLine("Enter the month:");
        // int month = int.Parse(Console.ReadLine());
        // Console.WriteLine("Enter the year:");
        // int year = int.Parse(Console.ReadLine());
        //
        // DateTime date = new DateTime(year, month, day);
        // Console.WriteLine("Today's date: "+date.ToString("dd , MM , yyyy"));
        // Console.WriteLine("Today's date: "+date.ToString("dd / MM / yyyy"));
        // Console.WriteLine("Today's date: "+date.ToString("dd - MM - yyyy"));

        #endregion
        
        // 5-What is the output of the following C# code? 
        // DateTime date = new DateTime(2024, 6, 14); 
        // Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
        // a) The event is on 14/06/2024
        // b) The event is on 2024-06-14
        // c) The event is on 06/14/2024
        // d) The event is on June 14, 2022
        #region General Problem 5

        // The correct answer is c
        
        // DateTime date = new DateTime(2024, 6, 14); 
        // Console.WriteLine($"The event is on {date:MM/dd/yyyy}");


        #endregion

    }

    static double CalculateSimpleInterest(double principal, double rate, int time)
    {
        return (principal * rate * time) / 100;
    }
    
    static double CalculateBMI(double weight, double height)
    {
        return weight / (height * height);
    }

}