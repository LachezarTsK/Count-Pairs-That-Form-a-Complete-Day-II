
#include <array>
#include <vector>
using namespace std;

class Solution {

    static const int _24_HOURS = 24;

public:
    long long countCompleteDayPairs(const vector<int>& hours) const {
        array<int, _24_HOURS> remainderHours{};
        long long countCompleteDayPairs = 0;

        for (const auto& current : hours) {
            int remainder = current % _24_HOURS;
            int complementaryTo24Hours = (remainder != 0) ? (_24_HOURS - (current % _24_HOURS)) : 0;
            countCompleteDayPairs += remainderHours[complementaryTo24Hours];
            ++remainderHours[remainder];
        }
        return countCompleteDayPairs;
    }
};
