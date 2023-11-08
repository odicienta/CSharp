public class Solution {
    public string RemoveDuplicates(string s) {
        Stack<char> stack = new Stack<char>();
    
        foreach (char c in s) {
            if (stack.Count > 0 && stack.Peek() == c) {
                stack.Pop();  // Si el caracter actual es igual al tope de la pila, lo eliminamos
            } else {
                stack.Push(c); // Si no es un duplicado, lo agregamos a la pila
        }
    }
    
    char[] resultArray = stack.ToArray();
    Array.Reverse(resultArray); // Volteamos la pila para obtener el resultado correcto
    
    return new string(resultArray);
    }
}