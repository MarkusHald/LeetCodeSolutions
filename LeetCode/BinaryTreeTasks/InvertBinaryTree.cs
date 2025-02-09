namespace LeetCode.BinaryTreeTasks
{
    public static class InvertBinaryTree
    {
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root is null)
            {
                return root;
            } 

            var temp = root.left;
            root.left = InvertTree(root.right);
            root.right = InvertTree(temp);
        
            return root;
        }
    }
}
