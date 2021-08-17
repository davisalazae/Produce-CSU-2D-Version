using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace ProduceCSU
{
    public class Inventory : Item
    {
        public int wallet = 10;
        private List<Item> itemList;
        public Text money;
        public Text inventory;

        public void addItem(Item item)
        {
            money.text = money.ToString();
        }
        public Inventory()
        {
            itemList = new List<Item>();

            addItem(new Item { foods = Foods.Candy, amount = 3 });
            addItem(new Item { foods = Foods.Chips, amount = 3 });
            addItem(new Item { foods = Foods.Water, amount = 2 });
            Debug.Log("Inventory");
        }
    }
}
