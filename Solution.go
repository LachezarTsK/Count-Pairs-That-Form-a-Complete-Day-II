
package main

import "fmt"

const _24_HOURS = 24

func countCompleteDayPairs(hours []int) int64 {
    remainderHours := make([]int, _24_HOURS)
    var countCompleteDayPairs int64 = 0

    for _, current := range hours {
        remainder := current % _24_HOURS
        complementaryTo24Hours := (_24_HOURS - (remainder)) % _24_HOURS
        countCompleteDayPairs += int64(remainderHours[complementaryTo24Hours])
        remainderHours[remainder]++
    }
    return countCompleteDayPairs
}
