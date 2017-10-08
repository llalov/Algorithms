using System;
using System.Collections.Generic;
using System.Linq;

namespace _5_2_Longest_Increasing_Subsequence_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            //stores the length of the subsequence for each index
            int[] len = new int[sequence.Length];
            //index of the previous element in the subsequence
            int[] prev = new int[sequence.Length];
            //length of the longest subsequence
            int maxLen = 0;
            //last index of the longest subsequence. Using -1 to mark that there is no such index found currently
            int lastIndex = -1;

            for (int x = 0; x < sequence.Length; x++)
            {
                len[x] = 1;
                prev[x] = -1;
                for (int i = 0; i < x; i++)
                {
                    if (sequence[i] < sequence[x] && len[i] + 1 > len[x])
                    {
                        len[x] = len[i] + 1;
                        prev[x] = i;
                    }
                }
                if (len[x] > maxLen)
                {
                    maxLen = len[x];
                    lastIndex = x;
                }
            }

            int[] result = RestoreLIS(sequence, prev, lastIndex);

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]+" ");
            }

            int[] RestoreLIS(int[] seq, int[] previous, int lastindex)
            {
                var longestSeq = new List<int>();
                while(lastIndex != -1)
                {
                    longestSeq.Add(sequence[lastIndex]);
                    lastIndex = prev[lastIndex];
                }
                longestSeq.Reverse();
                return longestSeq.ToArray();
            }
        }
    }
}
