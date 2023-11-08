public class Solution {//Clase llamada solution
    public int Fib(int n) {//Método público llamado "Fib" que toma un parámetro "n" y devuelve un entero.
        if (n == 0) return 0;
        if (n == 1) return 1;
        //casos base. Si n es igual a 0, la función devuelve 0, y si n es igual a 1, la función devuelve 1. 
        //Estos son los dos primeros números de la secuencia de Fibonacci.
    
        int[] fib = new int[n + 1];//Se declara un arreglo de enteros llamado "fib" con una longitud de n + 1. 
        //Esto se hace para almacenar los valores de la secuencia de Fibonacci desde 0 hasta n.
        fib[0] = 0;
        fib[1] = 1;
        //Se asignan los valores iniciales de la secuencia de Fibonacci (0 y 1) a los primeros dos elementos del arreglo.
    
        for (int i = 2; i <= n; i++) {//bucle for que comienza en 2 y se ejecuta hasta n
            fib[i] = fib[i - 1] + fib[i - 2];//con esta operacion estamos haciendo que i, o sea la current position, sea la suma de la posicion anterior mas la ante-anterior
        }
    
        return fib[n];//aca devolvemos el valor de fib(n)
    }
}