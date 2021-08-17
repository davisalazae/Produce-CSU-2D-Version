using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum Foods
    {
        Chips,
        Soup,
        Water,
        Candy,
        Sub,
        Soda,
        Juice,
    }

    public Foods foods;
    public int amount;
    public float cost;
    public float energyAmount;
}
