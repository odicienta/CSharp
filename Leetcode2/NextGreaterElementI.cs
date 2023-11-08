public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {//metodo llamado NextGraterElement tiene 2 Arrays de enteros
        Dictionary<int, int> nextGreater = new Dictionary<int, int>();//se crea el dic nextGreater para almacenar el proximo elemento mayor para cada elemento de nums2
        Stack<int> stack = new Stack<int>();//esta pila se utilizara para rastrear los elementos de num2 mientras se busca el proximo elemento mayor

    // Recorre nums2 para encontrar el próximo elemento mayor para cada elemento.
    for (int i = 0; i < nums2.Length; i++) {//for loop para recorrer el array
        while (stack.Count > 0 && nums2[i] > stack.Peek()) {
            int smaller = stack.Pop();
            nextGreater[smaller] = nums2[i];
        }
        stack.Push(nums2[i]);
    }

    // Los elementos restantes en la pila no tienen un próximo elemento mayor.
    while (stack.Count > 0) {
        nextGreater[stack.Pop()] = -1;
    }

    // Construye el resultado para nums1 utilizando el diccionario.
    int[] result = new int[nums1.Length];
    for (int i = 0; i < nums1.Length; i++) {
        result[i] = nextGreater[nums1[i]];
    }

    return result;
    }
}