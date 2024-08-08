
class Solution {

    private companion object {
        const val _24_HOURS = 24
    }

    fun countCompleteDayPairs(hours: IntArray): Long {
        val remainderHours = IntArray(_24_HOURS)
        var countCompleteDayPairs: Long = 0

        for (current in hours) {
            val remainder = current % _24_HOURS
            val complementaryTo24Hours = (_24_HOURS - (remainder)) % _24_HOURS
            countCompleteDayPairs += remainderHours[complementaryTo24Hours]
            ++remainderHours[remainder]
        }
        return countCompleteDayPairs
    }
}
