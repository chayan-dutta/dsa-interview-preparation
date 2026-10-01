namespace Arrays;

// Problem: Frequency of Elements
//
// Given an integer array, find the frequency of each element.
//
// Example:
// Input:  [1, 2, 2, 3, 1, 4, 2, 3]
// Output:
// 1 -> 2
// 2 -> 3
// 3 -> 2
// 4 -> 1
//
// Constraints:
// - Array contains integers.
// - Print each unique element and its frequency.
//
// Requirement:
// - Solve without using LINQ.
// - Aim for an efficient solution.
public class FrequencyOfElements
{
    /// <summary>
    /// This method takes an array of integers as input and returns a dictionary containing the frequency of each unique element in the array.
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static Dictionary<int, int> GetFrequency(int[] arr)
    {
        Dictionary<int, int> frequency = [];

        foreach (int num in arr)
        {
            if (frequency.TryGetValue(num, out int value))
            {
                frequency[num] = ++value;
            }
            else
            {
                frequency[num] = 1;
            }
        }

        return frequency;
    }
}