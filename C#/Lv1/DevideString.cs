using System;
using System.Text.RegularExpressions;

public class DevideString {
    public int solution(string s) {
        int answer = 0;
        string sWord = null;
        for (int i = 0; i < s.Length; i++)
        {
            sWord += s[i];
            MatchCollection mcMacth = Regex.Matches(sWord, sWord[0].ToString(), RegexOptions.IgnoreCase);
            
            if (mcMacth.Count == sWord.Length - mcMacth.Count)
            {
                sWord = null;
                answer++;
            }

            if (i == s.Length - 1 && sWord != null)
            {
                answer++;
            }
        }

        return answer;
    }
}
