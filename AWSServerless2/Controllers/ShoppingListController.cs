using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWSServerless2.Models;
using AWSServerless2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace AWSServerless2.Controllers
{
    [Route( "v1/shoppingList" )]
    public class ShoppingListController : ControllerBase
    {
        private readonly IShoppingListService _shoppingListService;

        public ShoppingListController( IShoppingListService shoppingListService )
        {
            _shoppingListService = shoppingListService;
        }

        [HttpGet]
        public IActionResult GetShoppingList()
        {
            var result = _shoppingListService.GetItemsFromShoppingList();
            return Ok( result );
        }

        [HttpPost]
        public IActionResult AddItemToShoppingList( [FromBody] ShoppingListModel shoppingList )
        {
            _shoppingListService.AddItemsToShoppingList( shoppingList );
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteItemsFromShoppingList( [FromBody] ShoppingListModel shoppingList )
        {
            _shoppingListService.RemoveItem( shoppingList.Name );
            return Ok();
        }
    }
}
