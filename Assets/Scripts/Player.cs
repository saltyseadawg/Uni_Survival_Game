using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private string name;
    private int hp;
    private int sp;
    private int money;
    private Inventory inventory;

    public Player(string newName)
    {
        name = newName;
        hp = 100;
        sp = 100;
        money = 100;
        inventory = new Inventory();
    }

    public void setName(string newName)
    {
        name = newName;
    }

    public void setHP(int newHP)
    {
        hp = newHP;
    }
    
    public void setSP(int newSP)
    {
        sp = newSP;
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
        return hp;
    }
    public int getSP()
    {
        return sp;
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
