using Pile_data_structure.Models;

        // Create an instance of the stack
        CustomStack<int> stack = new CustomStack<int>();

        // Pile up items
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        // Display the stack
        stack.DisplayStack();

        // Check the item at the top
        Console.WriteLine($"Item no topo: {stack.Peek()}");

        // Unstack an item
        stack.Pop();

        // Display the updated stack
        stack.DisplayStack();

        // Unpile all items
        stack.Pop();
        stack.Pop();

        // Check if the stack is empty
        Console.WriteLine($"A pilha está vazia? {stack.IsEmpty()}");