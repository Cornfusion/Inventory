using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ItemDatabase : MonoBehaviour 
{
	public List<Item> items = new List<Item>();

	//Awake is used instead of start, to ensure ItemDatabase is run before Inventory
	void Awake()
	{
		items.Add (new Item("Empty Slot", 0, "", 0, 0, Item.ItemType.Consumable));
		items.Add (new Item("Fire", 1, "Fire Energy - Used for fire spells", 0, 0, Item.ItemType.Reagent));
		items.Add (new Item("Water", 2, "Water Energy - Used for Water spells", 0, 0, Item.ItemType.Reagent));
		items.Add (new Item("Lightning", 3, "Lightning Energy - Used for Lightning spells", 0, 0, Item.ItemType.Reagent));
		items.Add (new Item("Elemental Fusion", 4, "Elemental Fusion - Used to combine two different elements", 0, 0, Item.ItemType.Reagent));

	}
}