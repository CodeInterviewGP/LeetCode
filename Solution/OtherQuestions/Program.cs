using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = "abde8d9328fkajsdifuqefjaisdfiwierkfjausdfajsdkfjioquwiejfkasdf".ToCharArray();
            
            Questions.Q3.Solution solution = new Questions.Q3.Solution();

            solution.SortWithoutLoop(input);
        }
    }
}
