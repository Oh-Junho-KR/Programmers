using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersTest
{
    internal class OverTimeFigures
    {
        public OverTimeFigures()
        {
            Console.WriteLine(solution(4, new int[] { 4, 3, 3 })); // 12
            Console.WriteLine(solution(1, new int[] { 2, 1, 2 })); // 6
            Console.WriteLine(solution(3, new int[] { 1, 1 }));    // 0
            Console.WriteLine(solution(3, new int[] { 2 }));    // 0
        }

        public long solution(int n, int[] works)
        {
            long answer = 0; // 누적 피로도
            int nIndex = 0; // 현재 위치

            // 총 야근 시간보다 작업양이 적을경우 피로도0
            if (n >= works.Sum())
            {
                return answer;
            }

            // 작업이 하나뿐일 경우 바로 피로도 계산
            if (works.Length == 1)
            {
                works[0] -= n;
                answer = works[0] * works[0];
                return answer;
            }

            // 작업 내림차순 정렬
            works = works.OrderByDescending(x => x).ToArray();

            while (true)
            {
                works[nIndex] -= 1; // 가장 많은 작업양 -1
                n--; // 야근 시간 -1

                // 야근이 남아 있으면
                if (n > 0)
                {
                    for (int i = 0; i < works.Length; i++)
                    {
                        // 같은 작업끼리 비교 X
                        if (i == nIndex)
                        {
                            continue;
                        }

                        // 현재 한 작업과 다른 작업과 비교
                        // 다른 작업이 크면
                        if (works[nIndex] < works[i])
                        {
                            nIndex = i; // 해당 작업으로 변경
                            break;
                        } else if (works[nIndex] > works[i]) // 내림차순 정렬인데 현재 작업이 더 크면
                        {
                            break; // 계속해서 현재 작업 진행
                        }
                        else
                        {
                            continue; // 같으면 이후 작업과 비교
                        }
                    }              
                }
                else // 야근 시간이 없으면
                {
                    break; // 종료
                }
            }

            for (int i = 0; i < works.Length; i++)
            {
                answer += works[i] * works[i];
            }

            return answer;
        }
    }
}
