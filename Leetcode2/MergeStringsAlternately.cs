public class Solution {
    public string MergeAlternately(string word1, string word2) {//Metodo MergeAlternately con dos cadenas de caracteres Word1 y Word2w
        StringBuilder merged = new StringBuilder();//creacion del objeto StringBuilder llamado merged para construir la cadena resultante
        //StringBuilder es preferible cuando se va a realizar una concatenacion de cadenas repetitiva
        int i = 0, j = 0;//Se declaran dos variables enteras, "i" y "j", que se utilizarán como índices para recorrer las cadenas "word1" y "word2", respectivamente.
    
        while (i < word1.Length || j < word2.Length) {//Se inicia un bucle "while" que se ejecutará mientras al menos una de las cadenas no haya sido completamente recorrida. 
            if (i < word1.Length) {//verificamos si aun quedan caracteres por recorrer en word1
                merged.Append(word1[i]);//agregamos el caracter a la cadena merged
                i++;// e incrementamos en uno
        }
        
            if (j < word2.Length) {//verificamos si aun quedan caracteres por recorrer en word2
                merged.Append(word2[j]);//agregamos el caracter a la cadena merged
                j++;//e incrementamos en uno
            }
        }
    
    return merged.ToString();//devolvemos la cadena resultante y la pasamos a String con ToString();
    }
}