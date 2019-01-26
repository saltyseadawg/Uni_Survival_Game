using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private string name;
    private int HP;
    private int SP;
    private int money;
    private InventoryManager inventoryManager;

    public Player(string newName)
    {
        name = newName;
        HP = 100;
        SP = 100;
        money = 100;
        inventoryManager = new InventoryManager();
    }

    public void setName(string newName)
    {
        name = newName;
    }

    public void setHP(int newHP)
    {
        HP = newHP;
    }
    
    public void setSP(int newSP)
    {
        SP = newSP;
    }
    public void setMoney(int newMoney)
    {
        money = newMoney;
    }
    public string getName()
    {
        return name;
    }
    public int getHP()
    {
        return HP;
    }
    public int getSP()
    {
        return SP;
    }
    public int getMoney()
    {
        return money;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
