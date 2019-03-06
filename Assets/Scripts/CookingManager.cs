using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Manages the display of the cooking menu and cooking activities
 */ 
public class CookingManager : MonoBehaviour
{
    Inventory inventory;
    public CookingManager(Inventory player_inventory)
    {
        inventory = player_inventory;
    }

    //Returns a Food item based on Item combinations from Recipes
    public Food Cook(Item item1, Item item2, Item item3 = null)
    {
        //Made static database to store and retrieve recipes from?

        //if combination exists in database return resulting Food

        //else return glop
        return null;
    }
    
}
