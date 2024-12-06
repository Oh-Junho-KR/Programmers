using System;

public class Fruit {
    public int solution(int k, int m, int[] score) {
        int answer = 0;

        Array.Sort(score);
        Array.Reverse(score);

        for (int i = 0; i < score.Length / m; i++)
        {
            answer += score[i * m + (m - 1)] * m;
        }

        return answer;
    }
}
