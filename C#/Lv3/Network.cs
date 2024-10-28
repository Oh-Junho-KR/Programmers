using System;

namespace ProgrammersTest
{
    class Network
    {
        public Network()
        {
            //Console.WriteLine(solution(3, new int[,] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } })); // 3
            //Console.WriteLine(solution(3, new int[,] { { 1, 0, 1 }, { 0, 1, 0 }, { 1, 0, 1 } })); // 2
            //Console.WriteLine(solution(3, new int[,] { { 1, 1, 0 }, { 1, 1, 0 }, { 0, 0, 1 } })); // 2
            //Console.WriteLine(solution(3, new int[,] { { 1, 1, 0 }, { 1, 1, 1 }, { 0, 1, 1 } })); // 1
            //Console.WriteLine(solution(3, new int[,] { { 1, 0, 1 }, { 0, 1, 1 }, { 1, 1, 1 } })); // 1
            //Console.WriteLine(solution(3, new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } })); // 1
            Console.WriteLine(solution(4, new int[,] { { 1, 1, 0, 1 }, { 1, 1, 0, 0 }, { 0, 0, 1, 1 }, { 1, 0, 1, 1 } })); // 1
            //Console.WriteLine(solution(4, new int[,] { { 1, 1, 1, 1 }, { 1, 1, 0, 0 }, { 1, 0, 1, 0 }, { 1, 0, 0, 1 } })); // 1
            //Console.WriteLine(solution(4, new int[,] { { 1, 0, 1, 0 }, { 0, 1, 0, 1 }, { 0, 0, 1, 1 }, { 0, 1, 1, 1 } })); // 1
            //Console.WriteLine(solution(4, new int[,] { { 1, 1, 0, 0 }, { 1, 1, 1, 0 }, { 0, 1, 1, 1 }, { 0, 0, 1, 1 } })); // 1
            //Console.WriteLine(solution(5, new int[,] { { 1, 0, 0, 0, 1 }, { 0, 1, 0, 0, 0 }, { 0, 0, 1, 1, 0 }, { 0, 0, 1, 1, 0 },{ 1, 0, 0, 0, 1 } })); // 3
            //Console.WriteLine(solution(5, new int[,] { { 1, 1, 1, 0, 0 }, { 1, 1, 0, 0, 0 }, { 1, 0, 1, 0, 0 }, { 0, 0, 0, 1, 1 },{ 0, 0, 0, 1, 1 } })); // 2
            //Console.WriteLine(solution(6, new int[,] { { 1, 0, 1, 1, 0, 0 }, { 0, 1, 0, 0, 1, 1 }, { 1, 0, 1, 1, 1, 1 }, { 1, 0, 1, 1, 1, 1 }, { 0, 1, 1, 1, 1, 1 }, { 0, 1, 1, 1, 1, 1 } })); // 1
            //Console.WriteLine(solution(7, new int[,] { { 1, 1, 0, 0, 0, 0, 0 }, { 1, 1, 0, 1, 1, 0, 0 }, { 0, 0, 1, 0, 0, 0, 1 }, { 0, 1, 0, 1, 0, 0, 0 }, { 0, 1, 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0, 1, 0 }, { 0, 0, 1, 0, 0, 0, 1 } })); // 3
        } 

        public int solution(int n, int[,] computers)
        {
            int answer = 0;
            bool[] bVisited = new bool[n];

            for (int i = 0; i < n; i++)
            {
                if (!bVisited[i])
                {
                    answer++;
                    fnDFS(computers, bVisited, i);
                }
            }

            return answer;
        }

        private void fnDFS(int[,] computers, bool[] bVisited, int nStart)
        {
            bVisited[nStart] = true;

            for (int i = 0; i < computers.GetLength(0); i++)
            {
                if (computers[nStart, i] == 1 && !bVisited[i])
                {
                    fnDFS(computers, bVisited, i);
                }
            }
        }
    }
}
