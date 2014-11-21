using UnityEngine;
using System.Collections;

[System.Serializable]

public class Item
{

	//ITEM ATTRIBUTES
	public string itemName;
	public int itemID;
	public string itemDesc;
	public Texture2D itemIcon;

	public int itemDamage;
	public float itemSpeed;

	public ItemType itemType;

	public enum ItemType
	{
		MainHand,
		OffHand,
		Head,		
		Chest,		
		Hands,
		Legs,
		Feet,
		Consumable,
		Reagent

	}

	public Item(string name, int id, string desc, int damage, float speed, ItemType type)
	{
		itemName = name;
		itemID = id;
		itemDesc = desc;
		itemIcon = Resources.Load<Texture2D> ("ItemIcons/" + name);
		itemDamage = damage;
		itemSpeed = speed;
		itemType = type;
	}

	public Item()
	{

	}


}
