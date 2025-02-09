
using LeetCode.ArrayTasks;
using LeetCode.BinaryTreeTasks;
using LeetCode.LinkedListTasks;
using LeetCode.StackTasks;
using LeetCode.StringTasks;

var tn7 = new TreeNode(7, null, null);
var tn6 = new TreeNode(6, null, null);

var tn5 = new TreeNode(5, null, null);
var tn4 = new TreeNode(4, null, null);

var tn3 = new TreeNode(3, null, tn4);
var tn2 = new TreeNode(2, null, null);

var tn1 = new TreeNode(1, null, tn3);

var res = BalancedBinaryTree.IsBalanced(tn1);


Console.ReadKey();
