using System;

public class RectSize {
    public int solution(int[,] sizes) {
        int answer = 0;
        int nWidth = 0;
        int nHeight = 0;
        int nShortMax = 0;
        int nLongMax = 0;

        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            nWidth  = sizes[i, 0];
            nHeight = sizes[i, 1];

            if (nWidth > nHeight)
            {
                if (nLongMax < nWidth)
                {
                    nLongMax = nWidth;
                }
                
                if (nShortMax < nHeight)
                {
                    nShortMax = nHeight;
                }                   
            }
            else
            {
                if (nLongMax < nHeight)
                {
                    nLongMax = nHeight;
                }
                
                if (nShortMax < nWidth)
                {
                    nShortMax = nWidth;
                }                    
            }
        }

        answer = nShortMax * nLongMax;

        return answer;
    }
}
