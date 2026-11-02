// Instructions: Write a function (use template below to get started) that takes a list of integers 
// and returns a list of only the positive even numbers, doubled. 
// Add at least one error-handling condition.
//
// For submission, commit and push the edited file to Github

using System;
using System.Collections.Generic;

public class Task1
{
    /// <summary>
    /// Filters a mixed list, keeps only positive even integers, doubles them, and returns the result.
    /// Non-integer values and nulls are safely skipped (error-handling).
    /// </summary>
    public static List<int> GetDoubledPositiveEvens(List<object> numberList)
    {
        // Error-handling condition #1: Guard against a null list
        if (numberList == null)
        {
            Console.WriteLine("Warning: Input list is null. Returning empty list.");
            return new List<int>();
        }

        List<int> finalList = new List<int>();

        // Go through each item in the list
        foreach (var item in numberList)
        {
            // Error-handling condition #2: Skip null items and non-integer values
            if (item is null)
            {
                // Null is not a valid number – skip it
                continue;
            }

            if (!(item is int number))
            {
                // Item is not an integer (e.g. string, double, etc.) – skip it
                continue;
            }

            // Keep only positive even numbers, then double them
            if (number > 0 && number % 2 == 0)
            {
                int doubledNumber = number * 2;
                finalList.Add(doubledNumber);
            }
        }

        return finalList;
    }

    // Example usage / quick test
    static void Main()
    {
        List<object> myNumbers = new List<object> { 1, 2, "hello", -4, 6, null, 8, 0, 3.5, 10 };

        List<int> result = GetDoubledPositiveEvens(myNumbers);

        Console.WriteLine(string.Join(", ", result));
        // Expected output: 4, 12, 16, 20
        // Explanation:
        //  2  → positive even → 4
        //  6  → positive even → 12
        //  8  → positive even → 16
        // 10  → positive even → 20
        // Everything else is filtered out (odd, negative, zero, non-int, null)
    }
}
