namespace LeetCode.BinaryTreeTasks
{
    public static class BalancedBinaryTree
    {
        public static bool IsBalanced(TreeNode root)
        {
            FindHeight(root);

            

            return heightDiff < 2;
        }

        private static int FindHeight(TreeNode root)
        {
            if (root is null)
            {
                return 0;
            }

            var leftHeight = FindHeight(root.left)
            var rightHeight = FindHeight(root.right);

            var heightDiff = Math.Abs(leftHeight - rightHeight);
            if (heightDiff > 1) 
            {

            }

            return Math.Max(leftHeight, rightHeight) + 1;           

        }
    }
}
