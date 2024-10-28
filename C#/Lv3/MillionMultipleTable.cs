using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersTest
{
    class MillionMultipleTable
    {
        public MillionMultipleTable()
        {
            int[] arrResult1 = solution(8, new int[3] { 1, 3, 7 });
            int[] arrResult2 = solution(8, new int[3] { 7, 3, 1 });
            int[] arrResult3 = solution(8, new int[3] { 3, 7, 1 });
        }

        private int[] solution(int e, int[] starts)
        {
            int[] answer = new int[starts.Length];
            int[] numcnt = new int[5000001];
            int[] numcntans = new int[5000001];

            int max = 0, maxaddr = 0;

            for (int i = 2; i <= e; i++)
            {
                for (int j = 1; j <= (e / i); j++)
                {
                    numcnt[i * j]++;
                }
            }

            for (int j = e; j >= 0; j--)
            {
                maxaddr = max > numcnt[j] ? maxaddr : j;
                max = max > numcnt[j] ? max : numcnt[j];
                numcntans[j] = maxaddr;
            }

            for (int i = 0; i < starts.Length; i++)
            {
                answer[i] = numcntans[starts[i]];
            }

            return answer;
        }
    }
}
