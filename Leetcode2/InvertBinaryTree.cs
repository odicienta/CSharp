public class Solution {
    public TreeNode InvertTree(TreeNode root) {//TreeNode representa nodos en estructuras como los arboles || El metodo se llama InvertTree
    //este toma un nodo llamado root como entrada
        if(root != null)//este if verifica que la entrada de root sea diferente a null
        {
            var temp = root.left;//temp es para representar al hijo izquierdo original 
            root.left = InvertTree(root.right);//llamamos a la funcion InvertTree recursivamente en el hijo derecho del nodo
            //luego declaramos root.left como root.right
            root.right = InvertTree(temp);//aca llamamos a InvertTree de nuevo con la variable temp original y se la asignamos a root.right
        }
        
        return root;//devolvemos el nodo root que ahora representa el arbol invertido
    }
}