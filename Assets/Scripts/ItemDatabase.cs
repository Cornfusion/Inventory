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
		items.Add (new Item("Wood", 1, "A piece of wood - used for crafting", 0, 0, Item.ItemType.Reagent));
		items.Add (new Item("Rock", 2, "A small rock - used for crafting", 0, 0, Item.ItemType.Reagent));
		items.Add (new Item("Meat", 3, "A small chunk of meat - Fills hunger", 0, 0, Item.ItemType.Consumable));
		//items.Add (new Item("Kiralee's rolling pin", 3, "A rolling pin Kiralee uses to bash people with", 4, 0.8f, Item.ItemType.MainHand));
		//items.Add (new Item("Vine", 1, "A vine - used for crafting", 0, 0, Item.ItemType.Reagent));
		//items.Add (new Item("Hand Axe", 100, "A small hand axe - Can be used for harvesting wood or as a weapon", 1, 1, Item.ItemType.MainHand));
	}
}