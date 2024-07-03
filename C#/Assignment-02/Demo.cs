namespace Assignment_02;

public class Demo
{
    static void Main2(string[] args)
    {
        #region Fractions
        // float fraction = 0.5f;
        // //double fraction = 0.5;
        // Console.WriteLine(fraction); // Output: 0.5
        #endregion

        #region Discard
        // var (_, second, _) = (1, 2, 3);
        // Console.WriteLine(second); // Output: 2
        #endregion

        #region Implicit Casting
        // int numImplicit = 123;
        // double doubleNumImplicit = numImplicit; // Implicit cast from int to double
        // Console.WriteLine(doubleNumImplicit); // Output: 123.0
        #endregion

        #region Explicit Casting
        // double doubleNumExplicit = 123.45;
        // int numExplicit = (int)doubleNumExplicit; // Explicit cast from double to int
        // Console.WriteLine(numExplicit); // Output: 123
        #endregion

        #region Parse Method
        // string strParse = "123";
        // int numParse = int.Parse(strParse);
        // Console.WriteLine(numParse); // Output: 123
        #endregion

        #region TryParse Method
        // string strTryParse = "123";
        // if (int.TryParse(strTryParse, out int numTryParse))
        // {
        //     Console.WriteLine(numTryParse); // Output: 123
        // }
        // else
        // {
        //     Console.WriteLine("Conversion failed.");
        // }
        #endregion

        #region Convert Method
        // string strConvert = "123";
        // int numConvert = Convert.ToInt32(strConvert);
        // Console.WriteLine(numConvert); // Output: 123
        #endregion

        #region Best Practices When Dealing with Casting
        // string strBestPracticeCasting = "123";
        // if (int.TryParse(strBestPracticeCasting, out int numBestPracticeCasting))
        // {
        //     Console.WriteLine(numBestPracticeCasting); // Output: 123
        // }
        // else
        // {
        //     Console.WriteLine("Conversion failed.");
        // }
        #endregion

        #region Operators

        // Arithmetic Operators
        // int a = 10;
        // int b = 20;
        // Console.WriteLine(a + b); // Output: 30
        // Console.WriteLine(a - b); // Output: -10
        // Console.WriteLine(a * b); // Output: 200
        // Console.WriteLine(b / a); // Output: 2
        // Console.WriteLine(b % a); // Output: 0
        //
        // Relational Operators
        // Console.WriteLine(a == b); // Output: False
        // Console.WriteLine(a != b); // Output: True
        // Console.WriteLine(a > b); // Output: False
        // Console.WriteLine(a < b); // Output: True
        // Console.WriteLine(a >= b); // Output: False
        // Console.WriteLine(a <= b); // Output: True

        // Logical Operators
        // bool x = true;
        // bool y = false;
        // Console.WriteLine(x && y); // Output: False
        // Console.WriteLine(x || y); // Output: True
        // Console.WriteLine(!x); // Output: False

        // Bitwise Operators
        // int c = 5;  // 0101 in binary
        // int d = 3;  // 0011 in binary
        // Console.WriteLine(c & d); // Output: 1 (0001 in binary)
        // Console.WriteLine(c | d); // Output: 7 (0111 in binary)
        // Console.WriteLine(c ^ d); // Output: 6 (0110 in binary)
        // Console.WriteLine(~c); // Output: -6 (inverting bits of 0101)

        // Assignment Operators
        // int e = 10;
        // e += 5;
        // Console.WriteLine(e); // Output: 15
        // e -= 3;
        // Console.WriteLine(e); // Output: 12
        // e *= 2;
        // Console.WriteLine(e); // Output: 24
        // e /= 4;
        // Console.WriteLine(e); // Output: 6
        // e %= 4;
        // Console.WriteLine(e); // Output: 2

        #endregion

        #region String Formatting
        // int age = 25;
        // string name = "John";
        // string formattedString = string.Format("Name: {0}, Age: {1}", name, age);
        // Console.WriteLine(formattedString); // Output: Name: John, Age: 25
        //
        // string interpolatedString = $"Name: {name}, Age: {age}";
        // Console.WriteLine(interpolatedString); // Output: Name: John, Age: 25
        #endregion

        #region Conditional Statements
        // int numConditional = 10;
        // if (numConditional > 0)
        // {
        //     Console.WriteLine("Positive number");
        // }
        // else
        // {
        //     Console.WriteLine("Non-positive number");
        // }
        //
        // int day = 2;
        // switch (day)
        // {
        //     case 1:
        //         Console.WriteLine("Monday");
        //         break;
        //     case 2:
        //         Console.WriteLine("Tuesday");
        //         break;
        //     default:
        //         Console.WriteLine("Other day");
        //         break;
        // }
        #endregion

        #region Best Practices When Dealing with Conditional Statements
        // int score = 85;
        // string grade = score switch
        // {
        //     >= 90 => "A",
        //     >= 80 => "B",
        //     >= 70 => "C",
        //     _ => "F"
        // };
        // Console.WriteLine(grade); // Output: B
        #endregion

        #region For Loop
        // for (int i = 0; i < 5; i++)
        // {
        //     Console.WriteLine(i); // Output: 0 1 2 3 4
        // }
        // #endregion
        //
        // #region Do While Loop
        // int j = 0;
        // do
        // {
        //     Console.WriteLine(j); // Output: 0
        //     j++;
        // } while (j < 1);
        #endregion

        #region While Loop
        // int k = 0;
        // while (k < 5)
        // {
        //     Console.WriteLine(k); // Output: 0 1 2 3 4
        //     k++;
        // }
        // #endregion
        //
        // #region Foreach Loop
        // int[] numbers = { 1, 2, 3, 4, 5 };
        // foreach (int num in numbers)
        // {
        //     Console.WriteLine(num); // Output: 1 2 3 4 5
        // }
        #endregion

    }
}