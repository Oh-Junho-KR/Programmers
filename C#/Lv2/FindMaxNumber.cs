using System;
using System.Collections.Generic;
using System.Linq;
public class FindMaxNumber
{
    public int[] solution(int[] numbers)
    {
        int[] answer = new int[numbers.Length];
        Stack<int> stkNumber = new Stack<int>();
        Array.Fill(answer, -1);

        for (int i = 0; i < numbers.Length; i++) 
        {
            int num = numbers[i];

            while (stkNumber.Count() > 0)
            {
                if (numbers[stkNumber.Peek()] >= num){
                    break;
                }
                    
                answer[stkNumber.Pop()] = num;
            }

            stkNumber.Push(i);
        }
        return answer;
    }
}
