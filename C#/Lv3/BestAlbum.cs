using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammersTest
{
    class BestAlbum
    {
        public BestAlbum()
        {
            // 장르 재생수 / 노래 재생수 / 노래 고유번호
            int[] arrResult1 = solution(new string[] { "classic", "pop", "classic", "classic", "pop" }, new int[] { 500, 600, 150, 800, 2500 });
        }

        public int[] solution(string[] genres, int[] plays)
        {
            int[] answer = null; // 결과 Array
            List<int> lstResult = new List<int>(); // 결과 List

            // Key : 장르 Value : (Key : index, Value : 플레이 수)
            Dictionary<string, Dictionary<int, int>> dicSong = new Dictionary<string, Dictionary<int, int>>();

            for (int i = 0; i < genres.Length; i++)
            {
                if (dicSong.ContainsKey(genres[i]))
                {
                    dicSong[genres[i]].Add(i, plays[i]);
                }
                else
                {
                    Dictionary<int, int> lstPlays = new Dictionary<int, int>();
                    dicSong[genres[i]] = lstPlays;
                    dicSong[genres[i]].Add(i, plays[i]);
                }
            }

            // 장르 재생수 총 합 정렬
            var dicDesSong = dicSong.OrderByDescending(x => x.Value.Values.Sum());

            foreach (var dic in dicDesSong)
            {
                // 노래 재생수 정렬
                var dicDesPlays = dicSong[dic.Key].OrderByDescending(x => x.Value);

                int nCnt = 0;
                foreach (var dicOrder in dicDesPlays)
                {
                    lstResult.Add(dicOrder.Key);
                    nCnt++;

                    if (nCnt == 2)
                    {
                        break;
                    }
                }
            }

            answer = lstResult.ToArray();

            return answer;
        }
    }
}
