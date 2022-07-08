using System;

namespace Convert_Sorted_Array_to_Binary_Search_Tree
{
  class Program
  {
    static void Main(string[] args)
    {
      var nums = new int[] { -10, -3, 0, 5, 9, 11, 15, 21 };
      Solution s = new Solution();
      s.SortedArrayToBST(nums);
    }
  }

  public class TreeNode
  {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
      this.val = val;
      this.left = left;
      this.right = right;
    }
  }

  public class Solution
  {
    public TreeNode SortedArrayToBST(int[] nums)
    {
      // as the array is sorted , the mid element in the array would be our root
      // left side elements of mid recursivly will be creating the left subtree
      // right side elements of mid recursivly will be creating the right subtree
      return Helper(nums, 0, nums.Length - 1);
    }

    private TreeNode Helper(int[] nums, int l, int r)
    {
      if (l > r) return null;
      int mid = (l + r) / 2;
      TreeNode root = new TreeNode(nums[mid]);
      root.left = Helper(nums, l, mid - 1);
      root.right = Helper(nums, mid + 1, r);

      return root;
    }
  }
}
