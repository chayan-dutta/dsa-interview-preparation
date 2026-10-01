namespace Basics;

public static class PrimeNumber
{
    public static bool IsPrime(int num)
    {
        if (num < 2)
            return false;
        
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
}
