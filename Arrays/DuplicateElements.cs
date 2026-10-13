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
public class DuplicateElements
{
    public static int[] GetDuplicateElements(int[] arr)
    {
        return [.. arr.GroupBy(x => x)
                            .Where(g => g.Count() > 1)
                            .Select(g => g.Key)];
        
    }
}
