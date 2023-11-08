

public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> result = new List<IList<int>>();//genera una lista de listas para el resultado
        
        for (int i = 0; i < numRows; i++) {//mientras i sea menor al numero de rows continue incrementando en 1
            List<int> row = new List<int>();//nueva lista llamada row
            
            for (int j = 0; j <= i; j++) {//mientras j sea menor o igual a i continue incrementando en 1
                if (j == 0 || j == i) {//si j es igual a cero o j es igual a i
                    row.Add(1);//agregue una fila
                } else {
                    // Use the formula to calculate the value based on the two numbers above it
                    int val = result[i - 1][j - 1] + result[i - 1][j];
                    row.Add(val);
                }
            }
            
            result.Add(row);
        }
        
        return result;  
    }
}