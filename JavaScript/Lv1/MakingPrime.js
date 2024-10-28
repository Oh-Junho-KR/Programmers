var solution = function (nums) {
    var answer = 0; // 결과값
    
    for (let i = 0; i < nums.length; i++) {
        for (let j = i + 1; j < nums.length; j++) {
            for (let k = j + 1; k < nums.length; k++) {
                let sum = nums[i] + nums[j] + nums[k];
                // 소수 판별
                if (fnIsPrime(sum)) {
                    answer++;
                }
            }
        }
    }
    
    return answer;
}

var fnIsPrime = function (num) {
    for (let i = 2; i < num; i++) {
        if (num % i === 0) return false;
    }
    
    return num > 1;
}
