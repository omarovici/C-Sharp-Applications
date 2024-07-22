using System.Collections;

namespace Assignment_01_Advanced;

class Program
{
    static void Main(string[] args)
    {
        // 1. create a generic Range<T> class that represents a range of values
        // from a minimum value to a maximum value. The range should 
        // support basic operations such as checking if a value is within the
        // range and determining the length of the range.
        // Requirements:
        // 1. Create a generic class named Range<T> where T represents the
        // type of values.
        // 2. Implement a constructor that takes the minimum and maximum
        // values to define the range.
        // 3. Implement a method IsInRange(T value) that returns true if the
        // given value is within the range, otherwise false.
        // 4. Implement a method Length() that returns the length of the range
        // (the difference between the maximum and minimum values).
        // 5. Note: You can assume that the type T used in the Range<T> class
        // implements the IComparable<T> interface to allow for
        // comparisons.

        #region Problem 1

        // var Range1 = new Range<int>(1, 10);
        // Console.WriteLine($"Is in Range ? => {Range1.IsInRange(2)}");
        // Console.WriteLine($"Is in Range ? => {Range1.IsInRange(100)}");
        // Console.WriteLine($"Length of Range => {Range1.Length()}");
        //
        // var Range2 = new Range<double>(9.75, 77.15);
        // Console.WriteLine($"Is in Range ? => {Range2.IsInRange(44.10)}");
        // Console.WriteLine($"Is in Range ? => {Range2.IsInRange(9.74)}");
        // Console.WriteLine($"Length of Range => {Range2.Length()}");


        #endregion

        // 2-You are given an ArrayList containing a sequence of elements. try to 
        // reverse the order of elements in the ArrayList in-place(in the same
        // arrayList) without using the built-in Reverse. Implement a function that
        // takes the ArrayList as input and modifies it to have the reversed order of
        // elements.

        #region Problem 2

        // ArrayList arrayList = new ArrayList();
        // arrayList.Add(1);
        // arrayList.Add(2);
        // arrayList.Add(3);
        // arrayList.Add(4);
        // arrayList.Add(5);
        // arrayList.Add(6);
        // arrayList.Add(7);
        // arrayList.Add(8);
        // arrayList.Add(9);
        // arrayList.Add(10);
        // Console.Write("Before Reverse => ");
        // foreach (var i in arrayList)
        // {
        //     Console.Write(i+" ");
        // }
        // ArrayListReverse(arrayList);
        // Console.WriteLine();
        // Console.Write("After Reverse => ");
        // foreach (var i in arrayList)
        // {
        //     Console.Write(i+" ");
        // }

        #endregion

        // 3.You are given a list of integers. Your task is to find and return a new list
        // containing only the even numbers from the given list.

        #region Problem 3

        // List<int> list = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        // Console.Write("List integer numbers => ");
        // foreach (var i in list)
        // {
        //     Console.Write(i+" ");
        // }
        //
        // Console.WriteLine();
        // EvenNumbersList(list);
        //
        // Console.Write("List even integer numbers => ");
        // foreach (var i in list)
        // {
        //     Console.Write(i+" ");
        // }

        #endregion


    }

    public static void ArrayListReverse(ArrayList arrayList)
    {
        if (arrayList != null)
        {
            int cnt = arrayList.Count;
            int x = cnt / 2;
            for (int i = 0; i < x; i++)
            {
                object tmp = arrayList[i];
                arrayList[i] = arrayList[cnt - i - 1];
                arrayList[cnt - i - 1] = tmp;
            }
        }
    }

    public static void EvenNumbersList(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] % 2 != 0) list.Remove(list[i]);
        }
    }
}