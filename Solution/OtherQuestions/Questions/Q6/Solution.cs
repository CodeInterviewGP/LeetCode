using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions.Questions.Q6
{
    public class Solution
    {
        public int Fun(int target)
        {
            if (target == 1)
            {
                return 1;
            }

            return (int)Math.Pow(2, target - 1) - 1;
        }
    }
}
