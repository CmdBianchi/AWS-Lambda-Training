using System.Collections.Generic;
using AWSServerless2.Models;

namespace AWSServerless2.Services
{
    public interface IShoppingListService
    {
        Dictionary<string, int> GetItemsFromShoppingList();
        void AddItemsToShoppingList( ShoppingListModel shoppingList );
        void RemoveItem( string name );
    }
}