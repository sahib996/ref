/*task1
namespace ConsoleApp8
{
    internal class Program
    {
        static void Main()
        {
            int[] nums = { 1, -1, 2, -2, 3, -3, 4, -4 };
        }
        public static void ChangeCount(ref int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    nums[i] = nums[i] * (-1);
                }
                Console.WriteLine(nums[i]);
            }
        }
    }
}*/

/*Task 3*/

/*using System.ComponentModel.DataAnnotations;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main()
        { 
            int[] nums = {1,2,3,4,5,6,7,8};
            Min(ref nums);
        }
        public static void Min(ref int[] nums)
        {
            int verify = nums[0];
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i]<verify)
                {
                    verify = nums[i];
                }
                Console.WriteLine(verify);
            }
        }
    }
*/
/*}*/

/*task2*/

/*namespace ConsoleApp8
{
    internal class Program
    {
        static void Main()
        {
            string wordEnter = "sahib";
            Letter(ref wordEnter);
        }
        public static void Letter(ref string wordEnter)
        {
            int count = 0;
            for(int i = 0; i < wordEnter.Length; i++)
            {
                if (wordEnter[i] == 'a')
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}

*/