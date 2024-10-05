using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linear_List.Models
{
    public class LinearListOperations
    {
        private List<int> _list;

        // Constructor that initializes the list
        public LinearListOperations()
        {
            _list = new List<int>();
        }
        
        // Method to add an item to the list
        public void AddItem(int item)
        {
            _list.Add(item);
            Console.WriteLine($"The item {item} has been added to the list.");
        }

        // // Method to remove an item from the list
        public void RemoveItem(int item)
        {
            if(_list.Contains(item))
            {
                _list.Remove(item);
                Console.WriteLine($"The item {item} has been removed from the list.");
            }
            else
            {
                Console.WriteLine($"The item {item} was not found in the list.");
            }
        }

        // // Method to search for an item in the list
        public bool SearchItem(int item)
        {
            if(_list.Contains(item))
            {
                Console.WriteLine($"The item {item} was found in the list.");
                return true;
            }
            else
            {
                Console.WriteLine($"The item {item} was not found in the list.");
                return false;
            }
        }

        // Method to display the complete list    
        public void DisplayList()
        {

            if (_list.Count == 0)
            {
                Console.WriteLine("A lista está vazia.");
            }
            else
            {
                Console.WriteLine("Itens na lista: " + string.Join(", ", _list));
            }
        }

    }
}