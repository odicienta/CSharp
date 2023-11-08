public class Solution {
    public bool CheckTree(TreeNode root) {
        bool checkRootValue = root.val == (root.left.val + root.right.val) ? true : false;
        return checkRootValue;
    }
}