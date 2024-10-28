using System;

namespace ProgrammersTest
{
    class BuyCookie
    {
        public BuyCookie()
        {
            Console.WriteLine(solution(new int[] { 1, 1, 1, 1 }));
            Console.WriteLine(solution(new int[] { 1, 1, 2, 3 }));
            Console.WriteLine(solution(new int[] { 1, 2, 4, 5 }));
            Console.WriteLine(solution(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
            Console.WriteLine(solution(new int[] { 0, 3, 3, 3, 3, 3, 5, 5, 5, 6 }));
        }

        private int solution(int[] cookie)
        {
            int nAnswer = 0; // 최대 개수
            int nCurFirstIndex = 0; // 첫째의 현재 장바구니 위치
            int nCurSecondIndex = 0; // 둘째의 현재 장바구니 위치
            int nMinIndex = -1; // 장바구니 최초(좌측) 기준 위치
            int nMaxIndex = cookie.Length; // 장바구니 최대(우측) 기준 위치
            int nFirst = 0; // 첫째 수량
            int nSecond = 0; // 둘째 수량

            // 쿠키 개수 -1 만큼 반복
            // 둘째가 첫째 위치의 +1 이기 때문에 Out Of Memory 방지
            for (int i = 0; i < cookie.Length - 1; i++) 
            {
                nCurFirstIndex = i; // 첫째의 시작 위치
                nCurSecondIndex = i + 1; // 둘째의 시작 위치

                nFirst = cookie[nCurFirstIndex]; // 초기 수량 설정
                nSecond = cookie[nCurSecondIndex]; // 초기 수량 설정

                while (true)
                {
                    if (nFirst < nSecond) // 둘째가 더 많으면
                    {
                        // 첫째는 좌측으로 이동해서 개수를 늘려야 하는데
                        // 좌측에 여분이 있다면
                        if (nCurFirstIndex - 1 > nMinIndex) 
                        {
                            nCurFirstIndex--; // 좌측 index -1 설정
                            nFirst += cookie[nCurFirstIndex]; // 첫째 개수 추가
                        }
                        else // 좌측 여분 없으면 종료
                        {
                            break;
                        }
                    } else if (nFirst > nSecond) // 첫째가 더 많으면
                    {
                        // 둘째는 우측으로 이동해서 개수를 늘려야 하는데
                        // 우측에 여분이 있다면
                        if (nCurSecondIndex + 1 < nMaxIndex)
                        {
                            nCurSecondIndex++; // 우측 index + 1 설정
                            nSecond += cookie[nCurSecondIndex]; // 둘째 개수 추가
                        }
                        else // 우측 여분 없으면 종료
                        {
                            break;
                        }
                    } else // 둘이 같다면
                    {
                        // 지금까지 나왔던 답보다 크면
                        if (nAnswer < nFirst && nAnswer < nSecond && nFirst == nSecond)
                        {
                            nAnswer = nFirst; // 현재 개수 저장
                        }

                        // 좌측에 여분이 있다면
                        if (nCurFirstIndex - 1 > nMinIndex)
                        {
                            nCurFirstIndex--; // 좌측 index -1 설정
                            nFirst += cookie[nCurFirstIndex]; // 첫째 개수 추가
                        } else
                        {
                            break;
                        }

                        // 우측에 여분이 있다면
                        if (nCurSecondIndex + 1 < nMaxIndex)
                        {
                            nCurSecondIndex++; // 우측 index + 1 설정
                            nSecond += cookie[nCurSecondIndex]; // 둘째 개수 추가
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return nAnswer;
        }
    }
}
