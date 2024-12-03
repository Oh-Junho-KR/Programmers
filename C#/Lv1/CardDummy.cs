using System;

public class CardDummy {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        string answer = "Yes";

        int nIndex1 = 0;
        int nIndex2 = 0;

        for (int i = 0; i < goal.Length; i++)
        {
            if (nIndex1 < cards1.Length && cards1[nIndex1] == goal[i])
            {
                nIndex1++;
            }
            else if (nIndex2 < cards2.Length && cards2[nIndex2] == goal[i])
            {
                nIndex2++;
            }
            else
            {
                return "No";
            }               
        }

        return answer;
    }
}
