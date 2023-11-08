public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if(root != null)
        {
            var temp = root.left;
            root.left = InvertTree(root.right);
            root.right = InvertTree(temp);
        }
        
        return root;
    }
}