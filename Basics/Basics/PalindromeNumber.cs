namespace Basics;

public class PalindromeNumber
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static bool IsPalindrome(int number)
    {
        int reverse = 0;
        int n = number;

        while (n > 0)
        {
            int rem = n % 10;
            reverse = reverse * 10 + rem;
            n /= 10;
        }

        if (reverse == number)
            return true;
        
        return false;
    }
}
