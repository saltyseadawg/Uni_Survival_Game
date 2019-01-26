using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : Item {

    private string family;
    public Ingredient(string newName, int newHP, int newSP, int newPrice, string newFamily) : base(newName, newHP, newSP, newPrice)
    {
        family = newFamily;
    }
}
