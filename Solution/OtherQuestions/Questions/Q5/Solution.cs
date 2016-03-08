using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions.Questions.Q5
{
    public class Solution
    {
        public int GetSmallClosestNumber(TreeNode root, int target)
        {
            if (root == null)
            {
                return int.MinValue;
            }

            if (root.Val >= target)
            {
                return GetSmallClosestNumber(root.Left, target);
            }
            else
            {
                int rightResult = GetSmallClosestNumber(root.Right, target);

                return Math.Max(root.Val, rightResult);
            }
        }
    }
}
