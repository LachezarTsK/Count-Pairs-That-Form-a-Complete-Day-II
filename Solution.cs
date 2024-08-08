
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
            int complementaryTo24Hours = (remainder != 0) ? (_24_HOURS - (current % _24_HOURS)) : 0;
            countCompleteDayPairs += remainderHours[complementaryTo24Hours];
            ++remainderHours[remainder];
        }
        return countCompleteDayPairs;
    }
}
