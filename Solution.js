
/**
 * @param {number[]} hours
 * @return {number}
 */
var countCompleteDayPairs = function (hours) {
    const _24_HOURS = 24;
    const remainderHours = new Array(_24_HOURS).fill(0);
    let countCompleteDayPairs = 0;

    for (let current of hours) {
        let remainder = current % _24_HOURS;
        let complementaryTo24Hours = (_24_HOURS - (remainder)) % _24_HOURS;
        countCompleteDayPairs += remainderHours[complementaryTo24Hours];
        ++remainderHours[remainder];
    }
    return countCompleteDayPairs;
};
