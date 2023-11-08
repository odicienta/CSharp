//Given the head of a singly linked list, reverse the list, and return the reversed list.
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;// Nodo anterior inicialmente es nulo
        ListNode current = head;// Inicializa el nodo actual con la cabeza de la lista original
        ListNode next = null;// Nodo siguiente inicialmente es nulo

        while (current != null) {// Mientras el nodo actual no sea nulo (quedan nodos por procesar)
            next = current.next;// Guarda el siguiente nodo en "next" para no perder la referencia
            current.next = prev;// Invierte el puntero "Next" del nodo actual para que apunte al nodo anterior
            prev = current;// Actualiza el nodo anterior con el nodo actual
            current = next; // Avanza al siguiente nodo en la lista original
        }

        return prev; // Devuelve el nuevo inicio de la lista invertida (que es el último nodo de la lista original)
    }
}