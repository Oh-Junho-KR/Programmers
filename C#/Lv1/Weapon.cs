using System;

public class Weapon {
    public int solution(int number, int limit, int power) {
        int answer = 0;

        for (int i = 1; i <= number; i++)
        {
            int nCnt = 0;
            for (int j = 1; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    if (i / j == j)
                    {
                        nCnt++;
                        if (nCnt > limit)
                        {
                            nCnt = power;
                            break;
                        }
                    }
                    else
                    {
                        nCnt += 2;
                        if (nCnt > limit)
                        {
                            nCnt = power;
                            break;
                        }
                    }
                }
            }

            answer += nCnt;
        }

        return answer;
    }
}
