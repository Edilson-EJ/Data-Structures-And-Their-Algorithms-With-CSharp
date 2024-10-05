using Linear_List.Models; 

        // Criar uma instância da lista linear
        LinearListOperations list = new LinearListOperations(); 

        // Adicionar itens à lista
        list.AddItem(10);
        list.AddItem(20);
        list.AddItem(30);

        // Exibir a lista
        list.DisplayList();

        // Buscar um item na lista
        list.SearchItem(20);  
        list.SearchItem(40);  

        // Remover um item da lista
        list.RemoveItem(20);

        // Exibir a lista atualizada
        list.DisplayList();

        // Tentar remover um item que não existe
        list.RemoveItem(50);


