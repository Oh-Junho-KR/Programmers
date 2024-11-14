function solution(s){
    var answer = true;
    var np = 0;
    var ny = 0;

    s = s.toLowerCase();
    for(var i=0; i<s.length; i++){
        if(s[i] === 'p'){
            np++;
        }
        if(s[i] === 'y'){
            ny++;
        }
    }
    answer = (np === ny) ? true : false;

    return answer;
}
