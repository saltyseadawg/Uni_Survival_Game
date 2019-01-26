using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour {
    public string name;
    public int price;
    public int hp;
    public int sp;
    public Item(string newName, int newPrice, int newHP, int newSP)
    {
        name = newName;
        price = newPrice;
        hp = newHP;
        sp = newSP;
    }
}
