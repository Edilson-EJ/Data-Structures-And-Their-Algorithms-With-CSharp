using Linear_List.Models; 

        // Create an instance of the linear list
        LinearListOperations list = new LinearListOperations(); 

        // Adicionar itens à lista
        list.AddItem(10);
        list.AddItem(20);
        list.AddItem(30);

        /// Add items to the list
        list.DisplayList();

        // Search for an item in the list
        list.SearchItem(20);  
        list.SearchItem(40);  

        // Remove an item from the list
        list.RemoveItem(20);

        // Display the updated list
        list.DisplayList();

        // Trying to remove an item that doesn't exist
        list.RemoveItem(50);


