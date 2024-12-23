using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammersTest
{
    internal class ConvertWords
    {
        public ConvertWords()
        {
            Console.WriteLine(solution("hit", "cog", new string[] { "hot", "dot", "dog", "lot", "log", "cog" }));
            Console.WriteLine(solution("hit", "cog", new string[] { "hot", "dot", "dog", "lot", "log" }));
        }

        public int solution(string begin, string target, string[] words)
        {
            int answer = 0;
            bool bComplete = false;
            List<int> lstIndex = new List<int>();

            if (!words.Contains(target))
            {
                return answer;
            }

            while (true)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    int nCnt = 0;

                    if (lstIndex.Contains(i))
                    {
                        continue;
                    }

                    for (int j = 0; j < target.Length; j++)
                    {
                        if (begin[j] == target[j])
                        {
                            nCnt++;
                        }
                    }

                    if (nCnt == begin.Length - 1)
                    {
                        answer++;
                        bComplete = true;
                        break;
                    }

                    nCnt = 0;
                    for (int j = 0; j < words[i].Length; j++)
                    {
                        if (begin[j] == words[i][j])
                        {
                            nCnt++;
                        }
                    }

                    if (nCnt == begin.Length - 1)
                    {
                        begin = words[i];
                        lstIndex.Add(i);
                        answer++;
                        i = -1;
                        
                        if (begin == target)
                        {
                            bComplete = true;
                            break;
                        }
                    }
                }

                if (bComplete)
                {
                    break;
                }
            }

            return answer;
        }
    }
}
