#include <string>
#include <vector>

using namespace std;

int solution(int n) {
    int nAnswer = 0;
    
    for (int i = 1; i <= n; i++)
    {
        int nSum = 0; // Sum
        int nStart = i; // Start Index
        
        while (nSum < n) { // n보다 합이 작으면 반복
            nSum += nStart++;
        }
        
        if (nSum == n) { // 같으면 +1
            nAnswer++;
        }
    }
    return nAnswer;
}
