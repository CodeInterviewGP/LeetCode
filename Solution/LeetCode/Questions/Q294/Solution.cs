using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Questions.Q294
{
    public class Solution
    {
        Dictionary<string, bool> mapping = new Dictionary<string, bool>();

        public bool CanWin(string s)
        {
            mapping = new Dictionary<string, bool>();

            return MoveWin(s);
        }

        private bool MoveWin(string s)
        {
            if (mapping.ContainsKey(s))
            {
                return mapping[s];
            }

            IList<string> nextSteps = GeneratePossibleNextMoves(s);

            foreach (string ss in nextSteps)
            {
                if (!MoveWin(ss))
                {
                    mapping.Add(s, true);
                    return true;
                }
            }

            mapping.Add(s, false);

            return false;
        }

        public IList<string> GeneratePossibleNextMoves(string s)
        {
            IList<string> result = new List<string>();

            int len = s.Length;

            for (int i = 1; i < len; i++)
            {
                if (s[i] == '+' && s[i - 1] == '+')
                {
                    StringBuilder sb = new StringBuilder(s);

                    sb[i] = '-';
                    sb[i - 1] = '-';

                    result.Add(sb.ToString());
                }
            }

            return result;
        }
    }
}
