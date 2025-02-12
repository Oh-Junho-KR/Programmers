using System;
using System.Collections.Generic;
using System.Linq;

public class HallOfFame {
    public int[] solution(int k, int[] score) {

        List<int> list = new List<int>();
        List<int> minList = new List<int>();

        if (k < score.Length) {
            for (int i = 0; i < k; i++)
            {
                list.Add(score[i]);
                minList.Add(list.Min());
            }
            
            for (int i = k; i < score.Length; i++)
            {
                list.Add(score[i]);
                list.Remove(list.Min());
                minList.Add(list.Min());
            }
        } else {
             for(int i=0;i<score.Length;i++)
             {
                 list.Add(score[i]);
                 minList.Add(list.Min());
             }
         }

        return minList.ToArray();
    }
}
