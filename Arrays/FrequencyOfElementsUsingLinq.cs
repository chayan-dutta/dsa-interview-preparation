namespace Arrays;

// Problem: Find Duplicate Elements
//
// Given an integer array, find all elements that appear
// more than once.
//
// Example:
// Input:  [1, 2, 3, 2, 4, 5, 1, 6, 3]
//
// Output:
// 1
// 2
// 3
//
// Requirements:
// - Use LINQ.
// - Each duplicate element should appear only once in the output.
// - Maintain the order of first occurrence.
//
// Expected Output:
// 1 -> duplicate
// 2 -> duplicate
// 3 -> duplicate
public class FrequencyOfElementsUsingLinq
{
    public static Dictionary<int, int> GetFrequency(int[] arr)
    {
        return arr.GroupBy(x => x)
                .ToDictionary(g => g.Key, g => g.Count());
    }
}
