using ComidaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ComidaService.DataAccess
{
    public class ShoppingListController : ApiController
    {


        /*GET OPERATIONS */

        [HttpGet]
        public shoppinglist getAllShoppingLists(int userID)
        {
            return null;
        }

        [HttpGet]
        public shoppinglist getShoppingListByName(int userID, string listName)
        {
            return null;
        }

        [HttpGet]
        public shoppinglist getShoppingListByID(int userID, int listID)
        {
            return null;
        }

        [HttpGet]
        public shoppinglist getShoppingListItems(int userID, int listID)
        {
            return null;
        }

        /*POST OPERATIONS (add) */

        [HttpPost]
        public shoppinglist addShoppingList(int userID, shoppinglist list)
        {
            return null;
        }

        [HttpPost]
        public shoppinglistitem addShoppingListItem(int userID, int shpoppingListID, shoppinglistitem item)
        {
            return null;
        }

        [HttpPost]
        public shoppinglistitem addShoppingListMember(int shoppingListMemberID, int shoppingListID)
        {
            return null;
        }

        /* PUT OPERATIONS (update) */

        [HttpPut]
        public void updateShoppingList(shoppinglist list)
        {
            
        }

        [HttpPut]
        public void updateShoppingItem(shoppinglistitem item)
        {
            
        }

        /* DELETE OPERATIONS */

        [HttpDelete]
        public void deleteShopping(int shoppingListID)
        {
            
        }

        [HttpDelete]
        public void deleteShoppingItem(int shoppingListItemID)
        {
            
        }

    }
}
