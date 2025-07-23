/*
 Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.
*/
// parte de cima é o exercício


int[] nums = new int[3];
int target;

nums = new int[] {2,7,15,11}; // quero retornar 9, ou seja, 2 + 7 ( 0 + 1 )

for ( int i = 0; i < nums.Length; i++)
{
    target = 26;
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] + nums[j] == target)
        {
            Console.WriteLine($"[{i}, {j}]");
            return;
        }
    }
}