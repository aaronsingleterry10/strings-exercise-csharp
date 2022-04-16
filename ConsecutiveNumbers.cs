using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsExercise
{
    public class ConsecutiveNumbers
    {
        public static string HasConsecutiveNums(int[] nums)
        {
            Array.Sort(nums);
            bool isConsecutive = true;
            for (var i = 0; i < nums.Count() - 1; i++)
            {
                if ((nums[i] + 1) != nums[i + 1])
                {
                    isConsecutive = false;
                    return "Not Consecutive";
                }
                else
                {
                    continue;
                }
            }
            if (isConsecutive)
            {
                return "Consecutive";
            }
            return "Consecutive";
        } 
    }
}
