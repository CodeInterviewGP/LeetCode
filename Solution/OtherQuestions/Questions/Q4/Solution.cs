using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions.Questions.Q4
{
    public class Solution
    {
        public int Replace0with1(string s, int N)
        {
            // How many 0 before each 1
            List<int> count0Before1 = new List<int>();

            //Index of '1'
            List<int> indexOf1 = new List<int>();

            int len = s.Length;

            int countOf0 = 0;

            for (int i = 0; i < len; i++)
            {
                if (s[i] == '1')
                {
                    indexOf1.Add(i);
                    count0Before1.Add(countOf0);
                }
                else
                {
                    countOf0++;
                }
            }

            int ii = -1;
            int jj = -1;

            int maxRange = -1;

            int cLen = count0Before1.Count;

            if (cLen == 0)
            {
                return Math.Min(N, s.Length);
            }

            for (int i = 0; i < cLen; i++)
            {
                for (int j = i+1; j < cLen; j++)
                {
                    // get max length between two index of 1 which contains  length of '0' less then N
                    if (count0Before1[j] - count0Before1[i] <= N && indexOf1[j] - indexOf1[i] > maxRange)
                    {
                        ii = i;
                        jj = j;
                        maxRange = indexOf1[j] - indexOf1[i];
                    }
                }
            }

            int result = N + 1;

            if (ii != -1)
            {
                result = maxRange + 1 + (N - (count0Before1[jj] - count0Before1[ii]));
            }

            return Math.Min(result, s.Length);
        }
    }
}
