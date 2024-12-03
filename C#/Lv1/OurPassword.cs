using System;

public class OurPassword {
    public string solution(string s, string skip, int index) {
        string answer = "";

        string sAlphabet = "abcdefghijklmnopqrstuvwxyz";
        for (int i = 0; i < skip.Length; i++)
        {
            sAlphabet = sAlphabet.Replace(skip[i].ToString(), "");
        }

        for (int i = 0; i < s.Length; i++)
        {
            int nIdx = (sAlphabet.IndexOf(s[i]) + index) % sAlphabet.Length;
            answer += sAlphabet[nIdx];
        }

        return answer;
    }
}
