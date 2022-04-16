using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsExercise
{
    class Numbers
    {
        public static string HasConsecutiveNums(int[] nums)
        {
            Array.Sort(nums);
            for (var i = 0; i < nums.Count() - 1; i++)
            {
                if ((nums[i] + 1) != nums[i + 1])
                {
                    return "Not Consecutive";
                }
                else
                {
                    continue;
                }
            }
            return "Consecutive";
        }
    }
}
