
public class Solution {

    private static final int _24_HOURS = 24;

    public long countCompleteDayPairs(int[] hours) {
        int[] remainderHours = new int[_24_HOURS];
        long countCompleteDayPairs = 0;

        for (int current : hours) {
            int remainder = current % _24_HOURS;
            int complementaryTo24Hours = (remainder != 0) ? (_24_HOURS - (current % _24_HOURS)) : 0;
            countCompleteDayPairs += remainderHours[complementaryTo24Hours];
            ++remainderHours[remainder];
        }
        return countCompleteDayPairs;
    }
}
