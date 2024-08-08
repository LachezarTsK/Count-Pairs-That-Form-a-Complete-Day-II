
using System;

public class Solution
{
    private static readonly int _24_HOURS = 24;

    public long CountCompleteDayPairs(int[] hours)
    {
        int[] remainderHours = new int[_24_HOURS];
        long countCompleteDayPairs = 0;

        foreach (int current in hours)
        {
            int remainder = current % _24_HOURS;
            int complementaryTo24Hours = (_24_HOURS - (remainder)) % _24_HOURS;
            countCompleteDayPairs += remainderHours[complementaryTo24Hours];
            ++remainderHours[remainder];
        }
        return countCompleteDayPairs;
    }
}
