using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pile_data_structure.Models
{
    public class CustomStack<T> 
    {
        private List<T> _stack;

        // Constructor that initializes the stack
        public CustomStack()
        {
            _stack = new List<T>();
        }

        // Method for stacking an item
        public void Push(T item)
        {
            _stack.Add(item);
            Console.WriteLine($"The item {item} has been stacked.");
        }

        // Method to unpile an item
        public T Pop()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("The pile is empty.");
            }

            // O que o operador ^ faz
            // Operador de Índice de Acesso Negativo: O operador ^ é uma forma de acessar elementos
            //  de uma coleção a partir do final. Assim, ^1 refere-se ao último elemento da lista, 
            //  ^2 ao penúltimo, e assim por diante.
            // Get the top item
            T item = _stack[^1]; 
            // Remove the item from the top
            _stack.RemoveAt(_stack.Count - 1); 
            Console.WriteLine($"The item {item} has been unstacked.");
            return item;
        }

        public T Peek()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("The pile is empty.");
            }
            // Returns the top item
            return _stack[^1]; 
        }

        // Method to check if the stack is empty
        public bool IsEmpty()
        {
            return _stack.Count == 0;
        }

        // Method to display stack items
        public void DisplayStack()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The pile is empty.");
            }
            else
            {
                Console.WriteLine("Items in the pile: " + string.Join(", ", _stack));
            }
        }
    }
}